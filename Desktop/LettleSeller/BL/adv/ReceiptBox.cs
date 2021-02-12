using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Models
{
	public interface IExternOnlineKassa
	{
		void Send(Receipt r);
	}

	// Механизм работы одного чека. Прячет обращение к бд.
	// По сути это модель
	public class ReceiptBox
	{
		Receipt ThisReceipt { get; set; } = null;

		public Receipt Receipt { get => ThisReceipt; }

		public bool IsOpened
		{
			get
			{
				if (ThisReceipt == null)
					return false;

				return !ThisReceipt.Closed;
			}
		}

		Receipt create(Shift shift)
		{
			return new Receipt
			{
				Date = DateTime.Now,
				Closed = false,
				ShiftId = shift.Id
			};
		}

		public void CloseReceipt()
		{
			commit();
			ThisReceipt = null;
		}

		public void CancelReceipt()
		{
			if (ThisReceipt == null) return;

			DbReceipt.Kill(ThisReceipt);
			ThisReceipt = null;
		}

		public void AddPosition(Shift shift, ShiftMenuItem src, ReceiptPositionBuildOptions pos_options)
		{
			//Не логично здесь что то проверять. Пусть этим занимаются соответсвующие элементы алгоритма
			//if (shift.State == ShiftState.Closed || shift.State == ShiftState.Expired) return;

			if (ThisReceipt == null) ThisReceipt = create(shift);

			var item = ReceiptItem.Create(ThisReceipt, src, pos_options);

			ThisReceipt.ReceiptItems.Add(item);
		}

		public void RemovePosition( ReceiptItem item )
		{
			if (ThisReceipt == null) return;

			var _it = ThisReceipt.ReceiptItems.FirstOrDefault(x => x.Id == item.Id);// id у нас нету, поэтому не модем удалять по id

			if (_it == default(ReceiptItem)) return;

			//ThisReceipt.ReceiptItems.Remove(_it);
			ThisReceipt.ReceiptItems.Remove(item);
		}

		public IEnumerable<ReceiptItem> Items
		{
			get
			{
				if (ThisReceipt == null) return new List<ReceiptItem>();
				return ThisReceipt.ReceiptItems;
			}
		}

		public decimal ReceiptAmount
		{
			get
			{
				if (ThisReceipt == null) return 0;
				return ThisReceipt.Amount;
			}
		}

		void commit(IExternOnlineKassa ex_dev = null)
		{
			if (ThisReceipt == null) return;

			ThisReceipt.Closed = true;
			DbReceipt.Store(ThisReceipt);
		}
	}
}
