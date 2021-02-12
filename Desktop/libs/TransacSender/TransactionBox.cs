using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransacSender
{
	public class TransactionBox
	{
		AsyncRunner asyncRunner;
		Server server;
		RepoDb<Transaction> repoWork;// вполне можно объединить
		QBuffer<Transaction> qBuffer;//		внутрь буффера
		TransactionSender transactionSender;

		public event Action<IEnumerable<Transaction>> Updated;
		public event Action<ATStatus> StateChanged;
		public event Action<string> Error;
		//public event Action<bool> InternetConnection;
		public event Action<int> BufferEnpty;

		public TransactionBox(string baseUrl)
		{
			asyncRunner = new AsyncRunner(asyncProgram, 2000);
			server = new Server(baseUrl);

			transactionSender = new TransactionSender(server);
			asyncRunner.StateChanged += AsyncRunner_StateChanged;

			initCache();
		}

		private void initCache()
		{
			repoWork = new RepoDb<Transaction>("work_transactions");
			qBuffer = new QBuffer<Transaction>("cache_transactions");

			//qBuffer.AddRange(getIncompleteTrans());
		}

		private void asyncProgram()
		{
			if (!qBuffer.IsEmpty)
			{
				var tr = qBuffer.PeekItem();
				var res = transactionSender.send(tr);

				Updated?.Invoke(qBuffer.Items);

				if (res.error_code == ResponseErrorCodes.TransactionAlready || res.state == TransactionStates.Completed)
				{
					qBuffer.RemoveFirst();
					Updated?.Invoke(qBuffer.Items);
					BufferEnpty?.Invoke(qBuffer.Count);
					return;
				}

				Error?.Invoke($"Error: {res.error_msg}");
				// Если ошибка подключения к серверу, удалять нельзя
				// Однако в будущем транзакции должны гарантированно выполняться в строгом порядке.
				//		Например открытие смены и только потом регистрация чеков, также изменение состояния наличия
				if(res.error_code != ResponseErrorCodes.ErrInternetConnection)
					qBuffer.RemoveFirst();
				qBuffer.ReputItem();
				Updated?.Invoke(qBuffer.Items);
			}

			BufferEnpty?.Invoke(qBuffer.Count);
		}

		private void AsyncRunner_StateChanged(ATStatus obj)
		{
			StateChanged?.Invoke(obj);
		}

		public void Start()
		{
			BufferEnpty?.Invoke(qBuffer.Count);
			//Updated?.Invoke(repoWork.Items);
			Updated?.Invoke(qBuffer.Items);
			asyncRunner.Run();
		}

		public Transaction SendRightNow(Transaction trans)
		{
			return transactionSender.send(trans);
		}

		public void SendLater(Transaction trans)
		{
			qBuffer.PutItem(trans);
			var v = qBuffer.Count;
			BufferEnpty?.Invoke(v);
			//Updated?.Invoke(repoWork.Items);
			Updated?.Invoke(qBuffer.Items);
		}

		IEnumerable<Transaction> getIncompleteTrans()
		{
			return from x in repoWork.Items
				   where x.state == TransactionStates.Incompleted
				   select x;
		}
	}

	internal class TransactionSender
	{
		Server server;
		public TransactionSender(Server s)
		{
			server = s;
		}

		public Transaction send(Transaction tr)
		{
			tr.error_msg = null;
			//tr.error_code = ResponseErrorCodes.Undefined;

			// Если отсутствует gkey, запрашиваем server и присваиваем
			if (!tr.HasGKey)
			{
				var gkey = requestGKey();
				if (gkey.HasError)
				{
					tr.error_msg = gkey.error_msg;
					tr.error_code = gkey.error_code;
					return tr;
				}
				else
				{
					tr.GKey = (long)gkey.data;
				}
			}

			var response = sendTransaction(tr);
			if (!response.HasError)
			{
				tr.state = TransactionStates.Completed;
				tr.error_code = ResponseErrorCodes.Ok;
				tr.data_response = response.data;
				return tr;
			}
			else
			{
				tr.error_msg = response.error_msg;
				tr.error_code = response.error_code;
				return tr;
			}
		}

		Response sendTransaction(Transaction t)
		{
			return server.SendTransaction(t);
		}

		Response requestGKey()
		{
			return sendTransaction(new Transaction("get_gkey"));
		}
	}
}
