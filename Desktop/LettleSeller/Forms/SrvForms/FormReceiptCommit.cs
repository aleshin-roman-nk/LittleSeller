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
	public interface IViewReceiptCommit
	{
		void SetAmount(decimal amnt);
		ViewResultReceiptCommit ShowView();
	}

	public partial class FormReceiptCommit : Form, IViewReceiptCommit
	{
		decimal sourceAmount;

		public FormReceiptCommit()
		{
			InitializeComponent();

			tbCash.TextChanged += TbCash_TextChanged;
		}

		public void SetAmount(decimal amnt)
		{
			lblCashVoucherSource.Text = amnt.ToString();
			sourceAmount = decimal.Parse(lblCashVoucherSource.Text);
			tbCash.Value = sourceAmount;
			tbCash.Select();
			tbCash.Select(0, tbCash.Value.ToString().Length);
		}

		public ViewResultReceiptCommit ShowView()
		{
			var res = new ViewResultReceiptCommit();
			var dres = this.ShowDialog() == DialogResult.OK;
			res.IsReserved = chbIsReserved.Checked;
			res.Ok = dres;
			return res;
		}

		private void TbCash_TextChanged(object sender, EventArgs e)
		{
			lblCashVoucherChange.Text = (tbCash.Value - sourceAmount).ToString();
		}
	}

	public class ViewResultReceiptCommit
	{
		public bool IsReserved { get; set; } = false;
		public bool Ok { get; set; }
	}
}
