using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv
{
	public static class DbCategory
	{
		public static Category[] FindAll()
		{
			using (DbAppData db = new DbAppData())
			{
				return db.Categories.ToArray();
			}
		}

		public static Category FindOne(int id)
		{
			using (DbAppData db = new DbAppData())
			{
				return db.Categories.FirstOrDefault(x=>x.Id == id);
			}
		}
	}
}
