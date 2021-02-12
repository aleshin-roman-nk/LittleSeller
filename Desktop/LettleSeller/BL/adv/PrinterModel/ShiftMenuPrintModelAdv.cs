using LittleSellerKost.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.Models;
using LittleSellerKost.Core.Printer;

namespace LittleSellerKost.BL.adv.PrinterModel
{
	public class ShiftMenuPrintModelAdv : IDrawableTo
	{
		ShiftMenu menu;

		/*
 
		{[
			{"ID":1,"Name":"СУПЫ"},
			{"ID":2,"Name":"ГОРЯЧЕЕ"},
			{"ID":3,"Name":"ГАРНИРЫ"},
			{"ID":4,"Name":"ВЫПЕЧКА"},
			{"ID":5,"Name":"НАПИТКИ"},
			{"ID":6,"Name":"САЛАТЫ"}
		]}
		 */

		public const int Sup = 1;
		public const int Gorach = 2;
		public const int Garn = 3;
		public const int Vipechka = 4;
		public const int Napitki = 5;
		public const int Salat = 6;

		List<ShiftMenuItem> listSup = null;
		List<ShiftMenuItem> listGarn = null;
		List<ShiftMenuItem> listSalat = null;
		List<ShiftMenuItem> listGorach = null;
		List<ShiftMenuItem> listNapitki = null;
		List<ShiftMenuItem> listVipechka = null;

		Dictionary<string, List<ShiftMenuItem>> keyValuesMenu = new Dictionary<string, List<ShiftMenuItem>>();

		public ShiftMenuPrintModelAdv(ShiftMenu shm)
		{
			menu = shm;

			var items = menu.ShiftMenuItems;

			listSup = items.Where(x => x.CategoryId == Sup).ToList();
			listGarn = items.Where(x => x.CategoryId == Garn).ToList();
			listSalat = items.Where(x => x.CategoryId == Salat).ToList();
			listGorach = items.Where(x => x.CategoryId == Gorach).ToList();
			listNapitki = items.Where(x => x.CategoryId == Napitki).ToList();
			listVipechka = items.Where(x => x.CategoryId == Vipechka).ToList();

			keyValuesMenu.Add("СУПЫ", listSup);
			keyValuesMenu.Add("ГАРНИРЫ", listGarn);
			keyValuesMenu.Add("ГОРЯЧЕЕ", listGorach);
			keyValuesMenu.Add("САЛАТЫ", listSalat);
			keyValuesMenu.Add("ВЫПЕЧКА", listVipechka);
			keyValuesMenu.Add("НАПИТКИ", listNapitki);
		}


		public void DrawTo(Graphics gr)
		{
			PrintConsole console = new PrintConsole(gr, 210 - 5 - 5);

			Font Title = new Font("Roboto Condensed", 14, FontStyle.Bold);
			Font Items = new Font("Roboto Condensed", 10, FontStyle.Regular);

			console.WriteLine("");
			console.WriteLine("");
			console.WriteLine($"     МЕНЮ ОТ {menu.Date.ToString("dd.MM.yyyy")}", Title);

			// Разработать класс создания модели таблицы. И класс, отрисовывающий по модели саму таблицу.

			// №, Наименование, Вес, Цена, Скидка
			GridModel gm = new GridModel(gr, new int[] { 10, 95, 30, 30, 25 }, 5, 15);

			gm.AddRow(Title, "#", "Наименование", "Вес, гр", "Цена, руб", "Скидка, %");

			int index = 1;

			foreach (var item in keyValuesMenu)
			{
				gm.AddRow(Title, "", item.Key, "", "", "");
				foreach (var product in item.Value)
				{
					string disc = product.DiscountValue > 0 ? (-product.DiscountValue).ToString() : "";
					gm.AddRow(Items, index.ToString(), product.Name, product.Weight, product.Price, disc);
					index++;
				}
			}

			gm.DrawGrid();
		}

		public string[] ExportCsv()
		{
			List<string> result = new List<string>();

			result.Add("#;Наименование;Вес, гр;Цена, руб");

			var categs = DbCategory.FindAll();

			foreach (var categ in categs)
			{
				result.Add(categ.Name);
				foreach (var product in DbTypeProduct.ReadAll(categ))
				{
					result.Add($"{product.Id};{product.Name};{product.Weight};{product.Price}");
				}
			}

			return result.ToArray();
		}
	}
}
