using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Entities
{
	public class ShiftMenu
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public List<ShiftMenuItem> ShiftMenuItems { get; set; } = new List<ShiftMenuItem>();
	}
}
