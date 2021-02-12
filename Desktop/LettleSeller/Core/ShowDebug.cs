using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Entity;

namespace LittleSellerKost
{
	public static class ShowDebug
	{
		static object locker = new object();

		public static void ShowObject(object o)
		{
			System.Windows.Forms.MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented));
		}

		public static void LogObject(object o)
		{
			lock (locker)
			{
				if (o == null) return;
				File.AppendAllText("error.log", o.ToString(), Encoding.UTF8);
				File.AppendAllText("error.log", Environment.NewLine + "==================================" + Environment.NewLine, Encoding.UTF8);
			}
		}

		public static void LogObjectJSON(object o)
		{
			File.AppendAllText("error.log", Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented), Encoding.UTF8);
			File.AppendAllText("error.log", Environment.NewLine + "==================================" + Environment.NewLine, Encoding.UTF8);
		}

		public static void Clear()
		{
			File.Delete("error.log");
		}

		public static void EFSetLog(DbContext db )
		{
			Clear();
			db.Database.Log = (s) => LogObject(s);
		}
	}
}
