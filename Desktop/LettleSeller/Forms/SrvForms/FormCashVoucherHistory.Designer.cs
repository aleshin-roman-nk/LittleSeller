namespace LittleSellerKost.Forms
{
	partial class FormCashVoucherHistory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvReceipts = new System.Windows.Forms.DataGridView();
			this.dgvReceiptsPositions = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDisreserve = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.receiptItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dateMySQLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.reservedReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvReceiptsPositions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.receiptItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservedReceiptBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvReceipts
			// 
			this.dgvReceipts.AllowUserToAddRows = false;
			this.dgvReceipts.AllowUserToDeleteRows = false;
			this.dgvReceipts.AllowUserToResizeRows = false;
			this.dgvReceipts.AutoGenerateColumns = false;
			this.dgvReceipts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateMySQLDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.reservedDataGridViewCheckBoxColumn});
			this.dgvReceipts.DataSource = this.reservedReceiptBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReceipts.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvReceipts.Location = new System.Drawing.Point(12, 49);
			this.dgvReceipts.MultiSelect = false;
			this.dgvReceipts.Name = "dgvReceipts";
			this.dgvReceipts.ReadOnly = true;
			this.dgvReceipts.RowHeadersVisible = false;
			this.dgvReceipts.RowTemplate.Height = 30;
			this.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReceipts.Size = new System.Drawing.Size(326, 317);
			this.dgvReceipts.TabIndex = 0;
			this.dgvReceipts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvReceipts_CellFormatting);
			// 
			// dgvReceiptsPositions
			// 
			this.dgvReceiptsPositions.AllowUserToAddRows = false;
			this.dgvReceiptsPositions.AllowUserToDeleteRows = false;
			this.dgvReceiptsPositions.AutoGenerateColumns = false;
			this.dgvReceiptsPositions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReceiptsPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvReceiptsPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvReceiptsPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.weightDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.discPriceDataGridViewTextBoxColumn});
			this.dgvReceiptsPositions.DataSource = this.receiptItemBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReceiptsPositions.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvReceiptsPositions.Location = new System.Drawing.Point(344, 49);
			this.dgvReceiptsPositions.MultiSelect = false;
			this.dgvReceiptsPositions.Name = "dgvReceiptsPositions";
			this.dgvReceiptsPositions.ReadOnly = true;
			this.dgvReceiptsPositions.RowHeadersVisible = false;
			this.dgvReceiptsPositions.RowTemplate.Height = 30;
			this.dgvReceiptsPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReceiptsPositions.Size = new System.Drawing.Size(668, 317);
			this.dgvReceiptsPositions.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.Location = new System.Drawing.Point(977, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(34, 31);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Чеки";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(344, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Содержание чека #";
			// 
			// btnDisreserve
			// 
			this.btnDisreserve.BackColor = System.Drawing.Color.Moccasin;
			this.btnDisreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDisreserve.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDisreserve.Location = new System.Drawing.Point(556, 13);
			this.btnDisreserve.Name = "btnDisreserve";
			this.btnDisreserve.Size = new System.Drawing.Size(201, 33);
			this.btnDisreserve.TabIndex = 8;
			this.btnDisreserve.Text = "0";
			this.btnDisreserve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDisreserve.UseVisualStyleBackColor = false;
			this.btnDisreserve.Click += new System.EventHandler(this.BtnDisreserve_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 250;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// countDataGridViewTextBoxColumn
			// 
			this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
			this.countDataGridViewTextBoxColumn.HeaderText = "Кол";
			this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			this.countDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// discPriceDataGridViewTextBoxColumn
			// 
			this.discPriceDataGridViewTextBoxColumn.DataPropertyName = "DiscPrice";
			this.discPriceDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.discPriceDataGridViewTextBoxColumn.Name = "discPriceDataGridViewTextBoxColumn";
			this.discPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// receiptItemBindingSource
			// 
			this.receiptItemBindingSource.DataSource = typeof(LittleSellerKost.BL.adv.Entities.ReceiptItem);
			// 
			// dateMySQLDataGridViewTextBoxColumn
			// 
			this.dateMySQLDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dataGridViewCellStyle2.Format = "T";
			dataGridViewCellStyle2.NullValue = null;
			this.dateMySQLDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.dateMySQLDataGridViewTextBoxColumn.HeaderText = "Дата";
			this.dateMySQLDataGridViewTextBoxColumn.Name = "dateMySQLDataGridViewTextBoxColumn";
			this.dateMySQLDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn3.HeaderText = "Сумма";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// reservedDataGridViewCheckBoxColumn
			// 
			this.reservedDataGridViewCheckBoxColumn.DataPropertyName = "Reserved";
			this.reservedDataGridViewCheckBoxColumn.HeaderText = "Резерв";
			this.reservedDataGridViewCheckBoxColumn.Name = "reservedDataGridViewCheckBoxColumn";
			this.reservedDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// reservedReceiptBindingSource
			// 
			this.reservedReceiptBindingSource.DataSource = typeof(LittleSellerKost.BL.adv.Entities.Receipt);
			// 
			// FormCashVoucherHistory
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1023, 378);
			this.Controls.Add(this.btnDisreserve);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvReceiptsPositions);
			this.Controls.Add(this.dgvReceipts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormCashVoucherHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormCashVoucherHistory";
			((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvReceiptsPositions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.receiptItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservedReceiptBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvReceipts;
		private System.Windows.Forms.DataGridView dgvReceiptsPositions;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isDiscountedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource reservedReceiptBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn discPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource receiptItemBindingSource;
		private System.Windows.Forms.Button btnDisreserve;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateMySQLDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn reservedDataGridViewCheckBoxColumn;
	}
}