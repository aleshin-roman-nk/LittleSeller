using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace LittleSellerKost.Printer
{
	// В принципе мне удобно, чтобы сущность сама себя сохраняла. И была самодостаточна.
	public class MyPrinterSettings
	{
		const string fileName = @"settings\printers.json";
		Data data;

		public MyPrinterSettings(bool autoLoad = false)
		{
			if (autoLoad) this.Load();
		}

		public string CashVoucherPrinterName { get { return data.CashVoucherPrinterName; } set { data.CashVoucherPrinterName = value; } }
		public string MenuPrinterName { get { return data.MenuPrinterName; } set { data.MenuPrinterName = value; } }

		public void Load()
		{
			if (!Directory.Exists("settings")) Directory.CreateDirectory("settings");

			if (File.Exists(fileName))
			{
				string j = File.ReadAllText(fileName, Encoding.UTF8);
				data = JsonConvert.DeserializeObject<Data>(j);
			}
			else
			{
				data = new Data();
				data.CashVoucherPrinterName = "no printer";
				data.MenuPrinterName = "no printer";
			}
		}

		public void Save()
		{
			string j = JsonConvert.SerializeObject(data);
			File.WriteAllText(fileName, j, Encoding.UTF8);
		}

		class Data
		{
			public string CashVoucherPrinterName { get; set; }
			public string MenuPrinterName { get; set; }
		}
	}
}
