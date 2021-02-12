using LittleSellerKost.BL.adv.DbLayer;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.BL.adv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Models
{
	/*
	 * Этот класс несет ответсвенность за предотвращение несанкционированное изменение состояния смены
	 * 
	 * Как сделать защиту, чтобы сторонние модули немогли изменить объект?
	 * Чтобы был доступ к полям сущности только для чтения?
	 * Один из вариантов: работать через промсущность с полями только для чтения.
	 * 
	 * С другой стороны конечная задача - защита от изменения конечным пользователем.
	 *	А не столько программистом от самого себя.
	 * 
	 * 
	 */

	/*
	 * 
	 * >>>Логика проверена<<<
	 * 
	 */
	public class ShiftBox
	{
		public Shift Shift { get; private set; } = null;
		public void ReadLast()
		{
			Shift = DbShift.GetLast();
		}
		public void Close()
		{
			DbShift.CloseShift(Shift, DateTime.Now);
		}
		public void Open(DateTime today)
		{
			Shift = DbShift.Create(today);
		}
		public void Update()
		{
			if(Shift != null)
				Receipts = DbShift.FindReceipts(Shift);
		}
		public IEnumerable<Receipt> Receipts { get; private set; } = null;
		public int ReceiptsCount => Receipts == null ? 0 : Receipts.Count();
		public decimal ReceiptsAmount => Receipts == null ? 0 : Receipts.Sum(x => x.Amount);
	}
}
