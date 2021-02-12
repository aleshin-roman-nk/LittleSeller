using System;

namespace LittleSellerKost
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvThisReceipt = new System.Windows.Forms.DataGridView();
			this.dgvShiftMenuItems = new System.Windows.Forms.DataGridView();
			this.weightOriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deltaCntDataGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCurrentCashAmount = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblShiftState = new System.Windows.Forms.Label();
			this.label100 = new System.Windows.Forms.Label();
			this.btnShift = new System.Windows.Forms.Button();
			this.btnCloseShift = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnWeights = new System.Windows.Forms.Button();
			this.lblCurrentCategory = new System.Windows.Forms.Label();
			this.btnTodayMenu = new System.Windows.Forms.Button();
			this.btnBtnId0 = new System.Windows.Forms.Button();
			this.btnCatId5 = new System.Windows.Forms.Button();
			this.btnCatId4 = new System.Windows.Forms.Button();
			this.btnCatId6 = new System.Windows.Forms.Button();
			this.btnCatId2 = new System.Windows.Forms.Button();
			this.btnCatId3 = new System.Windows.Forms.Button();
			this.btnCatId1 = new System.Windows.Forms.Button();
			this.lbTime = new System.Windows.Forms.Label();
			this.lblCurrentLang = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lbSoldsAmount = new System.Windows.Forms.Label();
			this.lb666 = new System.Windows.Forms.Label();
			this.lbSoldsCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.lblTransCount = new System.Windows.Forms.Label();
			this.posInGridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceOriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsShiftMenuItems = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsReceiptItems = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvThisReceipt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvShiftMenuItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsShiftMenuItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsReceiptItems)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvThisReceipt
			// 
			this.dgvThisReceipt.AllowUserToAddRows = false;
			this.dgvThisReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvThisReceipt.AutoGenerateColumns = false;
			this.dgvThisReceipt.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvThisReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvThisReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvThisReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvThisReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.discPriceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
			this.dgvThisReceipt.DataSource = this.bsReceiptItems;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvThisReceipt.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvThisReceipt.EnableHeadersVisualStyles = false;
			this.dgvThisReceipt.GridColor = System.Drawing.Color.Lime;
			this.dgvThisReceipt.Location = new System.Drawing.Point(2, 71);
			this.dgvThisReceipt.Name = "dgvThisReceipt";
			this.dgvThisReceipt.ReadOnly = true;
			this.dgvThisReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvThisReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvThisReceipt.RowHeadersVisible = false;
			this.dgvThisReceipt.RowTemplate.Height = 30;
			this.dgvThisReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvThisReceipt.Size = new System.Drawing.Size(583, 518);
			this.dgvThisReceipt.TabIndex = 1;
			// 
			// dgvShiftMenuItems
			// 
			this.dgvShiftMenuItems.AllowUserToAddRows = false;
			this.dgvShiftMenuItems.AllowUserToDeleteRows = false;
			this.dgvShiftMenuItems.AllowUserToResizeRows = false;
			this.dgvShiftMenuItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvShiftMenuItems.AutoGenerateColumns = false;
			this.dgvShiftMenuItems.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvShiftMenuItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvShiftMenuItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvShiftMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShiftMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posInGridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.weightOriginDataGridViewTextBoxColumn,
            this.priceOriginDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.deltaCntDataGridColumn});
			this.dgvShiftMenuItems.DataSource = this.bsShiftMenuItems;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvShiftMenuItems.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvShiftMenuItems.EnableHeadersVisualStyles = false;
			this.dgvShiftMenuItems.GridColor = System.Drawing.Color.Lime;
			this.dgvShiftMenuItems.Location = new System.Drawing.Point(0, 71);
			this.dgvShiftMenuItems.Name = "dgvShiftMenuItems";
			this.dgvShiftMenuItems.ReadOnly = true;
			this.dgvShiftMenuItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvShiftMenuItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvShiftMenuItems.RowHeadersVisible = false;
			this.dgvShiftMenuItems.RowTemplate.Height = 30;
			this.dgvShiftMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvShiftMenuItems.Size = new System.Drawing.Size(677, 518);
			this.dgvShiftMenuItems.TabIndex = 0;
			// 
			// weightOriginDataGridViewTextBoxColumn
			// 
			this.weightOriginDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightOriginDataGridViewTextBoxColumn.HeaderText = "Вес";
			this.weightOriginDataGridViewTextBoxColumn.Name = "weightOriginDataGridViewTextBoxColumn";
			this.weightOriginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// deltaCntDataGridColumn
			// 
			this.deltaCntDataGridColumn.DataPropertyName = "DeltaCnt";
			this.deltaCntDataGridColumn.HeaderText = "Остаток";
			this.deltaCntDataGridColumn.Name = "deltaCntDataGridColumn";
			this.deltaCntDataGridColumn.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Сумма по чеку";
			// 
			// lblCurrentCashAmount
			// 
			this.lblCurrentCashAmount.AutoSize = true;
			this.lblCurrentCashAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lblCurrentCashAmount.Location = new System.Drawing.Point(172, 46);
			this.lblCurrentCashAmount.Name = "lblCurrentCashAmount";
			this.lblCurrentCashAmount.Size = new System.Drawing.Size(19, 19);
			this.lblCurrentCashAmount.TabIndex = 12;
			this.lblCurrentCashAmount.Text = "0";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(4, 5);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lblShiftState);
			this.splitContainer1.Panel1.Controls.Add(this.label100);
			this.splitContainer1.Panel1.Controls.Add(this.btnShift);
			this.splitContainer1.Panel1.Controls.Add(this.btnCloseShift);
			this.splitContainer1.Panel1.Controls.Add(this.btnSettings);
			this.splitContainer1.Panel1.Controls.Add(this.btnWeights);
			this.splitContainer1.Panel1.Controls.Add(this.lblCurrentCategory);
			this.splitContainer1.Panel1.Controls.Add(this.btnTodayMenu);
			this.splitContainer1.Panel1.Controls.Add(this.btnBtnId0);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId5);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId4);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId6);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId2);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId3);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId1);
			this.splitContainer1.Panel1.Controls.Add(this.dgvShiftMenuItems);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lblTransCount);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.lbTime);
			this.splitContainer1.Panel2.Controls.Add(this.lblCurrentLang);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Panel2.Controls.Add(this.dgvThisReceipt);
			this.splitContainer1.Panel2.Controls.Add(this.lbSoldsAmount);
			this.splitContainer1.Panel2.Controls.Add(this.lblCurrentCashAmount);
			this.splitContainer1.Panel2.Controls.Add(this.lb666);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.lbSoldsCount);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Size = new System.Drawing.Size(1273, 629);
			this.splitContainer1.SplitterDistance = 677;
			this.splitContainer1.TabIndex = 13;
			// 
			// lblShiftState
			// 
			this.lblShiftState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblShiftState.AutoSize = true;
			this.lblShiftState.Location = new System.Drawing.Point(494, 605);
			this.lblShiftState.Name = "lblShiftState";
			this.lblShiftState.Size = new System.Drawing.Size(25, 13);
			this.lblShiftState.TabIndex = 26;
			this.lblShiftState.Text = "000";
			// 
			// label100
			// 
			this.label100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label100.AutoSize = true;
			this.label100.Location = new System.Drawing.Point(494, 592);
			this.label100.Name = "label100";
			this.label100.Size = new System.Drawing.Size(45, 13);
			this.label100.TabIndex = 25;
			this.label100.Text = "СМЕНА";
			// 
			// btnShift
			// 
			this.btnShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShift.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnShift.Location = new System.Drawing.Point(400, 590);
			this.btnShift.Name = "btnShift";
			this.btnShift.Size = new System.Drawing.Size(86, 31);
			this.btnShift.TabIndex = 24;
			this.btnShift.Text = "Открыть";
			this.btnShift.UseVisualStyleBackColor = true;
			this.btnShift.Click += new System.EventHandler(this.BtnShift_Click);
			// 
			// btnCloseShift
			// 
			this.btnCloseShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCloseShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseShift.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnCloseShift.Location = new System.Drawing.Point(303, 590);
			this.btnCloseShift.Name = "btnCloseShift";
			this.btnCloseShift.Size = new System.Drawing.Size(91, 31);
			this.btnCloseShift.TabIndex = 23;
			this.btnCloseShift.Text = "Закрыть";
			this.btnCloseShift.UseVisualStyleBackColor = true;
			this.btnCloseShift.Click += new System.EventHandler(this.btnCloseShift_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnSettings.Location = new System.Drawing.Point(180, 590);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(117, 31);
			this.btnSettings.TabIndex = 22;
			this.btnSettings.Text = "Настройки";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnWeights
			// 
			this.btnWeights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnWeights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWeights.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnWeights.Location = new System.Drawing.Point(91, 590);
			this.btnWeights.Name = "btnWeights";
			this.btnWeights.Size = new System.Drawing.Size(83, 31);
			this.btnWeights.TabIndex = 21;
			this.btnWeights.Text = "[В]есовка";
			this.btnWeights.UseVisualStyleBackColor = true;
			this.btnWeights.Click += new System.EventHandler(this.btnWeights_Click);
			// 
			// lblCurrentCategory
			// 
			this.lblCurrentCategory.AutoSize = true;
			this.lblCurrentCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCurrentCategory.Location = new System.Drawing.Point(493, 9);
			this.lblCurrentCategory.Name = "lblCurrentCategory";
			this.lblCurrentCategory.Size = new System.Drawing.Size(19, 19);
			this.lblCurrentCategory.TabIndex = 20;
			this.lblCurrentCategory.Text = "0";
			// 
			// btnTodayMenu
			// 
			this.btnTodayMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTodayMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTodayMenu.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnTodayMenu.Location = new System.Drawing.Point(3, 590);
			this.btnTodayMenu.Name = "btnTodayMenu";
			this.btnTodayMenu.Size = new System.Drawing.Size(82, 31);
			this.btnTodayMenu.TabIndex = 19;
			this.btnTodayMenu.Text = "[М]еню";
			this.btnTodayMenu.UseVisualStyleBackColor = true;
			this.btnTodayMenu.Click += new System.EventHandler(this.btnTodayMenu_Click);
			// 
			// btnBtnId0
			// 
			this.btnBtnId0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBtnId0.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBtnId0.Location = new System.Drawing.Point(400, 39);
			this.btnBtnId0.Name = "btnBtnId0";
			this.btnBtnId0.Size = new System.Drawing.Size(87, 26);
			this.btnBtnId0.TabIndex = 7;
			this.btnBtnId0.Tag = "ВСЕ";
			this.btnBtnId0.Text = "ВСЕ (F7)";
			this.btnBtnId0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBtnId0.UseVisualStyleBackColor = true;
			this.btnBtnId0.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId5
			// 
			this.btnCatId5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId5.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId5.Location = new System.Drawing.Point(126, 39);
			this.btnCatId5.Name = "btnCatId5";
			this.btnCatId5.Size = new System.Drawing.Size(135, 26);
			this.btnCatId5.TabIndex = 6;
			this.btnCatId5.Tag = "НАПИТКИ";
			this.btnCatId5.Text = "НАПИТКИ (F5)";
			this.btnCatId5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCatId5.UseVisualStyleBackColor = true;
			this.btnCatId5.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId4
			// 
			this.btnCatId4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId4.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId4.Location = new System.Drawing.Point(267, 39);
			this.btnCatId4.Name = "btnCatId4";
			this.btnCatId4.Size = new System.Drawing.Size(127, 26);
			this.btnCatId4.TabIndex = 5;
			this.btnCatId4.Tag = "ВЫПЕЧКА";
			this.btnCatId4.Text = "ВЫПЕЧКА (F6)";
			this.btnCatId4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCatId4.UseVisualStyleBackColor = true;
			this.btnCatId4.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId6
			// 
			this.btnCatId6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId6.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId6.Location = new System.Drawing.Point(267, 7);
			this.btnCatId6.Name = "btnCatId6";
			this.btnCatId6.Size = new System.Drawing.Size(220, 26);
			this.btnCatId6.TabIndex = 4;
			this.btnCatId6.Tag = "САЛАТЫ";
			this.btnCatId6.Text = "САЛАТЫ (F3)";
			this.btnCatId6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCatId6.UseVisualStyleBackColor = true;
			this.btnCatId6.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId2
			// 
			this.btnCatId2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId2.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId2.Location = new System.Drawing.Point(8, 39);
			this.btnCatId2.Name = "btnCatId2";
			this.btnCatId2.Size = new System.Drawing.Size(112, 26);
			this.btnCatId2.TabIndex = 3;
			this.btnCatId2.Tag = "ГОРЯЧЕЕ";
			this.btnCatId2.Text = "ГОРЯЧЕЕ (F4)";
			this.btnCatId2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCatId2.UseVisualStyleBackColor = true;
			this.btnCatId2.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId3
			// 
			this.btnCatId3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId3.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId3.Location = new System.Drawing.Point(126, 7);
			this.btnCatId3.Name = "btnCatId3";
			this.btnCatId3.Size = new System.Drawing.Size(135, 26);
			this.btnCatId3.TabIndex = 2;
			this.btnCatId3.Tag = "ГАРНИРЫ";
			this.btnCatId3.Text = "ГАРНИРЫ (F2)";
			this.btnCatId3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCatId3.UseVisualStyleBackColor = true;
			this.btnCatId3.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId1
			// 
			this.btnCatId1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId1.Location = new System.Drawing.Point(8, 7);
			this.btnCatId1.Name = "btnCatId1";
			this.btnCatId1.Size = new System.Drawing.Size(112, 26);
			this.btnCatId1.TabIndex = 1;
			this.btnCatId1.Tag = "СУПЫ";
			this.btnCatId1.Text = "СУПЫ (F1)";
			this.btnCatId1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCatId1.UseVisualStyleBackColor = true;
			this.btnCatId1.Click += new System.EventHandler(this.btnCategory);
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTime.Location = new System.Drawing.Point(3, 4);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(18, 19);
			this.lbTime.TabIndex = 20;
			this.lbTime.Text = "0";
			// 
			// lblCurrentLang
			// 
			this.lblCurrentLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentLang.AutoSize = true;
			this.lblCurrentLang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCurrentLang.Location = new System.Drawing.Point(473, 5);
			this.lblCurrentLang.Name = "lblCurrentLang";
			this.lblCurrentLang.Size = new System.Drawing.Size(39, 19);
			this.lblCurrentLang.TabIndex = 19;
			this.lblCurrentLang.Text = "000";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(460, 600);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Enter продажа";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(552, -3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 33);
			this.button1.TabIndex = 13;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbSoldsAmount
			// 
			this.lbSoldsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbSoldsAmount.AutoSize = true;
			this.lbSoldsAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbSoldsAmount.Location = new System.Drawing.Point(159, 602);
			this.lbSoldsAmount.Name = "lbSoldsAmount";
			this.lbSoldsAmount.Size = new System.Drawing.Size(19, 19);
			this.lbSoldsAmount.TabIndex = 17;
			this.lbSoldsAmount.Text = "0";
			// 
			// lb666
			// 
			this.lb666.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lb666.AutoSize = true;
			this.lb666.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lb666.Location = new System.Drawing.Point(95, 602);
			this.lb666.Name = "lb666";
			this.lb666.Size = new System.Drawing.Size(63, 19);
			this.lb666.TabIndex = 16;
			this.lb666.Text = "Сумма";
			// 
			// lbSoldsCount
			// 
			this.lbSoldsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbSoldsCount.AutoSize = true;
			this.lbSoldsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbSoldsCount.Location = new System.Drawing.Point(46, 602);
			this.lbSoldsCount.Name = "lbSoldsCount";
			this.lbSoldsCount.Size = new System.Drawing.Size(19, 19);
			this.lbSoldsCount.TabIndex = 15;
			this.lbSoldsCount.Text = "0";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(3, 602);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "Кол";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(244, 602);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 19);
			this.label4.TabIndex = 21;
			this.label4.Text = "Транз-ции";
			// 
			// lblTransCount
			// 
			this.lblTransCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTransCount.AutoSize = true;
			this.lblTransCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lblTransCount.Location = new System.Drawing.Point(346, 602);
			this.lblTransCount.Name = "lblTransCount";
			this.lblTransCount.Size = new System.Drawing.Size(19, 19);
			this.lblTransCount.TabIndex = 22;
			this.lblTransCount.Text = "0";
			// 
			// posInGridDataGridViewTextBoxColumn
			// 
			this.posInGridDataGridViewTextBoxColumn.DataPropertyName = "PosInGrid";
			this.posInGridDataGridViewTextBoxColumn.HeaderText = "#";
			this.posInGridDataGridViewTextBoxColumn.Name = "posInGridDataGridViewTextBoxColumn";
			this.posInGridDataGridViewTextBoxColumn.ReadOnly = true;
			this.posInGridDataGridViewTextBoxColumn.Width = 50;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 250;
			// 
			// priceOriginDataGridViewTextBoxColumn
			// 
			this.priceOriginDataGridViewTextBoxColumn.DataPropertyName = "PriceOrigin";
			this.priceOriginDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.priceOriginDataGridViewTextBoxColumn.Name = "priceOriginDataGridViewTextBoxColumn";
			this.priceOriginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Цена %";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsShiftMenuItems
			// 
			this.bsShiftMenuItems.DataSource = typeof(LittleSellerKost.BL.adv.Entities.ShiftMenuItem);
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn1.Width = 250;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn1
			// 
			this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
			this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
			this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// discPriceDataGridViewTextBoxColumn
			// 
			this.discPriceDataGridViewTextBoxColumn.DataPropertyName = "DiscPrice";
			this.discPriceDataGridViewTextBoxColumn.HeaderText = "Цена %";
			this.discPriceDataGridViewTextBoxColumn.Name = "discPriceDataGridViewTextBoxColumn";
			this.discPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// countDataGridViewTextBoxColumn
			// 
			this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
			this.countDataGridViewTextBoxColumn.HeaderText = "Кол";
			this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			this.countDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsReceiptItems
			// 
			this.bsReceiptItems.DataSource = typeof(LittleSellerKost.BL.adv.Entities.ReceiptItem);
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1282, 636);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "КАССА";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.FormCashbox_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dgvThisReceipt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvShiftMenuItems)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsShiftMenuItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsReceiptItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvThisReceipt;
		private System.Windows.Forms.BindingSource bsReceiptItems;
		private System.Windows.Forms.DataGridView dgvShiftMenuItems;
		private System.Windows.Forms.BindingSource bsShiftMenuItems;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCurrentCashAmount;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbSoldsCount;
		private System.Windows.Forms.Label lbSoldsAmount;
		private System.Windows.Forms.Label lb666;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCatId1;
		private System.Windows.Forms.Button btnCatId3;
		private System.Windows.Forms.Button btnCatId2;
		private System.Windows.Forms.Button btnCatId6;
		private System.Windows.Forms.Button btnCatId4;
		private System.Windows.Forms.Button btnCatId5;
		private System.Windows.Forms.Button btnBtnId0;
		private System.Windows.Forms.Button btnTodayMenu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCurrentCategory;
		private System.Windows.Forms.Button btnWeights;
		private System.Windows.Forms.Label lblCurrentLang;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn discPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn posInGridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightOriginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceOriginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deltaCntDataGridColumn;
		private System.Windows.Forms.Button btnCloseShift;
		private System.Windows.Forms.Button btnShift;
		private System.Windows.Forms.Label label100;
		private System.Windows.Forms.Label lblShiftState;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTransCount;
	}
}

