
/*
 * Задачи:
 * 
 *  + Если в чеке несколько одинаковых элементов (type, discount) слить их в одно
 *  + Запретить просто так удалять пункты меню. По крайней мере, если на них ссылаются элементы чеков
 * 
 * 
 */



using System;

namespace LittleSellerKost.BL.adv.Entities
{
	// элемент чека
	public class ReceiptItem
	{
		public int Id { get; set; }
		public int TypeId { get; set; }
		public int? ReceiptId { get; set; }
		public string Name { get; set; }
		public int? CategoryId { get; set; }
		public int? Price { get; set; }
		public decimal? Count { get; set; }
		public int? DiscPrice { get; set; }
		public int? Weight { get; set; }
		public int? MenuItemId { get; set; }

		public static ReceiptItem Create(Receipt receipt, ShiftMenuItem src, ReceiptPositionBuildOptions pos_options)
		{
			return new ReceiptItem
			{
				CategoryId = src.CategoryId,
				Count = pos_options.Count,
				Name = src.Name,
				TypeId = src.TypeId,
				ReceiptId = receipt.Id,
				Weight = pos_options.Weight,
				Price = pos_options.Price,
				DiscPrice = pos_options.DPrice,
				MenuItemId = src.Id
			};
		}
	}
}
