using LittleSellerKost.Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSellerKost.Forms
{
	public partial class FormChangeSettings : Form
	{
		MyPrinterSettings printerManager;
		BindingSource bs = new BindingSource();

		public FormChangeSettings(MyPrinterSettings pMan)
		{
			InitializeComponent();

			printerManager = pMan;
			bs.DataSource = printerManager;

			tbPrinterCashValue.DataBindings.Add("Text", bs, "CashVoucherPrinterName");
			tbPrinterMenu.DataBindings.Add("Text", bs, "MenuPrinterName");
		}

		private void tbPrinterCashValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var printers = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Cast<string>().ToArray();

			using (FormSelectItem<string> form = new FormSelectItem<string>())
			{
				form.SetCollection(printers, null);
				if (DialogResult.OK == form.ShowDialog())
				{
					tbPrinterCashValue.Text = form.Current;
				}
			}
		}

		private void tbPrinterMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var printers = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
			using (FormSelectItem<string> form = new FormSelectItem<string>())
			{
				form.SetCollection(printers, null);
				if (DialogResult.OK == form.ShowDialog())
				{
					tbPrinterMenu.Text = form.Current;
				}
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{

		}
	}
}
