using LittleSellerKost.BL.adv.Entities;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LittleSellerKost.Forms
{
	public interface IViewReceiptPositionBuildOptions
	{
		void SetCollection(IEnumerable<ReceiptPositionBuildOptions> list);
		ReceiptPositionBuildOptions Current { get; }
		bool ShowView();
	}

	public partial class FormReceiptPositionBuild : Form, IViewReceiptPositionBuildOptions
	{
		BindingSource bs;

		class ___help
		{
			public string Title { get; set; }
			public ReceiptPositionBuildOptions Data { get; set; }
		}

		public FormReceiptPositionBuild()
		{
			InitializeComponent();

			txtCount.Select(0, 10);
		}

		public void SetCollection(IEnumerable<ReceiptPositionBuildOptions> list)
		{
			var list_ = list.ToList().Select(x => new ___help { Title = $"{x.Weight.ToString()}гр / {x.Price:c} ({x.DPrice:c})", Data = x });

			bs = new BindingSource();
			bs.DataSource = list_;

			lbItems.DataSource = bs;
			lbItems.DisplayMember = "Title";
		}

		public bool ShowView()
		{
			return this.ShowDialog() == DialogResult.OK;
		}

		public ReceiptPositionBuildOptions Current
		{
			get
			{
				var res = (bs.Current as ___help).Data;
				res.Count = txtCount.Value;
				return res;
			}
		}

		private void TxtCount_ValueChanged(object sender, System.EventArgs e)
		{
			if (txtCount.Value == 1.5m) txtCount.Value = 1m;
		}

		private void TxtCount_Enter(object sender, System.EventArgs e)
		{
			setActivedCount();
		}

		private void setActivedCount()
		{
			label1.BackColor = Color.DarkTurquoise;
			label2.BackColor = Color.FromKnownColor(KnownColor.Control);
		}

		private void setActiveWeights()
		{
			label2.BackColor = Color.DarkTurquoise;
			label1.BackColor = Color.FromKnownColor(KnownColor.Control);
		}

		private void LbItems_Enter(object sender, System.EventArgs e)
		{
			setActiveWeights();
		}

		private void txtCount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				lbItems.Focus();
		}

		private void lbItems_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				DialogResult = DialogResult.OK;
		}
	}
}
