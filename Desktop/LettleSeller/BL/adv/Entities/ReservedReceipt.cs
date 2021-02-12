using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.BL.adv.Entities
{

	public class ReservedReceipt
	{
		public int id { get; set; }
		public int ReceiptId { get; set; }
		public bool given { get; set; }
		public Receipt Receipt { get; set; }

		public IEnumerable<ReceiptItem> Items
		{
			get
			{
				return Receipt.ReceiptItems;
			}
		}
		public string ReceiptDateTime {
			get
			{
				return Receipt == null ? "-" : Receipt.DateMySQL;
			}
		}
		public static ReservedReceipt FromReceipt(Receipt receipt)
		{
			return new ReservedReceipt { given = false, ReceiptId = receipt.Id };
		}
	}
}
