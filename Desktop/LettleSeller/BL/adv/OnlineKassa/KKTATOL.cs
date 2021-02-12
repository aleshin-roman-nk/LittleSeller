using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atol.Drivers10.Fptr;
using LittleSellerKost.BL.adv.Entities;

namespace LittleSellerKost.BL.adv.Models
{
	public class KKTATOL: IKktDevice
	{
		int startCode = -1;

		IFptr kkt = null;

		const string OperatorName = "ИП Алешин Роман Владимирович";
		const string OperatorINN = "421807193518";

		public KKTATOL()
		{
			kkt = new Fptr();
			startCode = kkt.open();
		}

		~KKTATOL()
		{
			if(kkt != null)
			{
				kkt.close();
				kkt = null;
			}
		}
 
		/*
		 * Написать интерфейсную алгоритмическую абстракцию.
		 * Без наполнения методов кодом работы с ККТ.
		 */

		/*
		 * Выводить инфу о смене в устройстве и локальную.
		 */

		public bool Ready
		{
			get
			{
				// Запрос информации о ккт. Для проверки подключения аппарата.
				kkt.setParam(Constants.LIBFPTR_PARAM_DATA_TYPE, Constants.LIBFPTR_DT_MODEL_INFO);
				var res = kkt.queryData();

				//ShowDebug.ShowObject($"{kkt.errorCode()} - ({kkt.errorDescription()})");

				return res == 0;
			}
		}

		public ShiftState ShiftState
		{
			get
			{
				if (!Ready) return ShiftState.Undefined;

				kkt.setParam(Constants.LIBFPTR_PARAM_DATA_TYPE, Constants.LIBFPTR_DT_SHIFT_STATE);
				kkt.queryData();

				uint state = kkt.getParamInt(Constants.LIBFPTR_PARAM_SHIFT_STATE);

				ShiftState res = ShiftState.Closed;

				if (state == Constants.LIBFPTR_SS_CLOSED)
					res = ShiftState.Closed;
				else if (state == Constants.LIBFPTR_SS_EXPIRED)
					res = ShiftState.Expired;
				else if (state == Constants.LIBFPTR_SS_OPENED)
					res = ShiftState.Opened;

				return res;
			}
		}

		public bool IsShiftOpened => ShiftState == ShiftState.Opened;
		public bool IsShiftClosed => ShiftState == ShiftState.Closed;
		public bool IsShiftExpired => ShiftState == ShiftState.Expired;

		public void OFDTest()
		{
			kkt.setParam(Constants.LIBFPTR_PARAM_REPORT_TYPE, Constants.LIBFPTR_RT_OFD_TEST);
			kkt.report();
		}

		public string CloseShift()
		{
			kkt.setParam(Constants.LIBFPTR_PARAM_REPORT_TYPE, Constants.LIBFPTR_RT_CLOSE_SHIFT);
			kkt.report();

			return checkDocumentClosed();
		}

		//Открывать локльную смену, только если открылась смена в ККТ
		// Хотя это может быть две параллельные вселенные.
		public string OpenShift()
		{
			kkt.setParam(1021, OperatorName);
			kkt.setParam(1203, OperatorINN);
			kkt.operatorLogin();

			kkt.openShift();

			return checkDocumentClosed();
		}

		string checkDocumentClosed()
		{
			int res = kkt.checkDocumentClosed();

			if (res == 0) return null;

			return kkt.errorDescription();
		}

		public void OpenReceipt()
		{
			kkt.setParam(1021, OperatorName);
			kkt.setParam(1203, OperatorINN);
			kkt.operatorLogin();

			// Открытие чека
			kkt.setParam(Constants.LIBFPTR_PARAM_RECEIPT_TYPE, Constants.LIBFPTR_RT_SELL);
			kkt.openReceipt();
		}

		public string CloseReceipt()
		{
			kkt.closeReceipt();

			var res = checkDocumentClosed();

			kkt.continuePrint();

			return res;
		}

		public void AddRecieptPosition(string name, int price, decimal quantity)
		{
			kkt.setParam(Constants.LIBFPTR_PARAM_COMMODITY_NAME, name);
			kkt.setParam(Constants.LIBFPTR_PARAM_PRICE, price);
			kkt.setParam(Constants.LIBFPTR_PARAM_QUANTITY, Convert.ToDouble(quantity));
			kkt.setParam(Constants.LIBFPTR_PARAM_TAX_TYPE, Constants.LIBFPTR_TAX_NO);
			kkt.setParam(1212, 0);
			var r = kkt.registration();
		}

		public void Payment(bool cash, double sum)
		{
			int payType = cash ? Constants.LIBFPTR_PT_CASH : Constants.LIBFPTR_PT_ELECTRONICALLY;
			// Оплата
			kkt.setParam(Constants.LIBFPTR_PARAM_PAYMENT_TYPE, payType);
			kkt.setParam(Constants.LIBFPTR_PARAM_PAYMENT_SUM, sum);
			kkt.payment();
		}
	}
}
