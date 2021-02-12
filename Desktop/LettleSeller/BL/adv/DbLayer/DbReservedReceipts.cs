using LettleSellerKost.BL.adv.Entities;
using LittleSellerKost.BL.adv;
using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.BL.adv.DbLayer
{
	public static class DbReservedReceipts
	{
		public static void Add(Receipt r)
		{
			ReservedReceipt reserved = ReservedReceipt.FromReceipt(r);

			using (DbAppData db = new DbAppData())
			{
				db.Entry(reserved).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
			}
		}
		public static IEnumerable<ReservedReceipt> GetAll()
		{
			using (DbAppData db = new DbAppData())
			{
				return db.ReservedReceipts.Include("Receipt.ReceiptItems").ToList();
			}
		}

		public static void Kill(ReservedReceipt r)
		{
			if (r == null) return;

			using (DbAppData db = new DbAppData())
			{
				db.Entry(r).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
	}
}
