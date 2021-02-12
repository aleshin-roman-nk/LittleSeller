using LettleSellerKost.BL;
using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Models
{
	/*
	 * Собираем работу кассы в этом модуле.
	 * - Работа со сменой, работа с чеком.
	 * - Получение зарегистрированных смен.
	 * - Получение истории чеков.
	 * - Информация о смене.
	 * - Информация о чеке.
	 * 
	 */



	/*
	 * 1. Начало работы:
	 *	- открытие локальной смены;
	 *	- открытие смены в аппарате.
	 *	- установка индикатора состояния смены во view.
	 *	
	 * 2. При перезапуске ПО:
	 *  - проверка состояния смены в аппарате;
	 *  - проверка состояния локальной смены;
	 *  - установка индикатора состояния смены во view.
	 *  
	 *  
	 * 2.1  
	 *  
	 *  
	 *  
	 *  
	 * 3. При завершени работы:
	 *  - закрытие смены в аппарате;
	 *  - закрытие локальной смены.
	 * 
	 * В течение смены операторы могут меняться, поэтому регистрация оператора перед каждой
	 * операцией.
	 * 
	 */

	public interface IKktDevice
	{
		string CloseShift();
		string OpenShift();
		void OpenReceipt();
		string CloseReceipt();
		void AddRecieptPosition(string name, int price, decimal quantity);
		bool IsShiftOpened { get; }
		bool IsShiftClosed { get; }
		bool IsShiftExpired { get; }
		void Payment(bool cash, double sum);
		bool Ready { get; }
		ShiftState ShiftState { get; }
	}

	public class CashBox
	{
		IKktDevice devKKT;
		public ReceiptBox ReceiptBox { get; private set; }
		public ShiftBox ShiftBox { get; private set; }

		public bool KktReady => devKKT.Ready;

		public void ReloadShiftInfo()
		{
			ShiftBox.Update();
		}

		public CashBox()
		{
			ShiftBox = new ShiftBox();
			ReceiptBox = new ReceiptBox();
#if DEBUG
			devKKT = new KKTTest();// Тестовый режим кассы
#else
			devKKT = new KKTATOL();// Бевой режим кассы
#endif

			if (devKKT.IsShiftOpened) ShiftBox.ReadLast();
		}

		public void AddReceiptPosition(ShiftMenuItem src, ReceiptPositionBuildOptions pos_options)
		{
			ReceiptBox.AddPosition(ShiftBox.Shift, src, pos_options);
		}

		public ShiftState ShiftState
		{
			get => devKKT.ShiftState;
		}

		public bool IsShiftOpened
		{
			get => devKKT.ShiftState == ShiftState.Opened;
		}

		public bool IsShiftExpired
		{
			get => devKKT.ShiftState == ShiftState.Expired;
		}

		public bool IsShiftClosed
		{
			get => devKKT.ShiftState == ShiftState.Closed;
		}

		public string OpenShift(DateTime today)
		{
			if (devKKT.IsShiftOpened) return "Смена уже открыта";

			var res = devKKT.OpenShift();

			if (devKKT.IsShiftOpened)
			{
				ShiftBox.Open(today);
				return "Смена успешно открылась";
			}
			else return "Смена не открылась. Возможно отсутствует чековая лента";
		}

		public string CloseShift()
		{
			if (devKKT == null) return "ККТ не инициализированно";

			if (devKKT.IsShiftClosed) return "Смена уже закрыта";

			devKKT.CloseShift();
			if (devKKT.IsShiftClosed)
			{
				ShiftBox.Close();
				return "Смена успешно закрыта";
			}
			else return "Смена не закрылась в ККТ";
		}

		public string Sell(bool isCash)// Переделать, чтобы передавать входную информацию о создаваемом чеке
		{
			string res = null;

			if (devKKT == null) return res;


			devKKT.OpenReceipt();

			foreach (var item in ReceiptBox.Items)
			{
				devKKT.AddRecieptPosition(item.Name, item.DiscPrice.Value, item.Count.Value);
			}

			devKKT.Payment(isCash, Convert.ToDouble(ReceiptBox.ReceiptAmount));


			ReceiptBox.CloseReceipt();// Возможно вынести в отдельную операцию. Но при вызове Sell пометить, что чек отбит и требует закрытия, добавление запрещено.
									  //		Все проверки и запреты в ReceiptBox. CashBox только у себя помечает, что добавлять нельзя, нужно вызвать ReceiptBox.CloseReceipt()
									  //			Сам CashBox как узнает о закрытии? Может быть внутренне подпишется на событие закрытия и будет сбрасывать флаг запреиа операций

			return devKKT.CloseReceipt();// переделать нормальный возврат строки, типа чек успешно зафиксирован
		}
	}
}
