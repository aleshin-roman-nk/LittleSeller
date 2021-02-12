using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Мысль к MVP:
 * ui-сущность наследуется от базового класса ui-сущности.
 * базовая сущность имеет свойство tag для каких нибудь нужд
 * Некий контроллер (фабрика) сущностей производит трансформацию db-сущности в ui-сущность при
 *		сохранении/загрузки данных из/в бд
 */

namespace LittleSellerKost.BL.adv
{
	public static class DbReceipt
	{
		public static Receipt Create(Shift s, DateTime dt)
		{
			var r = new Receipt
			{
				Date = dt,
				ShiftId = s.Id,
				Closed = false
			};

			using (DbAppData db = new DbAppData())
			{
				db.Entry(r).State = EntityState.Added;
				db.SaveChanges();
			}

			return r;
		}

		public static void Store(Receipt r)
		{
			using(DbAppData db = new DbAppData())
			{
				db.Entry(r).State = r.Id == 0 ? EntityState.Added : EntityState.Modified;

				foreach (var item in r.ReceiptItems)
					db.Entry(item).State = item.Id == 0 ? EntityState.Added : EntityState.Modified;

				db.SaveChanges();
			}
		}

		// Вобщем работу с чеками выносим в свой отдел
		public static void RemoveReceiptItem(ReceiptItem i)
		{
			using (DbAppData db = new DbAppData())
			{
				var item = db.ReceiptItems.FirstOrDefault(x=>x.Id == i.Id);
				if(item != null)
				{
					db.Entry(item).State = EntityState.Deleted;
					db.SaveChanges();
				}
			}
		}

		public static void Kill( Receipt r )
		{
			using (DbAppData db = new DbAppData())
			{
				db.Receipts.Attach(r);
				foreach (var item in r.ReceiptItems)
					db.ReceiptItems.Attach(item);

				db.ReceiptItems.RemoveRange(db.ReceiptItems);
				db.Receipts.Remove(r);

				db.SaveChanges();
			}
		}

		/*
		 * В этом отделе центр фабрик. Взятие из базы объектов и сохранение правильным способом.
		 *	+ преобразование объектов
		 *	+ фабрика необходимых объектов
		 *	
		 * class TheReceipt ответственность за чеки. Сокрытие работы с бд
		 */

		public static Receipt GetOne( int id )
		{
			using (DbAppData db = new DbAppData())
			{
				return (from s in db.Receipts.Include("ReceiptItems") select s).FirstOrDefault(x => x.Id == id);
			}
		}
	}
}
