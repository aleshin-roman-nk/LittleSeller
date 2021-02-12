using LittleSellerKost.BL.adv.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransacSender;

namespace LettleSellerKost.BL.Web
{
	public class TransactionManager
	{
		WebSender webSender;

		public event Action<int> Updated;
		public event Action<string> Error;

		public TransactionManager()
		{
			webSender = new WebSender();
			webSender.Updated += WebSender_Updated;
			webSender.Error += WebSender_Error;
		}

		public void Start()
		{
			webSender.Start();
		}

		public void RegisterReceiptTrans(Receipt r)
		{
			webSender.PutTransaction(new Transaction("reg_receipt", r));
		}

		public void RegisterShiftTrans(Shift shift)
		{
			webSender.PutTransaction(new Transaction("reg_shift", shift));
		}

		private void WebSender_Error(string obj)
		{
			Error?.Invoke(obj);
		}

		private void WebSender_Updated(int obj)
		{
			Updated?.Invoke(obj);
		}
	}
}
