namespace LittleSellerKost.Forms
{
	partial class FormTodayMenuEditor
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnClose = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFindFirst = new System.Windows.Forms.TextBox();
			this.btnEditProduct = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.btnCatId0 = new System.Windows.Forms.Button();
			this.btnCatId5 = new System.Windows.Forms.Button();
			this.btnCatId4 = new System.Windows.Forms.Button();
			this.btnCatId6 = new System.Windows.Forms.Button();
			this.btnCatId2 = new System.Windows.Forms.Button();
			this.btnCatId3 = new System.Windows.Forms.Button();
			this.btnCatId1 = new System.Windows.Forms.Button();
			this.dgvSourceProducts = new WindowsFormsApp1.DataGridViewTheme();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsTypeProducts = new System.Windows.Forms.BindingSource(this.components);
			this.btnWebLoad = new System.Windows.Forms.Button();
			this.btnPrintTodayMenu = new System.Windows.Forms.Button();
			this.dgvTodayMenuProducts = new WindowsFormsApp1.DataGridViewTheme();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BaseCountDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeltaCntDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuShiftMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnBalance = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDiscount = new System.Windows.Forms.ToolStripMenuItem();
			this.bsShiftMenuItems = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblCurrentCategory = new System.Windows.Forms.Label();
			this.btnExportCvs = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSourceProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTypeProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTodayMenuProducts)).BeginInit();
			this.contextMenuShiftMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsShiftMenuItems)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.Location = new System.Drawing.Point(1329, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(34, 31);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, 40);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnExportCvs);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.tbFindFirst);
			this.splitContainer1.Panel1.Controls.Add(this.btnEditProduct);
			this.splitContainer1.Panel1.Controls.Add(this.btnAddProduct);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId0);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId5);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId4);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId6);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId2);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId3);
			this.splitContainer1.Panel1.Controls.Add(this.btnCatId1);
			this.splitContainer1.Panel1.Controls.Add(this.dgvSourceProducts);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnWebLoad);
			this.splitContainer1.Panel2.Controls.Add(this.btnPrintTodayMenu);
			this.splitContainer1.Panel2.Controls.Add(this.dgvTodayMenuProducts);
			this.splitContainer1.Size = new System.Drawing.Size(1366, 716);
			this.splitContainer1.SplitterDistance = 663;
			this.splitContainer1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(458, 679);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "[Н]айти";
			// 
			// tbFindFirst
			// 
			this.tbFindFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tbFindFirst.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbFindFirst.Location = new System.Drawing.Point(238, 676);
			this.tbFindFirst.Name = "tbFindFirst";
			this.tbFindFirst.Size = new System.Drawing.Size(214, 30);
			this.tbFindFirst.TabIndex = 21;
			this.tbFindFirst.TextChanged += new System.EventHandler(this.tbFindFirst_TextChanged);
			// 
			// btnEditProduct
			// 
			this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEditProduct.Location = new System.Drawing.Point(131, 673);
			this.btnEditProduct.Name = "btnEditProduct";
			this.btnEditProduct.Size = new System.Drawing.Size(101, 33);
			this.btnEditProduct.TabIndex = 20;
			this.btnEditProduct.Text = "[П]равка";
			this.btnEditProduct.UseVisualStyleBackColor = true;
			this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddProduct.Location = new System.Drawing.Point(12, 673);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(113, 33);
			this.btnAddProduct.TabIndex = 19;
			this.btnAddProduct.Text = "[Д]обавить";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// btnCatId0
			// 
			this.btnCatId0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId0.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId0.Location = new System.Drawing.Point(400, 37);
			this.btnCatId0.Name = "btnCatId0";
			this.btnCatId0.Size = new System.Drawing.Size(99, 26);
			this.btnCatId0.TabIndex = 14;
			this.btnCatId0.Tag = "ВСЕ";
			this.btnCatId0.Text = "ВСЕ (F7)";
			this.btnCatId0.UseVisualStyleBackColor = true;
			this.btnCatId0.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId5
			// 
			this.btnCatId5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId5.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId5.Location = new System.Drawing.Point(124, 37);
			this.btnCatId5.Name = "btnCatId5";
			this.btnCatId5.Size = new System.Drawing.Size(141, 26);
			this.btnCatId5.TabIndex = 13;
			this.btnCatId5.Tag = "НАПИТКИ";
			this.btnCatId5.Text = "НАПИТКИ (F5)";
			this.btnCatId5.UseVisualStyleBackColor = true;
			this.btnCatId5.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId4
			// 
			this.btnCatId4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId4.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId4.Location = new System.Drawing.Point(271, 37);
			this.btnCatId4.Name = "btnCatId4";
			this.btnCatId4.Size = new System.Drawing.Size(123, 26);
			this.btnCatId4.TabIndex = 12;
			this.btnCatId4.Tag = "ВЫПЕЧКА";
			this.btnCatId4.Text = "ВЫПЕЧКА (F6)";
			this.btnCatId4.UseVisualStyleBackColor = true;
			this.btnCatId4.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId6
			// 
			this.btnCatId6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId6.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId6.Location = new System.Drawing.Point(271, 5);
			this.btnCatId6.Name = "btnCatId6";
			this.btnCatId6.Size = new System.Drawing.Size(210, 26);
			this.btnCatId6.TabIndex = 11;
			this.btnCatId6.Tag = "САЛАТЫ";
			this.btnCatId6.Text = "САЛАТЫ (F3)";
			this.btnCatId6.UseVisualStyleBackColor = true;
			this.btnCatId6.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId2
			// 
			this.btnCatId2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId2.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId2.Location = new System.Drawing.Point(5, 37);
			this.btnCatId2.Name = "btnCatId2";
			this.btnCatId2.Size = new System.Drawing.Size(113, 26);
			this.btnCatId2.TabIndex = 10;
			this.btnCatId2.Tag = "ГОРЯЧЕЕ";
			this.btnCatId2.Text = "ГОРЯЧЕЕ (F4)";
			this.btnCatId2.UseVisualStyleBackColor = true;
			this.btnCatId2.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId3
			// 
			this.btnCatId3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId3.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId3.Location = new System.Drawing.Point(124, 5);
			this.btnCatId3.Name = "btnCatId3";
			this.btnCatId3.Size = new System.Drawing.Size(141, 26);
			this.btnCatId3.TabIndex = 9;
			this.btnCatId3.Tag = "ГАРНИРЫ";
			this.btnCatId3.Text = "ГАРНИРЫ (F2)";
			this.btnCatId3.UseVisualStyleBackColor = true;
			this.btnCatId3.Click += new System.EventHandler(this.btnCategory);
			// 
			// btnCatId1
			// 
			this.btnCatId1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCatId1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCatId1.Location = new System.Drawing.Point(5, 5);
			this.btnCatId1.Name = "btnCatId1";
			this.btnCatId1.Size = new System.Drawing.Size(113, 26);
			this.btnCatId1.TabIndex = 8;
			this.btnCatId1.Tag = "СУПЫ";
			this.btnCatId1.Text = "СУПЫ (F1)";
			this.btnCatId1.UseVisualStyleBackColor = true;
			this.btnCatId1.Click += new System.EventHandler(this.btnCategory);
			// 
			// dgvSourceProducts
			// 
			this.dgvSourceProducts.AllowUserToAddRows = false;
			this.dgvSourceProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSourceProducts.AutoGenerateColumns = false;
			this.dgvSourceProducts.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvSourceProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSourceProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSourceProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSourceProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Weight,
            this.Price});
			this.dgvSourceProducts.DataSource = this.bsTypeProducts;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSourceProducts.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvSourceProducts.EnableHeadersVisualStyles = false;
			this.dgvSourceProducts.GridColor = System.Drawing.Color.Black;
			this.dgvSourceProducts.HeaderColor = System.Drawing.Color.DimGray;
			this.dgvSourceProducts.Location = new System.Drawing.Point(0, 69);
			this.dgvSourceProducts.Name = "dgvSourceProducts";
			this.dgvSourceProducts.ReadOnly = true;
			this.dgvSourceProducts.RowHeadersVisible = false;
			this.dgvSourceProducts.RowTemplate.Height = 30;
			this.dgvSourceProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSourceProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSourceProducts.Size = new System.Drawing.Size(663, 598);
			this.dgvSourceProducts.TabIndex = 0;
			this.dgvSourceProducts.WorkFieldColor = System.Drawing.Color.Silver;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 300;
			// 
			// Weight
			// 
			this.Weight.DataPropertyName = "Weight";
			this.Weight.HeaderText = "Вес";
			this.Weight.Name = "Weight";
			this.Weight.ReadOnly = true;
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "Цена";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			// 
			// bsTypeProducts
			// 
			this.bsTypeProducts.DataSource = typeof(LittleSellerKost.BL.adv.Entities.TypeProduct);
			// 
			// btnWebLoad
			// 
			this.btnWebLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnWebLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWebLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnWebLoad.Location = new System.Drawing.Point(135, 671);
			this.btnWebLoad.Name = "btnWebLoad";
			this.btnWebLoad.Size = new System.Drawing.Size(126, 42);
			this.btnWebLoad.TabIndex = 22;
			this.btnWebLoad.Text = "Загрузить с сервера";
			this.btnWebLoad.UseVisualStyleBackColor = true;
			this.btnWebLoad.Click += new System.EventHandler(this.btnWebLoad_Click);
			// 
			// btnPrintTodayMenu
			// 
			this.btnPrintTodayMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrintTodayMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintTodayMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPrintTodayMenu.Location = new System.Drawing.Point(3, 671);
			this.btnPrintTodayMenu.Name = "btnPrintTodayMenu";
			this.btnPrintTodayMenu.Size = new System.Drawing.Size(126, 42);
			this.btnPrintTodayMenu.TabIndex = 21;
			this.btnPrintTodayMenu.Text = "Печать сменного\r\nменю [Ctrl - P]";
			this.btnPrintTodayMenu.UseVisualStyleBackColor = true;
			this.btnPrintTodayMenu.Click += new System.EventHandler(this.btnPrintTodayMenu_Click);
			// 
			// dgvTodayMenuProducts
			// 
			this.dgvTodayMenuProducts.AllowUserToAddRows = false;
			this.dgvTodayMenuProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTodayMenuProducts.AutoGenerateColumns = false;
			this.dgvTodayMenuProducts.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvTodayMenuProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTodayMenuProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvTodayMenuProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTodayMenuProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.PriceOrigin,
            this.dataGridViewTextBoxColumn2,
            this.DiscountValue,
            this.BaseCountDgv,
            this.DeltaCntDgv});
			this.dgvTodayMenuProducts.ContextMenuStrip = this.contextMenuShiftMenu;
			this.dgvTodayMenuProducts.DataSource = this.bsShiftMenuItems;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTodayMenuProducts.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvTodayMenuProducts.EnableHeadersVisualStyles = false;
			this.dgvTodayMenuProducts.GridColor = System.Drawing.Color.Black;
			this.dgvTodayMenuProducts.HeaderColor = System.Drawing.Color.DimGray;
			this.dgvTodayMenuProducts.Location = new System.Drawing.Point(0, 69);
			this.dgvTodayMenuProducts.Name = "dgvTodayMenuProducts";
			this.dgvTodayMenuProducts.ReadOnly = true;
			this.dgvTodayMenuProducts.RowHeadersVisible = false;
			this.dgvTodayMenuProducts.RowTemplate.Height = 30;
			this.dgvTodayMenuProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTodayMenuProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTodayMenuProducts.Size = new System.Drawing.Size(699, 598);
			this.dgvTodayMenuProducts.TabIndex = 1;
			this.dgvTodayMenuProducts.WorkFieldColor = System.Drawing.Color.Silver;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn1.Width = 300;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Weight";
			this.dataGridViewTextBoxColumn1.HeaderText = "Вес";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// PriceOrigin
			// 
			this.PriceOrigin.DataPropertyName = "PriceOrigin";
			this.PriceOrigin.HeaderText = "Цена";
			this.PriceOrigin.Name = "PriceOrigin";
			this.PriceOrigin.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
			this.dataGridViewTextBoxColumn2.HeaderText = "Цена %";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// DiscountValue
			// 
			this.DiscountValue.DataPropertyName = "DiscountValue";
			this.DiscountValue.HeaderText = "%";
			this.DiscountValue.Name = "DiscountValue";
			this.DiscountValue.ReadOnly = true;
			this.DiscountValue.Width = 50;
			// 
			// BaseCountDgv
			// 
			this.BaseCountDgv.DataPropertyName = "BaseCount";
			this.BaseCountDgv.HeaderText = "Получено";
			this.BaseCountDgv.Name = "BaseCountDgv";
			this.BaseCountDgv.ReadOnly = true;
			// 
			// DeltaCntDgv
			// 
			this.DeltaCntDgv.DataPropertyName = "DeltaCnt";
			this.DeltaCntDgv.HeaderText = "Остаток";
			this.DeltaCntDgv.Name = "DeltaCntDgv";
			this.DeltaCntDgv.ReadOnly = true;
			// 
			// contextMenuShiftMenu
			// 
			this.contextMenuShiftMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBalance,
            this.btnDiscount});
			this.contextMenuShiftMenu.Name = "contextMenuShiftMenu";
			this.contextMenuShiftMenu.Size = new System.Drawing.Size(140, 48);
			// 
			// btnBalance
			// 
			this.btnBalance.Name = "btnBalance";
			this.btnBalance.Size = new System.Drawing.Size(139, 22);
			this.btnBalance.Text = "Количество";
			this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
			// 
			// btnDiscount
			// 
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(139, 22);
			this.btnDiscount.Text = "Скидка";
			this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
			// 
			// bsShiftMenuItems
			// 
			this.bsShiftMenuItems.DataSource = typeof(LittleSellerKost.BL.adv.Entities.ShiftMenuItem);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblCurrentCategory);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1366, 39);
			this.panel1.TabIndex = 6;
			// 
			// lblCurrentCategory
			// 
			this.lblCurrentCategory.AutoSize = true;
			this.lblCurrentCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCurrentCategory.Location = new System.Drawing.Point(8, 9);
			this.lblCurrentCategory.Name = "lblCurrentCategory";
			this.lblCurrentCategory.Size = new System.Drawing.Size(20, 24);
			this.lblCurrentCategory.TabIndex = 5;
			this.lblCurrentCategory.Text = "0";
			// 
			// btnExportCvs
			// 
			this.btnExportCvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExportCvs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportCvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExportCvs.Location = new System.Drawing.Point(539, 669);
			this.btnExportCvs.Name = "btnExportCvs";
			this.btnExportCvs.Size = new System.Drawing.Size(121, 42);
			this.btnExportCvs.TabIndex = 23;
			this.btnExportCvs.Text = "Экспорт базы csv";
			this.btnExportCvs.UseVisualStyleBackColor = true;
			this.btnExportCvs.Click += new System.EventHandler(this.BtnExportCvs_Click);
			// 
			// FormTodayMenuEditor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormTodayMenuEditor";
			this.Text = "FormTodayMenuEditor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSourceProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTypeProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTodayMenuProducts)).EndInit();
			this.contextMenuShiftMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsShiftMenuItems)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private WindowsFormsApp1.DataGridViewTheme dgvSourceProducts;
		private WindowsFormsApp1.DataGridViewTheme dgvTodayMenuProducts;
		private System.Windows.Forms.BindingSource bsTypeProducts;
		private System.Windows.Forms.BindingSource bsShiftMenuItems;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCatId0;
		private System.Windows.Forms.Button btnCatId5;
		private System.Windows.Forms.Button btnCatId4;
		private System.Windows.Forms.Button btnCatId6;
		private System.Windows.Forms.Button btnCatId2;
		private System.Windows.Forms.Button btnCatId3;
		private System.Windows.Forms.Button btnCatId1;
		private System.Windows.Forms.Button btnEditProduct;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Label lblCurrentCategory;
		private System.Windows.Forms.Button btnPrintTodayMenu;
		private System.Windows.Forms.TextBox tbFindFirst;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnWebLoad;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.ContextMenuStrip contextMenuShiftMenu;
		private System.Windows.Forms.ToolStripMenuItem btnBalance;
		private System.Windows.Forms.ToolStripMenuItem btnDiscount;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrigin;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiscountValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn BaseCountDgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeltaCntDgv;
		private System.Windows.Forms.Button btnExportCvs;
	}
}