using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.DbLayer
{
	/*
	 * - Ищем последнюю смену в бд
	 * - Проверяем состояние
	 * - Если закрыта, создаем новую
	 * - Иначе работаем с последней
	 * 
	 * 
	 */

	// Просто получаем последнюю смену.
	// Логика такая, что мы просто берем последнюю смену. Предидущие уже закрыты и не подлежат каким либо изменениям
	// Мы можем их только посмотреть, загрузив коллекцию.
	// Для просмотра отчетов можем даже строить дерево Год.Месяц.Смена.Чек.Елемент
	public static class DbShift
	{

		/*
		 * Алгоритм
		 * 1. Пытаемся получить последнюю смену
		 * 2. Если последняя смена закрыта, и нет открытых и истекших смен, создаем новую смену
		 *		со статусом открыто.
		 * Контроллировать длительность смены 24 часа
		 */
		public static Shift GetLast()
		{
			using (DbAppData db = new DbAppData())
			{
				//var res = db.Shifts.Include("Receipt").Include("ReceiptItem").Where(x=>x.Date.Equals)
				return db.Shifts.OrderByDescending(x => x.Id).FirstOrDefault();
			}
		}

		/*
		 * Не знаю, какой смысл.
		 * Может полезно вызвать список смен за период (например месяц).
		 *	Затем пользователь выбирает нужную для просмотра (id смены) и мы можем показать ее.
		 * 
		 */

		public static Shift Create(DateTime date)
		{
			using (DbAppData db = new DbAppData())
			{
				var s = new Shift
				{
					Date = date,
					State = ShiftState.Opened,
					EndDate = null
				};

				db.Entry(s).State = EntityState.Added;
				db.SaveChanges();

				return s;
			}
		}

		public static IEnumerable<Receipt> FindReceipts(Shift shift)
		{
			using(DbAppData db = new DbAppData())
			{
				return (from s in db.Receipts.Include("ReceiptItems") where s.ShiftId == shift.Id select s).ToList();
			}
		}

		public static void CloseShift(Shift shift, DateTime endTime)
		{
			if (shift.State == ShiftState.Closed) return;

			using (DbAppData db = new DbAppData())
			{
				shift.State = ShiftState.Closed;
				shift.EndDate = endTime;

				db.Entry(shift).State = EntityState.Modified;
				db.SaveChanges();
			}
		}
	}
}
