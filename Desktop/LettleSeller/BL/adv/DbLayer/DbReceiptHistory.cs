using LittleSellerKost.BL.adv;
using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.BL.adv.DbLayer
{
	public class DbReceiptHistory
	{
		public static IEnumerable<Receipt> GetReceipts(DateTime date)
		{
			DateTime d1 = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
			DateTime d2 = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);

			using (DbAppData db = new DbAppData())
			{
				return db.Receipts.Include("ReceiptItems").Where(s=> s.Date >= d1 && s.Date <= d2).ToList();
			}
		}

		static bool isInDate(DateTime d)
		{
			DateTime d1 = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0);
			DateTime d2 = new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);

			return (d >= d1) && (d <= d2);
		}

		internal static void Perform(Receipt obj)
		{
			//obj.Reserved = false;
			obj.Reserved = !obj.Reserved;
			DbReceipt.Store(obj);
		}
	}
}