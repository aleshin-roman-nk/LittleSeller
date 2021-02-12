using Newtonsoft.Json;
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

	public interface IViewEditWeights: IDisposable
	{
		void SetWeights(Dictionary<int, int> obj);
		void SetWeightsJSON(string jweights);
		void SetName(string name);
		Dictionary<int, int> GetWeights();
		string ToJSON();

		bool ShowView();
	}

	/// <summary>
	/// 
	/// </summary>
	public partial class FormEditWeights : Form, IViewEditWeights
	{
		List<PriceWeightItem> wpCollection = new List<PriceWeightItem>();
		PriceWeightItem currentItem { get { return priceWeightItemBindingSource.Current as PriceWeightItem; } }

		public FormEditWeights()
		{
			InitializeComponent();
		}

		class PriceWeightItem
		{
			public int Weight { get; set; }
			public int Price { get; set; }
		}

		//private List<PriceWeightItem> GetItemsFromDictionary(Dictionary<int, int> dict) 
		//{
		//	List<PriceWeightItem> res = new List<PriceWeightItem>();

		//	foreach (var item in dict)
		//	{
		//		res.Add(new PriceWeightItem { Weight = item.Key, Price = item.Value });
		//	}

		//	return res;
		//}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddItem();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			// Пробуем добавить весовку перед закрытием окна
			AddItem(false);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// Усовершенствовать обработку горячих команд.
			// Проверять по базе, используется ли данная комбинация
			// Проверять поразрядной операцией, чтобы исключить ложное срабатывание одиночных клавиш
			if (keyData == Keys.Tab)
			{
				if (tbWeight.Focused)
				{
					tbPrice.Select();
					tbPrice.Select(0, tbWeight.Value.ToString().Length);
				}
				else if (tbPrice.Focused)
				{
					AddItem();
					tbWeight.Select();
					ClearTextBoxes();
				}

				return true;
			}

			if (dgvWeightCollection.Focused)
			{
				if(keyData == Keys.Delete)
				{
					if(UserAnswerYes.Show("Подтвердите удаление", "Удаление"))
					{
						wpCollection.Remove(currentItem);
						reloadItems();
					}
					return true;
				}
			}

			if(keyData == Keys.Enter)
			{
				AddItem(false);
				this.DialogResult = DialogResult.OK;
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		void AddItem(bool showWarning = true)
		{
			if (!(tbPrice.Value > 0 && tbWeight.Value > 0)) return;

			if (wpCollection.Any(x => x.Weight == Convert.ToInt32(tbWeight.Value)))
			{
				if(showWarning) MessageBox.Show($"Вес {tbWeight.Value} уже добавлен");
				return;
			}

			wpCollection.Add(new PriceWeightItem { Weight = Convert.ToInt32(tbWeight.Value), Price = Convert.ToInt32(tbPrice.Value) });
			priceWeightItemBindingSource.ResetBindings(false);
		}

		void ClearTextBoxes()
		{
			tbWeight.Value = 0;
			tbPrice.Value = 0;
			tbWeight.Select(0, tbWeight.Value.ToString().Length);
		}

		private void FormAddMoreWeights_Load(object sender, EventArgs e)
		{
			tbWeight.Select(0, tbWeight.Value.ToString().Length);
		}

		void reloadItems()
		{
			priceWeightItemBindingSource.DataSource = wpCollection;
			priceWeightItemBindingSource.ResetBindings(false);
		}

		public void SetWeights(Dictionary<int, int> obj)
		{
			wpCollection.Clear();
			ClearTextBoxes();

			foreach (var item in obj)
				wpCollection.Add(new PriceWeightItem
				{
					Weight = item.Key,
					Price = item.Value
				});

			reloadItems();
		}

		public void SetName(string name)
		{
			tbProductName.Text = name;
		}

		public Dictionary<int, int> GetWeights()
		{
			wpCollection = wpCollection.OrderBy(x => x.Weight).ToList();

			var res = new Dictionary<int, int>();

			foreach (var item in wpCollection)
				res.Add(item.Weight, item.Price);

			return res;
		}

		public bool ShowView()
		{
			return DialogResult.OK == this.ShowDialog();
		}

		public string ToJSON()
		{
			return JsonConvert.SerializeObject(GetWeights());
		}

		public void SetWeightsJSON(string jweights)
		{
			SetWeights(JsonConvert.DeserializeObject<Dictionary<int, int>>(jweights));
		}
	}
}
