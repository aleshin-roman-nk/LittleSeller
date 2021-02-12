using LittleSellerKost.BL.adv;
using LittleSellerKost.Models;
using LittleSellerKost.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSellerKost
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ShowDebug.LogObject($"Starting at {DateTime.Now}");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var mainForm = new FormMain();

			MainPresenterAdv mainPresenter = new MainPresenterAdv(mainForm);

			Application.Run(mainForm);
		}
	}
}
