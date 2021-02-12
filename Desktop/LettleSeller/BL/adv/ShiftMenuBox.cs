using LittleSellerKost;
using LittleSellerKost.BL.adv;
using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.BL.adv
{
	// При разработке класса хорошо бы руководствоваться и понимать цикл его жизни.
	//	Например в этом классе объект shiftMenu создается при создании класса.
	public class ShiftMenuBox
	{
		ShiftMenu shiftMenu = null;
		Category currentCategory;// Осень правильно, что состояние данных перенесь сюда, в частности текущая категория. Логика не должна рваться.
								//		Текущая категория и список позиций категории - логически связанные данные
		DateTime toDay;

		public event Action<IEnumerable<ShiftMenuItem>> MenuItemsChanged;

		public ShiftMenu Menu { get => shiftMenu; }

		public ShiftMenuBox(DateTime today)
		{
			toDay = new DateTime(today.Year, today.Month, today.Day); ;
			currentCategory = null;
		}

		public void Load()
		{
			shiftMenu = DbShiftMenu.LoadOrCreate(toDay);
			MenuItemsChanged?.Invoke(getItems(currentCategory));
		}

		public void Save()
		{
			throwIfUninit();
			DbShiftMenu.StoreMenu(shiftMenu);
		}

		public void SaveChangingPosition(ShiftMenuItem menuPos)
		{
			throwIfUninit();
			DbShiftMenu.StoreItem(menuPos);
			MenuItemsChanged?.Invoke(getItems(currentCategory));
		}

		public void AppPosition(TypeProduct t)
		{
			throwIfUninit();

			var pos = ShiftMenuItem.FromTypeProduct(t);
			pos.ShiftMenuId = shiftMenu.Id;

			DbShiftMenu.StoreItem(pos);
			shiftMenu.ShiftMenuItems.Add(pos);

			MenuItemsChanged?.Invoke(getItems(currentCategory));
		}

		public void RemovePosition(ShiftMenuItem pos)
		{
			throwIfUninit();

			var it = shiftMenu.ShiftMenuItems.FirstOrDefault(x => x.Id == pos.Id);
			if (it == default(ShiftMenuItem)) return;

			DbShiftMenu.RemovePosition(it);
			shiftMenu.ShiftMenuItems.Remove(it);

			MenuItemsChanged?.Invoke(getItems(currentCategory));
		}

		public void SetCategory(Category cat)
		{
			throwIfUninit();

			currentCategory = cat;
			MenuItemsChanged?.Invoke(getItems(currentCategory));
		}

		// Добавляем количество проданного
		public void IncreaseCounts(IEnumerable<ReceiptItem> list)
		{
			throwIfUninit();

			foreach (var receiptItem in list)
			{
				var menuPos = getPosition(receiptItem.MenuItemId.Value);
				if (menuPos != default(ShiftMenuItem))
					menuPos.SoldCnt += receiptItem.Count.Value;
			}

			DbShiftMenu.StoreMenu(shiftMenu);

			MenuItemsChanged?.Invoke(getItems(currentCategory));
		}


		IEnumerable<ShiftMenuItem> getItems(Category cat)
		{
			IEnumerable<ShiftMenuItem> result;

			if (cat == null)
				result = shiftMenu.ShiftMenuItems.OrderBy(x => x.Name).ToArray();
			else
			{
				result = (from s in shiftMenu.ShiftMenuItems
						  where s.CategoryId == cat.Id
						  select s).OrderBy(x => x.Name).ToArray();
			}

			int i = 1;
			foreach (var item in result)
			{
				item.PosInGrid = i;
				i++;
			}

			return result;
		}

		void throwIfUninit()
		{
			if (shiftMenu == null) throw new InvalidOperationException("ShiftMenuBox не инициализирован. Возможно не выполнен Load()");
		}

		ShiftMenuItem getPosition(int id)
		{
			throwIfUninit();
			return shiftMenu.ShiftMenuItems.FirstOrDefault(x => x.Id == id);
		}
	}
}
