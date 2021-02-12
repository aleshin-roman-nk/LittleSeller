using LittleSellerKost.BL.adv;
using LittleSellerKost.Forms;
using SplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSellerKost.Models
{
	public static class PreLoader
	{
		static SplashForm frm = new SplashForm();

		public static void go()
		{
			frm.AppName = "КАССА";
			frm.Shown += Frm_Shown;
			frm.ShowDialog();
		}

		private static void Frm_Shown(object sender, EventArgs e)
		{
			using (BackgroundWorker backgroundWorker = new BackgroundWorker())
			{
				backgroundWorker.DoWork += BackgroundWorker_DoWork;
				backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
				backgroundWorker.RunWorkerAsync();
			};
		}

		private static void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			frm.Close();
		}

		private static void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			__go();
		}

		static void __go()
		{
			using (DbAppData db = new DbAppData())
			{
				db.Categories.ToArray();
			}
		}
	}
}

