using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Printer
{
	public static class PrinterDevice
	{
		static IDrawableTo _drawable;
		static string[] installedPrinters = null;

		public static void Print(IDrawableTo drawable, string printerName = null)
		{
			if (printerName != null)
				if (!printerExist(printerName)) throw new ArgumentException($"Принтер [{printerName}] не найден");

			using (PrintDocument device = new PrintDocument())
			{
				if(printerName != null)
					device.PrinterSettings.PrinterName = printerName;

				device.PrintPage += Device_PrintPage;
				_drawable = drawable;
				device.Print();
				_drawable = null;
			}
		}

		private static void Device_PrintPage(object sender, PrintPageEventArgs e)
		{
			_drawable.DrawTo(e.Graphics);
		}

		private static bool printerExist(string printerName)
		{
			if(installedPrinters == null)
				installedPrinters = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Cast<string>().ToArray();

			return installedPrinters.Any(x => x.Equals(printerName));
		}
	}
}
