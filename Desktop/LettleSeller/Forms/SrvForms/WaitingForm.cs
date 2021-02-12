using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettleSellerKost.Forms.SrvForms
{
	public partial class WaitingForm : Form
	{
		public WaitingForm()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value < 100) progressBar1.Value++;
		}
	}

	internal static class ExCtrls
	{
		public static void changeCtrlAsync(this Control c, Action a)
		{
			if (c.InvokeRequired)
				c.Invoke(a);
			else
				a();
		}

		public async static Task<DialogResult> ShowDialogAsync(this Form f)
		{
			await Task.Yield();
			if (f.IsDisposed)
				return DialogResult.OK;
			return f.ShowDialog();
		}
	}
}
