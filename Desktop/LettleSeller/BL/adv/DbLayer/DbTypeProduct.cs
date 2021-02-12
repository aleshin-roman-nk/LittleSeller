using Newtonsoft.Json;
using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv
{
	public static class DbTypeProduct
	{
		public static void Store(TypeProduct p)
		{
			using (DbAppData db = new DbAppData())
			{
				// Проверить на существующий UKey
				//p.WPInfo = JsonConvert.SerializeObject(p.WP);// зачем?
				db.Entry(p).State = p.Id == 0 ? EntityState.Added : EntityState.Modified;
				db.SaveChanges();
			}
		}

		public static TypeProduct[] ReadAll(Category cat)
		{
			using (DbAppData db = new DbAppData())
			{
				var items = db.TypeProducts.OrderBy(x=>x.Name).ToArray();

				if (cat != null)
					items = items.Where(x => x.CategoryId == cat.Id).OrderBy(x=>x.Name).ToArray();

				//foreach (var item in items)
				//	//item.WP = JsonConvert.DeserializeObject<Dictionary<int, int>>(item.WPInfo);
				//	item.UpdateWP();

				return items;
			}
		}

		public static void DeleteTypeProduct(TypeProduct p)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(p).State = EntityState.Deleted;
				db.SaveChanges();
			}
		}

		//public static void StoreAll(Product[] p)
		//{
		//	using (DbAppData db = new DbAppData())
		//	{
		//		foreach (var item in p)
		//		{
		//			// Проверить на существующий UKey
		//			var tp = TypeProduct.FromProduct(item);
		//			db.Entry(tp).State = tp.Id == 0 ? EntityState.Added : EntityState.Modified;
		//		}
		//		db.SaveChanges();
		//	}
		//}
	}
}
