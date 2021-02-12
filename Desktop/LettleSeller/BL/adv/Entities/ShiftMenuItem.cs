using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Entities
{
	// Конечно, лучше отделить ui сущность со всеми алгоритмами. Назовем частичка модели. При получении из бд проходит через фабрику ui
	//			при сохранении в бд также проходит через фабрику ui

	public class ShiftMenuItem: IEditableProductItem
	{
		public int Id { get; set; }
		public int UKey { get; set; }
		public int TypeId { get; set; }
		public int ShiftMenuId { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public int DiscountValue { get; set; }
		public decimal BaseCount { get; set; }
		public decimal SoldCnt { get; set; }

		public string WPInfo
		{
			get
			{
				return wpinfo;
			}
			set
			{
				wpinfo = value;
				UpdateWP();
			}
		}
		string wpinfo = "{}";

		#region UI
		[NotMapped]
		public decimal DeltaCnt => BaseCount - SoldCnt;
		[NotMapped]
		public int PosInGrid { get; set; } = 0;
		[NotMapped]
		public Dictionary<int, int> WP { get; set; }

		public void UpdateWP()
		{
			WP = JsonConvert.DeserializeObject<Dictionary<int, int>>(WPInfo);
		}

		[NotMapped]
		public string Weight
		{
			get
			{
				if (string.IsNullOrWhiteSpace(WPInfo)) return "-";

				string res = "";
				foreach (var item in WP)
				{
					res += item.Key.ToString() + '/';
				}

				res = res.TrimEnd('/');

				return res;
			}
		}

		[NotMapped]
		public string Price
		{
			get
			{
				if (string.IsNullOrWhiteSpace(WPInfo)) return "-";

				string res = "";
				foreach (var item in WP)
				{
					res += discPrice(item.Value, DiscountValue).ToString() + '/';
				}

				res = res.TrimEnd('/');

				return res;
			}
		}

		[NotMapped]
		public string PriceOrigin
		{
			get
			{
				if (string.IsNullOrWhiteSpace(WPInfo)) return "-";

				string res = "";
				foreach (var item in WP)
				{
					res += item.Value.ToString() + '/';
				}

				res = res.TrimEnd('/');

				return res;
			}
		}

		int discPrice(int value, int disc)
		{
			decimal discKoeff = 1m - disc / 100m;
			return Convert.ToInt32(Math.Truncate(value * discKoeff));
		}
		#endregion

		public static ShiftMenuItem FromTypeProduct(TypeProduct t)
		{
			return new ShiftMenuItem
			{
				CategoryId = t.CategoryId,
				Name = t.Name,
				WPInfo = t.WPInfo,
				TypeId = t.UKey
			};
		}

		public IEnumerable<ReceiptPositionBuildOptions> GetMyWP()
		{
			List<ReceiptPositionBuildOptions> res = new List<ReceiptPositionBuildOptions>();

			foreach (var item in WP.ToArray())
			{
				res.Add(new ReceiptPositionBuildOptions
				{
					Price = item.Value,
					DPrice = discPrice(item.Value, this.DiscountValue),
					Weight = item.Key,
					Count = 1
				});
			}

			return res;
		}
	}

	public class ReceiptPositionBuildOptions
	{
		public int Weight { get; set; }
		public int Price { get; set; }
		public int DPrice { get; set; }
		public decimal Count { get; set; }
	}

	//public class ShiftMenuItemUI: ShiftMenuItem
	//{
	//	public int PosInGrid { get; set; } = 0;
	//}

}
