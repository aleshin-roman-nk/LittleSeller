using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSellerKost.Presenters.SrvPresenters
{
	public class ReceiptPositionBuilderPresenter
	{
		public ReceiptPositionBuildOptions Go(ShiftMenuItem src)
		{
			var myWPList = src.GetMyWP();

			//if(myWPList.Count() == 1)
			//	return myWPList.First();

			IViewReceiptPositionBuildOptions view = new FormReceiptPositionBuild();
			view.SetCollection(myWPList);

			if (view.ShowView())
				{
					return new ReceiptPositionBuildOptions
					{
							DPrice = view.Current.DPrice,
							Count = view.Current.Count,
							Price = view.Current.Price,
							Weight = view.Current.Weight
					};
				}

			return null;
		}
	}
}
