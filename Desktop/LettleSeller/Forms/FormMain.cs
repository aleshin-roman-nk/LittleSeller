using LettleSellerKost;
using LittleSellerKost.BL;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.Core;
using LittleSellerKost.Forms;
using LittleSellerKost.Models;
using LittleSellerKost.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LittleSellerKost
{
	public partial class FormMain : Form, IViewMain
	{
		Category[] categories = null;

		ShiftMenuItem currentMenuItem { get { return bsShiftMenuItems.Current as ShiftMenuItem; } }
		ReceiptItem currentReceiptItem { get { return bsReceiptItems.Current as ReceiptItem; } }

		public event Action<Category> CategoryChanged;
		public event Action WebLoadShiftMenu;
		public event Action<ShiftMenuItem> DiscountChange;
		public event Action<ShiftMenuItem> BalanceChange;
		public event Action<IEditableProductItem> EditMenuItemWeights;
		public event Action<ShiftMenuItem> AddReceiptItem;
		public event Action EditShiftMenu;
		public event Action MainViewReady;
		public event Action KeyboardIdle;
		public event Action<ReceiptItem> DeleteReceiptItem;
		public event Action DoSell;
		public event Action CloseShift;
		public event Action OpenShift;
		public event Action<ShutdownArgs> ShutdownProgram;
		public event Action ShowReceiptsHistoryView;

		public FormMain()
		{
			InitializeComponent();

			dgvShiftMenuItems.Select();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (dgvShiftMenuItems.Focused)
			{
				// Весовки пункта меню
				if(keyData == Keys.D)
				{
					_eventEditMenuItemWeights();
					return true;
				}
			}

			if (dgvThisReceipt.Focused)
			{
				// Удалить пункт чека
				if (keyData == Keys.Delete)
				{
					_eventDeleteReceiptItem();
					return true;
				}
			}

			// Запустить оформление продажи
			if(keyData == Keys.Enter)
			{
				_eventDoSell();
				return true;
			}

			// Переход в окно редактирования меню
			if (keyData == Keys.V)
			{
				_eventEditShiftMenu();
				return true;
			}

			// Добавить пункт в чек
			if (keyData == Keys.Space)
			{
				_eventAddReceiptItem();
				return true;
			}

			// Вызов окна просмотра истории чеков
			if (keyData == Keys.X)
			{
				_eventShowReceiptsHistoryView();
				return true;
			}


			// Вызов окна просмотра истории чеков
			if (keyData == Keys.Left)
			{
				dgvShiftMenuItems.Select();
				return true;
			}

			// Вызов окна просмотра истории чеков
			if (keyData == Keys.Right)
			{
				dgvThisReceipt.Select();
				return true;
			}

			// Обработка нажатий F1-F7
			var cat = categories.FirstOrDefault(x => (Keys)x.KeyCode == keyData);
			if (cat != null)
			{
				_eventCategoryChanged(cat);
				return true;
			}

			if (keyData == Keys.F7)
			{
				_eventCategoryChanged(null);
				return true;
			}

			// Обработка нажатий 1-9
			int No = new KeyConverter().ToDigit1_9(keyData);
			if (No != -1)
			{
				jumpToMenuItem(No);
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		void jumpToMenuItem( int n )
		{
			var items = bsShiftMenuItems.DataSource as ShiftMenuItem[];
			var item = items.FirstOrDefault(x=>x.PosInGrid == n);
			if(item != null)
				bsShiftMenuItems.Position = bsShiftMenuItems.IndexOf(item);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateKeyboardLang();
			InputLanguageChanged += FormCashbox_InputLanguageChanged;
		}

		private void FormCashbox_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
		{
			lblCurrentLang.Text = e.InputLanguage.LayoutName;
		}

		private void UpdateKeyboardLang()
		{
			var l = InputLanguage.FromCulture(CultureInfo.GetCultureInfo("ru-RU"));

			InputLanguage.CurrentInputLanguage = l;

			lblCurrentLang.Text = InputLanguage.CurrentInputLanguage.LayoutName;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEditProduct_Click(object sender, EventArgs e)
		{
			dgvShiftMenuItems.Select();
		}

		private void btnCategory(object sender, EventArgs e)
		{
			string str = (sender as Button).Name;
			string btnid = str.Substring("btnCatId".Length, str.Length - "btnCatId".Length);

			int i = int.Parse(btnid);
			var cat = categories.FirstOrDefault(x => x.Id == i);

			_eventCategoryChanged(cat);

			dgvShiftMenuItems.Select();
		}

		private void btnTodayMenu_Click(object sender, EventArgs e)
		{
			_eventEditShiftMenu();
			dgvShiftMenuItems.Select();
		}

		private void btnWeights_Click(object sender, EventArgs e)
		{
			_eventEditMenuItemWeights();
			dgvShiftMenuItems.Select();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			(new PrinterSettingsModel()).SelectPrinters();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToString("HH:mm:ss\ndd.MM.yyyy");
		}

		private void FormCashbox_Shown(object sender, EventArgs e)
		{
			MainViewReady?.Invoke();
		}

		#region set data
		public void SetThisReceiptItems(ReceiptItem[] items)
		{
			bsReceiptItems.DataSource = items;
			bsReceiptItems.ResetBindings(false);
		}

		public void SetShiftMenuItems(IEnumerable<ShiftMenuItem> items)
		{
			bsShiftMenuItems.DataSource = items;
			bsShiftMenuItems.ResetBindings(false);
		}

		public void SetCategories(Category[] items)
		{
			categories = items;
		}

		public void SetReceiptCount(int v)
		{
			lbSoldsCount.Text = v.ToString();
		}

		public void SetAllReceiptsAmount(decimal v)
		{
			lbSoldsAmount.Text = v.ToString("c");
		}

		public void SetThisReceiptAmount(decimal v)
		{
			lblCurrentCashAmount.Text = v.ToString("c");
		}

		public void SetCurrentCategory(string item)
		{
			lblCurrentCategory.Text = item;
		}
		#endregion

		#region _event

		private void _eventShowReceiptsHistoryView()
		{
			ShowReceiptsHistoryView?.Invoke();
		}

		private void _eventCategoryChanged(Category cat)
		{
			CategoryChanged?.Invoke(cat);
			dgvShiftMenuItems.Select();
		}

		private void _eventAddReceiptItem()
		{
			AddReceiptItem?.Invoke(currentMenuItem);
		}

		private void _eventEditShiftMenu()
		{
			EditShiftMenu?.Invoke();
		}

		private void _eventDeleteReceiptItem()
		{
			DeleteReceiptItem?.Invoke(currentReceiptItem);
		}

		private void _eventEditMenuItemWeights()
		{
			EditMenuItemWeights?.Invoke(currentMenuItem);
		}

		private void _eventDoSell()
		{
			DoSell?.Invoke();
		}
		#endregion

		public void ShowView()
		{
		}
		public void ShowMessage(string msg)
		{
			MessageBox.Show(msg);
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

		private void btnCloseShift_Click(object sender, EventArgs e)
		{
			CloseShift?.Invoke();
		}

		private void BtnShift_Click(object sender, EventArgs e)
		{
			OpenShift?.Invoke();
		}

		public void SetShiftState(ShiftState state)
		{
			Color c = Color.Empty;
			string txt = "";

			switch (state)
			{
				case ShiftState.Closed:
					c = Color.Red;
					txt = "ЗАКРЫТА";
					break;
				case ShiftState.Expired:
					c = Color.DarkOrange;
					txt = "ИСТЕКЛА";
					break;
				case ShiftState.Opened:
					c = Color.ForestGreen;
					txt = "ОТКРЫТА";
					break;
				case ShiftState.Undefined:
					c = Color.LightGray;
					txt = "НЕТ СВЯЗИ С ККТ";
					break;
			}

			lblShiftState.BackColor = c;
			lblShiftState.Text = txt;
		}

		public bool UserAnswerYes(string question)
		{
			return DialogResult.Yes == MessageBox.Show(
				question, "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			ShutdownArgs args = new ShutdownArgs
			{
				Close = true
			};

			ShutdownProgram?.Invoke(args);

			if (!args.Close)
				e.Cancel = true;
		}

		public void SetKktShiftState(ShiftState state)
		{
			Color c = Color.Empty;

			switch (state)
			{
				case ShiftState.Closed:
					c = Color.Red;
					break;
				case ShiftState.Expired:
					c = Color.DarkOrange;
					break;
				case ShiftState.Opened:
					c = Color.ForestGreen;
					break;
			}

			label100.BackColor = c;
		}

		public void SetWebBufferState(int state)
		{
			this.changeCtrlAsync(()=> {
				Color c;
				string txt = null;

				if(state == 0)
				{
					c = Color.LightSeaGreen;
					txt = "Ok";
				}
				else
				{
					c = Color.Red;
					txt = state.ToString();
				}

				lblTransCount.BackColor = c;
				lblTransCount.Text = txt;
			});
		}
	}
}
