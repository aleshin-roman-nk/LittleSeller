using LettleSellerKost.BL.adv.DbLayer;
using LittleSellerKost;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.Presenters.SrvPresenters
{
	public class ReceiptsHistoryPresenter
	{
		static IViewPeceiptsHistory view;

		public static void Go()
		{
			view = new FormCashVoucherHistory();

			view.ReservPerformed += View_ReservPerformed;

			update();

			view.ShowView();

			view = null;
		}

		//private static void View_ReservPerformed(BL.adv.Entities.ReservedReceipt obj)
		private static void View_ReservPerformed(Receipt obj)
		{
			//DbReservedReceipts.Kill(obj);
			DbReceiptHistory.Perform(obj);
			update();
		}

		private static void update()
		{
			//var o = DbReservedReceipts.GetAll();
			var o = DbReceiptHistory.GetReceipts(DateTime.Today);
			view.SetCollection(o);
		}
	}
}
