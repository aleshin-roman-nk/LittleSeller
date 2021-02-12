using Newtonsoft.Json;
using LittleSellerKost.BL;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.Models;
using LittleSellerKost.Views;
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
	public partial class FormTodayMenuEditor : Form, IViewTodayMenuEditor
	{
		Category[] categories = null;

		TypeProduct currentTypeProduct { get { return bsTypeProducts.Current as TypeProduct; } }
		ShiftMenuItem currentShiftMenuItem { get { return bsShiftMenuItems.Current as ShiftMenuItem; } }

		public IViewEditWeights ViewEditWeights { get; } = new FormEditWeights();
		public IViewEditProduct ViewEditProduct { get; } = new FormModifyProduct();

		public event Action<Category> CategoryChanged;
		public event Action PrintMenu;
		public event Action<TypeProduct> AddShiftMenuItem;
		public event Action<TypeProduct> EditTypeProduct;
		public event Action CreateTypeProduct;
		public event Action WebLoadShiftMenu;
		public event Action<ShiftMenuItem> DeleteMenuItem;
		public event Action<ShiftMenuItem> DiscountChange;
		public event Action<ShiftMenuItem> BalanceChange;
		public event Action<IEditableProductItem> EditMenuItemWeights;
		public event Action<TypeProduct> DeleteTypeProduct;
		public event Action ExportCvs;

		public FormTodayMenuEditor()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//KeyMapperCategory keyCategoryMapper = new KeyMapperCategory();

			var cat = categories.FirstOrDefault(x => (Keys)x.KeyCode == keyData);
			if (cat != null)
			{
				_eventCategoryChanged(cat);
				return true;
			}

			if(keyData == Keys.F7)
			{
				_eventCategoryChanged(null);
				return true;
			}

			//CallCmdPrintTodayMenu();
			if (keyData == (Keys.P | Keys.Control))
			{
				_eventPrintTodayMenu();
				return true;
			}

			if (keyData == Keys.Escape)
			{
				DialogResult = DialogResult.Cancel;
				return true;
			}

			if (dgvTodayMenuProducts.Focused)
			{
				if(keyData == Keys.Delete)
				{
					_eventDeleteMenuItem();
					return true;
				}

				if (keyData == Keys.D)// Edit weights
				{
					_eventEditMenuItemWeights();
					return true;
				}
			}

			if (dgvSourceProducts.Focused)
			{

				if(keyData == Keys.Space)
				{
					_eventAddItemToMenu();
					return true;
				}

				if (keyData == Keys.G)// Edit type product
				{
					_eventEditProduct();
					return true;
				}

				if(keyData == Keys.L)// Create new type product
				{
					_eventCreateTypeProduct();
					return true;
				}



				if (keyData == (Keys.Y))// Begin filtering
				{
					tbFindFirst.Select();
					tbFindFirst.SelectAll();
					return true;
				}

				//DeleteTypeProduct
				if(keyData == Keys.Delete)
				{
					_eventDeleteTypeProduct();
					return true;
				}
			}

			if (keyData == Keys.Right)// Today menu grid focused
			{
				dgvTodayMenuProducts.Select();
				return true;
			}

			if (keyData == Keys.Left)// Source products grid focused
			{
				dgvSourceProducts.Select();
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void btnCategory(object sender, EventArgs e)
		{
			string str = (sender as Button).Name;
			string btnid = str.Substring("btnCatId".Length, str.Length - "btnCatId".Length);

			int i = int.Parse(btnid);
			var cat = categories.FirstOrDefault(x=>x.Id == i);

			_eventCategoryChanged(cat);

			dgvSourceProducts.Select();
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			_eventCreateTypeProduct();
		}

		private void btnEditProduct_Click(object sender, EventArgs e)
		{
			_eventEditProduct();
		}

		private void _eventCategoryChanged(Category c)
		{
			CategoryChanged?.Invoke(c);
			dgvSourceProducts.Select();
		}

		private void _eventEditMenuItemWeights()
		{
			EditMenuItemWeights?.Invoke(currentShiftMenuItem);
			dgvSourceProducts.Select();
		}

		private void _eventCreateTypeProduct()
		{
			CreateTypeProduct?.Invoke();
			dgvSourceProducts.Select();
		}

		private void _eventEditProduct()
		{
			EditTypeProduct?.Invoke(currentTypeProduct);
			dgvSourceProducts.Select();
		}

		private void _eventPrintTodayMenu()
		{
			PrintMenu?.Invoke();
			dgvSourceProducts.Select();
		}

		private void _eventAddItemToMenu()
		{
			AddShiftMenuItem?.Invoke(currentTypeProduct);
			dgvSourceProducts.Select();
		}

		private void _eventDeleteTypeProduct()
		{
			DeleteTypeProduct?.Invoke(currentTypeProduct);
			dgvSourceProducts.Select();
		}

		private void _eventDeleteMenuItem()
		{
			DeleteMenuItem?.Invoke(currentShiftMenuItem);
		}

		private void _eventDiscountChange()
		{
			DiscountChange?.Invoke(currentShiftMenuItem);
		}

		private void _eventBalanceChange()
		{
			BalanceChange?.Invoke(currentShiftMenuItem);
		}

		private void btnPrintTodayMenu_Click(object sender, EventArgs e)
		{
			_eventPrintTodayMenu();
		}

		private void tbFindFirst_TextChanged(object sender, EventArgs e)
		{
			//todayMenuModel.CommandSelectDataGridViewProductByName((sender as TextBox).Text);
		}

		private void btnWebLoad_Click(object sender, EventArgs e)
		{
			WebLoadShiftMenu?.Invoke();
			dgvSourceProducts.Select();
		}

		public void SetProductTypes(TypeProduct[] items)
		{
			bsTypeProducts.DataSource = items;
			bsTypeProducts.ResetBindings(false);
		}

		public void SetMenuProducts(IEnumerable<ShiftMenuItem> items)
		{
			bsShiftMenuItems.DataSource = items;
			bsShiftMenuItems.ResetBindings(false);
		}

		public void SetCategories(Category[] items)
		{
			categories = items;
		}

		public void SetCurrentCategory(string item)
		{
			lblCurrentCategory.Text = item;
		}

		public void ShowView()
		{
			this.ShowDialog();
		}

		public void ShowMessage(string msg)
		{
			MessageBox.Show(msg);
		}

		public bool UserAnswerYes(string msg)
		{
			return DialogResult.Yes == MessageBox.Show(
				msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question
				);
		}

		public bool ShowGetNumber(string msg, out decimal v)
		{
			using (IViewGetNumber dlg = new FormGetNumber())
			{
				var res = dlg.ShowView(msg);
				v = dlg.Value;
				return res;
			}
		}

		private void btnBalance_Click(object sender, EventArgs e)
		{
			_eventBalanceChange();
		}

		private void btnDiscount_Click(object sender, EventArgs e)
		{
			_eventDiscountChange();
		}

		private void _eventExportCvs()
		{
			ExportCvs?.Invoke();
		}

		private void BtnExportCvs_Click(object sender, EventArgs e)
		{
			_eventExportCvs();
		}

		//public bool ShowEditWeights(IEditableProductItem t)
		//{
		//	using (IViewEditWeights dlg = new FormEditWeights())
		//	{
		//		dlg.SetName(t.Name);
		//		dlg.SetWeights(JsonConvert.DeserializeObject<Dictionary<int, int>>(t.WPInfo));
		//		dlg.ShowView();
		//	}

		//	return true;
		//}
	}
}
