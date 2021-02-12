using LettleSellerKost.BL.adv.Entities;
using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv
{
	public class DbAppData: DbContext
	{
		public DbAppData(string cn = @"Data Source = ..\db\kassa.db") : base(cn)
		{

		}

		public DbSet<ReceiptItem> ReceiptItems { get; set; }
		public DbSet<Receipt> Receipts { get; set; }
		public DbSet<TypeProduct> TypeProducts { get; set; }
		public DbSet<ShiftMenuItem> ShiftMenuItems { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ShiftMenu> ShiftMenus { get; set; }
		public DbSet<Shift> Shifts { get; set; }
		public DbSet<ReservedReceipt> ReservedReceipts { get; set; }

		public static void Go( Action<DbAppData> action )
		{
			using (DbAppData db = new DbAppData())
			{
				action.Invoke(db);
			}
		}
	}
}