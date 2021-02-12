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

	public interface IViewGetNumber: IDisposable
	{
		bool ShowView(string msg);
		decimal Value { get; set; }
	}

	public partial class FormGetNumber : Form, IViewGetNumber
	{
		public FormGetNumber()
		{
			InitializeComponent();
			tbCount.Select();
			tbCount.Select(0, tbCount.Value.ToString().Length);
		}

		public decimal Count { get { return tbCount.Value; } }

		public decimal Value { get => tbCount.Value; set => tbCount.Value = value; }

		public bool ShowView(string msg)
		{
			txtMsg.Text = msg;
			return DialogResult.OK == this.ShowDialog();
		}
	}
}
