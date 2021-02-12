using LittleSellerKost.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.Presenters.SrvPresenters
{
	public class CommitSellPresenter
	{
		public static ViewResultReceiptCommit Go(decimal amount)
		{
			IViewReceiptCommit view = new FormReceiptCommit();

			view.SetAmount(amount);
			return view.ShowView();
		}
	}
}
