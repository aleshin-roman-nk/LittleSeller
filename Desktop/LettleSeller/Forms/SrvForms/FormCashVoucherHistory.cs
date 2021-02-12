using LettleSellerKost.BL.adv.Entities;
using LittleSellerKost.BL;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.Core;
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
	interface IViewPeceiptsHistory
	{
		bool ShowView();
		//event Action<ReservedReceipt> ReservPerformed;
		//void SetCollection(IEnumerable<ReservedReceipt> coll);
		event Action<Receipt> ReservPerformed;
		void SetCollection(IEnumerable<Receipt> coll);
	}

	public partial class FormCashVoucherHistory : Form, IViewPeceiptsHistory
	{

		BindingSource bsReceipts = new BindingSource();
		BindingSource bsReceiptsPositions = new BindingSource();

		//public event Action<ReservedReceipt> ReservPerformed;
		public event Action<Receipt> ReservPerformed;

		public FormCashVoucherHistory()
		{
			InitializeComponent();

			dgvReceipts.DataSource = bsReceipts;
			dgvReceiptsPositions.DataSource = bsReceiptsPositions;
			//btnDisreserve.DataBindings.Add("Text", bsReceipts, "ReceiptDateTime");
			btnDisreserve.DataBindings.Add("Text", bsReceipts, "DateMySQL");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public bool ShowView()
		{
			return this.ShowDialog() == DialogResult.OK;
		}

		//public void SetCollection(IEnumerable<ReservedReceipt> coll)
		public void SetCollection(IEnumerable<Receipt> coll)
		{
			bsReceipts.DataSource = coll;

			bsReceiptsPositions.DataSource = bsReceipts;
			//bsReceiptsPositions.DataMember = "Items";
			bsReceiptsPositions.DataMember = "ReceiptItems";

			bsReceipts.ResetBindings(false);
			bsReceiptsPositions.ResetBindings(false);
		}

		private void paintRows()
		{
			foreach (DataGridViewRow row in dgvReceipts.Rows)
			{
				var v = Convert.ToBoolean(row.Cells[2].Value);
				if(v) row.DefaultCellStyle.BackColor = Color.OrangeRed;
			}
		}

		private void BtnDisreserve_Click(object sender, EventArgs e)
		{
			//ReservPerformed?.Invoke(bsReceipts.Current as ReservedReceipt);
			ReservPerformed?.Invoke(bsReceipts.Current as Receipt);
		}

		private void DgvReceipts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var rowIndex = e.RowIndex;
			var row = dgvReceipts.Rows[rowIndex];

			var v = Convert.ToBoolean(row.Cells[2].Value);
			if (v) row.DefaultCellStyle.BackColor = Color.OrangeRed;
		}
	}
}
