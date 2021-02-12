using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Core
{
	public static class ShowError
	{
		public static void Show(string msg)
		{
			System.Windows.Forms.MessageBox.Show(msg, "ОШИБКА", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
	}
}
