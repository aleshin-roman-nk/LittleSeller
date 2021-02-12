using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Core
{
	public static class UserAnswerYes
	{
		public static bool Show(string askMsg, string title)
		{
			return System.Windows.Forms.DialogResult.Yes ==
				System.Windows.Forms.MessageBox.Show(askMsg, title, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
		}
	}
}
