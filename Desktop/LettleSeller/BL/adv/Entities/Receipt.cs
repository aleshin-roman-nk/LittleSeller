using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Entities
{
	/*
	 * >>>
	 * Идея по аналогии с устройство html-js:
	 *		не все данные формируются на стороне сервера
	 *		допустимо отдавать все данные, и на стороне клиента с поможью js уже операции с видами
	 *	Таким же образом логика операций над формированием вида переносится в отдел view.
	 *		Внутри View ответственость за формирование вида
	 * 
	 */

	public class Receipt
	{
		public int Id { get; set; }
		public int ShiftId { get; set; }
		public DateTime Date { get; set; }
		public string DateMySQL { get { return Date.ToString("yyyy-MM-dd HH:mm:ss"); } }
		public bool Closed { get; set; } = false;
		public bool Card { get; set; } = false;
		public bool? Reserved { get; set; } = false;
		public string urkey { get; set; }
		public List<ReceiptItem> ReceiptItems { get; set; } = new List<ReceiptItem>();
		public decimal Amount => ReceiptItems.Sum(x => x.DiscPrice.Value * x.Count.Value);
	}
}
