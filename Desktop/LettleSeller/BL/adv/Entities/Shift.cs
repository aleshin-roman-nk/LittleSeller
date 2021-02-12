using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Entities
{

	public enum ShiftState { Undefined = -1, Closed = 0, Opened = 1, Expired = 2 }// Когда создается новая смена она сразу открыта

	// Смена в смысле продажи
	public class Shift
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public DateTime? EndDate { get; set; }
		public ShiftState State { get; set; }
		// Лучше отдельно. Некогда сейчас разбираться с суперкаскадными операциями.
		//public List<Receipt> Receipts { get; set; } = new List<Receipt>();
	}
}
