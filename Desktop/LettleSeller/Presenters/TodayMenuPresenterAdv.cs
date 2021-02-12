using Newtonsoft.Json;
using LittleSellerKost.BL.adv;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.BL.adv.PrinterModel;
using LittleSellerKost.Core;
using LittleSellerKost.Forms;
using LittleSellerKost.Models;
using LittleSellerKost.Printer;
using LittleSellerKost.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LettleSellerKost.Core;
using LettleSellerKost.BL.adv;

// Presenter НЕ должен обращаться напрямую к DbXXXXXX слою

/*
 * >>>
 * Составлять архитектурную схему взаимодейстувия
 *	По веткам операций. Прорисовывать связи, взаимоотношения. Рисовать графическое соответсвие коду для возможности проверки общей работы.
 *		Общие чертежи, чертежи более низкого уровня.
 *			Чертеж должен соответсвовать принципу факториала. Как то так...
 * 
 */

namespace LittleSellerKost.Presenters
{
	public class TodayMenuPresenterAdv
	{
		IViewTodayMenuEditor view = null;
		ShiftMenuBox shiftMenu;
		Category currentCategory { get; set; } = null;

		public TodayMenuPresenterAdv(IViewTodayMenuEditor v)
		{
			view = v;
			reloadTypeProducts(currentCategory);
			view.SetCategories(DbCategory.FindAll());
			view.SetCurrentCategory("ВСЕ");

			view.WebLoadShiftMenu += View_WebLoadShiftMenu;
			view.AddShiftMenuItem += View_AddShiftMenuItem;
			view.CategoryChanged += View_CategoryChanged;
			view.DeleteMenuItem += View_DeleteMenuItem;
			view.EditTypeProduct += View_EditTypeProduct;
			view.BalanceChange += View_BalanceChange;
			view.DiscountChange += View_DiscountChange;
			view.EditMenuItemWeights += View_EditMenuItemWeights;
			view.CreateTypeProduct += View_CreateTypeProduct;
			view.DeleteTypeProduct += View_DeleteTypeProduct;
			view.PrintMenu += View_PrintMenu;
			view.ExportCvs += View_ExportCvs;

			shiftMenu = new ShiftMenuBox(DateTime.Today);
			shiftMenu.MenuItemsChanged += ShiftMenu_MenuItemsChanged;
			shiftMenu.Load();

			view.ShowView();
		}

		private void ShiftMenu_MenuItemsChanged(IEnumerable<ShiftMenuItem> obj)
		{
			view.SetMenuProducts(obj);
		}

		private void View_ExportCvs()
		{
			var m = new ShiftMenuPrintModelAdv(shiftMenu.Menu);
			var csvdata = m.ExportCsv();
			StringsStore.Store(csvdata, "out.csv");
			view.ShowMessage("Экспорт завершен, см. файл out.csv");
		}

		private void View_PrintMenu()
		{
			MyPrinterSettings pSettings = new MyPrinterSettings(true);
			try
			{
				PrinterDevice.Print(new ShiftMenuPrintModelAdv(shiftMenu.Menu), pSettings.MenuPrinterName);
			}
			catch (Exception ex)
			{
				ShowError.Show(ex.Message);
			}
		}

		private void View_DeleteTypeProduct(TypeProduct obj)
		{
			if(view.UserAnswerYes($"Вы уверены, что хотите удалить {obj.Name} навсегда?"))
			{
				DbTypeProduct.DeleteTypeProduct(obj);
				reloadTypeProducts(currentCategory);
			}
		}

		private void View_CreateTypeProduct()
		{
			TypeProduct p = new TypeProduct();

			view.ViewEditProduct.SetCategories(DbCategory.FindAll());
			view.ViewEditProduct.SetCurrentCategory(currentCategory);
			view.ViewEditProduct.SetItem(p);

			if (view.ViewEditProduct.ShowView())
			{
				DbTypeProduct.Store(p);
				reloadTypeProducts(currentCategory);
			}
		}

		private void View_EditMenuItemWeights(IEditableProductItem obj)
		{
			view.ViewEditWeights.SetName(obj.Name);
			view.ViewEditWeights.SetWeightsJSON(obj.WPInfo);

			if (view.ViewEditWeights.ShowView())// или метод типа Succeed
			{
				obj.WPInfo = view.ViewEditWeights.ToJSON();
				shiftMenu.SaveChangingPosition(obj as ShiftMenuItem);
			}
		}

		private void View_DiscountChange(ShiftMenuItem obj)
		{
			decimal d = 0;
			if (view.ShowGetNumber("Скидка", out d))
			{
				obj.DiscountValue = Convert.ToInt32(d);
				shiftMenu.SaveChangingPosition(obj);
			}
		}

		private void View_BalanceChange(ShiftMenuItem obj)
		{
			decimal b = 0;
			if (view.ShowGetNumber("Исходное количество", out b))
			{
				obj.BaseCount = Convert.ToInt32(b);
				shiftMenu.SaveChangingPosition(obj);
			}
		}

		private void View_EditTypeProduct(TypeProduct obj)
		{
			TypeProduct tmp = obj.GetTemp();

			view.ViewEditProduct.SetItem(tmp);
			view.ViewEditProduct.SetCategories(DbCategory.FindAll());
			view.ViewEditProduct.SetCurrentCategory(DbCategory.FindOne(obj.CategoryId));
			if (view.ViewEditProduct.ShowView())
			{
				DbTypeProduct.Store(tmp);
				reloadTypeProducts(currentCategory);
			}
		}

		private void View_DeleteMenuItem(ShiftMenuItem obj)
		{
			if (obj == null) return;

			if(view.UserAnswerYes($"Подтвердите удаление {obj.Name}"))
				shiftMenu.RemovePosition(obj);
		}

		private void View_CategoryChanged(Category obj)
		{
			currentCategory = obj;
			view.SetCurrentCategory(currentCategory == null ? "ВСЕ" : currentCategory.Name.ToUpper());
			shiftMenu.SetCategory(obj);
			view.SetProductTypes(DbTypeProduct.ReadAll(currentCategory));
		}

		private void View_AddShiftMenuItem(TypeProduct obj)
		{
			shiftMenu.AppPosition(obj);
		}

		private void View_WebLoadShiftMenu()
		{
			//string j = JsonConvert.SerializeObject(shiftMenu.thisShiftMenu, Formatting.Indented);
			//view.ShowMessage(j);
		}

		void reloadTypeProducts(Category cat)
		{
			view.SetProductTypes(DbTypeProduct.ReadAll(cat));
		}
	}
}
