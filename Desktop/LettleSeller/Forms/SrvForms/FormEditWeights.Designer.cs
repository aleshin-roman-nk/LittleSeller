namespace LittleSellerKost.Forms
{
	partial class FormEditWeights
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dgvWeightCollection = new System.Windows.Forms.DataGridView();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceWeightItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbWeight = new System.Windows.Forms.NumericUpDown();
			this.tbPrice = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbProductName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvWeightCollection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.priceWeightItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvWeightCollection
			// 
			this.dgvWeightCollection.AllowUserToAddRows = false;
			this.dgvWeightCollection.AllowUserToDeleteRows = false;
			this.dgvWeightCollection.AllowUserToResizeColumns = false;
			this.dgvWeightCollection.AllowUserToResizeRows = false;
			this.dgvWeightCollection.AutoGenerateColumns = false;
			this.dgvWeightCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWeightCollection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.dgvWeightCollection.DataSource = this.priceWeightItemBindingSource;
			this.dgvWeightCollection.Location = new System.Drawing.Point(12, 52);
			this.dgvWeightCollection.Name = "dgvWeightCollection";
			this.dgvWeightCollection.ReadOnly = true;
			this.dgvWeightCollection.RowHeadersVisible = false;
			this.dgvWeightCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWeightCollection.Size = new System.Drawing.Size(408, 150);
			this.dgvWeightCollection.TabIndex = 5;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "ВЕС";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			this.weightDataGridViewTextBoxColumn.Width = 200;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "ЦЕНА";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			this.priceDataGridViewTextBoxColumn.Width = 200;
			// 
			// priceWeightItemBindingSource
			// 
			this.priceWeightItemBindingSource.DataSource = typeof(LittleSellerKost.Forms.FormEditWeights.PriceWeightItem);
			// 
			// tbWeight
			// 
			this.tbWeight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbWeight.Location = new System.Drawing.Point(12, 233);
			this.tbWeight.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.tbWeight.Name = "tbWeight";
			this.tbWeight.Size = new System.Drawing.Size(120, 27);
			this.tbWeight.TabIndex = 0;
			// 
			// tbPrice
			// 
			this.tbPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPrice.Location = new System.Drawing.Point(220, 233);
			this.tbPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(120, 27);
			this.tbPrice.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 209);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Вес";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(216, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Цена";
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(213, 269);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(97, 32);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "Принять";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(316, 269);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(96, 32);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.Location = new System.Drawing.Point(12, 267);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(29, 32);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tbProductName
			// 
			this.tbProductName.AutoSize = true;
			this.tbProductName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbProductName.Location = new System.Drawing.Point(12, 26);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(21, 23);
			this.tbProductName.TabIndex = 9;
			this.tbProductName.Text = "0";
			// 
			// FormEditWeights
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(424, 313);
			this.Controls.Add(this.tbProductName);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbWeight);
			this.Controls.Add(this.dgvWeightCollection);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormEditWeights";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormAddMoreWeights";
			this.Load += new System.EventHandler(this.FormAddMoreWeights_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvWeightCollection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.priceWeightItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvWeightCollection;
		private System.Windows.Forms.BindingSource priceWeightItemBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.NumericUpDown tbWeight;
		private System.Windows.Forms.NumericUpDown tbPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label tbProductName;
	}
}