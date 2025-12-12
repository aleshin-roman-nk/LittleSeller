using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace TransacSender
{
	public enum ATStatus { Working, Waiting, Stopped }

	internal class AsyncRunner
	{
		public ATStatus State { get; private set; }

		public event Action<ATStatus> StateChanged;

		public event Action<int> Update;
		public event Action Started;
		public event Action TaskStopped;
		public event Action WorkStarted;
		public event Action DelayBeforeWork;

		Task thatTask;
		CancellationTokenSource cts;
		Action action = null;
		int interval;

		public AsyncRunner(Action a, int milliseconds = 1000)
		{
			interval = milliseconds;
			action = a;
		}

		public void Run()
		{
			if(thatTask == null)
			{
				State = ATStatus.Stopped;
				cts = new CancellationTokenSource();
				thatTask = Task.Run( () => progr(cts.Token) );
				Started?.Invoke();
			}
		}

		public async Task Stop()
		{
			if (cts == null || thatTask == null) return;

			cts.Cancel();

			try
			{
				await thatTask;
			}
			catch (Exception)
			{

			}

			cts.Dispose();
			thatTask.Dispose();

			cts = null;
			thatTask = null;

			State = ATStatus.Stopped;
			TaskStopped?.Invoke();
			StateChanged?.Invoke(State);
		}

		async Task goOnce()
		{
			await Task.Run(action);
		}

		public bool IsWorking
		{
			get
			{
				return State == ATStatus.Working;
			}
		}

		public bool IsStopped
		{
			get
			{
				return State == ATStatus.Stopped;
			}
		}

		async Task progr(CancellationToken token)
		{
			while (true)
			{
				DelayBeforeWork?.Invoke();
				State = ATStatus.Waiting;
				StateChanged?.Invoke(State);

				await Task.Delay(interval, token);

				WorkStarted?.Invoke();
				State = ATStatus.Working;
				StateChanged?.Invoke(State);

				action?.Invoke();
				Update?.Invoke(100);

				if (token.IsCancellationRequested)
				{
					break;
				}
			}
		}
	}
}
