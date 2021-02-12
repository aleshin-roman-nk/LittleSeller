using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Entities
{
	public interface IEditableProductItem
	{
		string Name { get; set; }
		string WPInfo { get; set; }
		int CategoryId { get; set; }
		string Price { get; }
		string Weight { get; }
		void UpdateWP();
	}
}
