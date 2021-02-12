using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransacSender;

namespace LettleSellerKost.BL.Web
{
	class WebSender
	{
		TransactionBox transactionBox;

		public event Action<int> Updated;
		public event Action<string> Error;
		public WebSender()
		{
			//transactionBox = new TransactionBox("http://canteenfw.loc");//
			transactionBox = new TransactionBox("http://menu-kom.ru");
			transactionBox.BufferEnpty += TransactionBox_BufferEnpty;
			transactionBox.Error += TransactionBox_Error;
		}

		private void TransactionBox_Error(string obj)
		{
			Error?.Invoke(obj);
		}

		public void Start()
		{
			transactionBox.Start();
		}

		private void TransactionBox_BufferEnpty(int obj)
		{
			Updated?.Invoke(obj);
		}

		public void PutTransaction(Transaction tr)
		{
			transactionBox.SendLater(tr);
		}
	}
}
