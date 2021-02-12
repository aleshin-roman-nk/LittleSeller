using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Core
{
	public static class MySettings
	{
		const string fileName = "settings.cfg";
		static Dictionary<string, string> _settings;

		public static void Load()
		{
			if (!File.Exists(fileName)) return;
			string j = File.ReadAllText(fileName, Encoding.UTF8);
			_settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(j);
		}

		public static void Save()
		{
			string j = JsonConvert.SerializeObject(_settings);
			File.WriteAllText(fileName, j,Encoding.UTF8);
		}

		public static void LoadDefault()
		{

		}

		public static string WebServerName { get { return _settings["web_server"]; } set { _settings["web_server"] = value; } }
		public static string MunePrinterName { get { return _settings["menu_printer_name"]; } set { _settings["menu_printer_name"] = value; } }

	}
}
