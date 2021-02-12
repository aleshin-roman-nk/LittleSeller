using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Views
{
	public interface IViewTodayMenuEditor
	{
		void SetProductTypes(TypeProduct[] items);
		void SetMenuProducts(IEnumerable<ShiftMenuItem> items);
		void SetCategories(Category[] items);

		void SetCurrentCategory(string item);

		event Action<Category> CategoryChanged;
		event Action PrintMenu;
		event Action ExportCvs;
		event Action<TypeProduct> AddShiftMenuItem;
		event Action<ShiftMenuItem> DeleteMenuItem;
		event Action<TypeProduct> EditTypeProduct;
		event Action CreateTypeProduct;
		event Action<TypeProduct> DeleteTypeProduct;
		event Action<IEditableProductItem> EditMenuItemWeights;
		event Action WebLoadShiftMenu;
		event Action<ShiftMenuItem> DiscountChange;
		event Action<ShiftMenuItem> BalanceChange;
		

		void ShowView();

		void ShowMessage(string msg);
		bool UserAnswerYes(string msg);
		bool ShowGetNumber(string msg, out decimal v);

		IViewEditWeights ViewEditWeights { get; }
		IViewEditProduct ViewEditProduct { get; }
	}
}
