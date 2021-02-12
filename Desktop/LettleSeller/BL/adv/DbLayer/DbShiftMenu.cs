using Newtonsoft.Json;
using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LittleSellerKost.BL.adv
{
	// хорошо использовать событие изменения состояния объекта и это событие в объекте слоя логики. Событие срабатывает при операциях изменения состояния объекта в БД
	//	к примеру в методе AddMenuItem, DeleteMenuItem, изменения текущей категории. Логика: в одном месте изменил что то, обратный вызов заботится об обновлении экрана.
	// Просто доступ к БД

	public class DbShiftMenu
	{
		static ShiftMenu loadMenu(DateTime date)
		{
			// >>>
			// В смене нужно именно точное время а не только дату, так как нужно идентифицировать смену точно...
			//		и желательно реализовать привязку меню к смене. Одна смена - к ней одно меню.
			//			Если будет желание можно просто из бд достать список чего надо.
			//			Нужно отработать механизм "отщелкивания" следующего активного объекта.

			// >>> Подход к разработке.
			//				Стараться максимально изолированные блоки друг от друга и оформлять в отдельных папках для ясности.
			//					Разрабатывать эти блоки с тестированием и запечатыванием отдельно друг от друга.
			DateTime d = new DateTime(date.Year, date.Month, date.Day);

			using (DbAppData db = new DbAppData())
			{
				return db.ShiftMenus
									.Include("ShiftMenuItems")
									.FirstOrDefault(x => x.Date.Equals(d));
			}
		}

		static bool shiftExists(DateTime today)
		{
			using (DbAppData db = new DbAppData())
			{
				return db.ShiftMenus.Any(x=>x.Date.Equals(today));
			}
		}

		public static ShiftMenu LoadOrCreate(DateTime today)
		{
			if (shiftExists(today)) return loadMenu(today);

			var res = new ShiftMenu
			{
				Date = new DateTime(today.Year, today.Month, today.Day)
			};

			using (DbAppData db = new DbAppData())
			{
				db.Entry(res).State = EntityState.Added;
				db.SaveChanges();
			}

			return res;
		}

		public static void RemovePosition(ShiftMenuItem i)
		{
			using (DbAppData db = new DbAppData())
			{
				// Продали и забыли... не будем проверять ссылку чеков на элемент меню
				//if( db.ReceiptItems.Any(x => x.MenuItemId == i.Id))
				//{
					db.Entry(i).State = EntityState.Deleted;
					db.SaveChanges();
				//}
			}
		}

		public static void StoreItem(ShiftMenuItem i)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(i).State = i.Id == 0 ? EntityState.Added : EntityState.Modified;
				db.SaveChanges();
			}
		}

		public static void StoreMenu(ShiftMenu menu)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(menu).State = menu.Id == 0 ? EntityState.Added : EntityState.Modified;

				foreach (var item in menu.ShiftMenuItems)
					db.Entry(item).State = item.Id == 0 ? EntityState.Added : EntityState.Modified;

				db.SaveChanges();
			}
		}
	}
}
