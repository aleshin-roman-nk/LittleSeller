using Newtonsoft.Json;
using LittleSellerKost.BL;
using LittleSellerKost.BL.adv.Entities;
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
	public interface IViewEditProduct: IDisposable
	{
		void SetCategories(Category[] items);
		void SetCurrentCategory(Category cat);
		void SetItem(IEditableProductItem i);

		bool ShowView();
	}

	public partial class FormModifyProduct : Form, IViewEditProduct
	{
		BindingSource bsCategories = new BindingSource();
		IEditableProductItem resultItem;

		Category currentCategory { get { return bsCategories.Current as Category; } }

		public FormModifyProduct()
		{
			InitializeComponent();
		}
	
		private void btnOk_Click(object sender, EventArgs e)
		{
			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		private void tbProductName_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void tbProductName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '"') e.KeyChar = '\'';
			if (e.KeyChar == '\'') e.KeyChar = '*';
		}

		public void SetCategories(Category[] items)
		{
			bsCategories.DataSource = items;
			cbProdCategs.DataSource = bsCategories;
			cbProdCategs.DisplayMember = "Name";
		}

		public void SetCurrentCategory(Category cat)
		{
			var list = bsCategories.DataSource as Category[];
			if(cat != null)
			{
				Category c = list.FirstOrDefault(x=>x.Id == cat.Id);
				bsCategories.Position = bsCategories.IndexOf(c) > -1 ? bsCategories.IndexOf(c) : 0;
			}
		}

		public void SetItem(IEditableProductItem i)
		{
			resultItem = i;
			tbProductName.Text = resultItem.Name;
		
			setWPInfo();
		}

		public bool ShowView()
		{
			var res = DialogResult.OK == ShowDialog();

			resultItem.Name = tbProductName.Text;
			resultItem.CategoryId = currentCategory.Id;

			return res;
		}

		private void btnEditWP_Click(object sender, EventArgs e)
		{
			using (IViewEditWeights dlg = new FormEditWeights())
			{
				dlg.SetName(resultItem.Name);
				dlg.SetWeightsJSON(resultItem.WPInfo);
				if (dlg.ShowView())
				{
					resultItem.WPInfo = dlg.ToJSON();
					setWPInfo();
				}
			}
		}

		void setWPInfo()
		{
			txtWPInfo.Text =  $"Вес :{resultItem.Weight} Цена :{resultItem.Price}";
		}
	}
}
