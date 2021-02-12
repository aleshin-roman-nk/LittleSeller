using LittleSellerKost.Forms;
using LittleSellerKost.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Models
{
	public class PrinterSettingsModel
	{
		public void SelectPrinters()
		{
			MyPrinterSettings printerSettings = new MyPrinterSettings();
			printerSettings.Load();

			using (FormChangeSettings form = new FormChangeSettings(printerSettings))
			{
				form.ShowDialog();
				printerSettings.Save();
			}
		}
	}
}
