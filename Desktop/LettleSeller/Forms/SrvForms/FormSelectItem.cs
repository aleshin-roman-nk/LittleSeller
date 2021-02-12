using System.Collections.Generic;
using System.Windows.Forms;

namespace LittleSellerKost.Forms
{
	public interface IItemSelector<T>
	{
		void SetCollection(IEnumerable<T> list, string displayMember);
		T Current { get; }
		bool ShowView();
	}

	public partial class FormSelectItem<T> : Form, IItemSelector<T>
		where T: class
	{
		BindingSource bs;

		public FormSelectItem()
		{
			InitializeComponent();
		}

		public void SetCollection(IEnumerable<T> list, string displayMember)
		{
			bs = new BindingSource();
			bs.DataSource = list;


			lbItems.DataSource = bs;
			lbItems.DisplayMember = displayMember;
		}

		public bool ShowView()
		{
			return this.ShowDialog() == DialogResult.OK;
		}

		public T Current { get { return bs.Current as T; } }
	}
}
