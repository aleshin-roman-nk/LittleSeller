namespace LittleSellerKost.Forms
{
	partial class FormReceiptPositionBuild
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.lbItems = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtCount)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(28, 233);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(105, 29);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.TabStop = false;
			this.btnCancel.Text = "ОТМЕНА";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(154, 233);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(123, 29);
			this.btnOk.TabIndex = 3;
			this.btnOk.TabStop = false;
			this.btnOk.Text = "ВЫБРАТЬ";
			this.btnOk.UseVisualStyleBackColor = false;
			// 
			// lbItems
			// 
			this.lbItems.FormattingEnabled = true;
			this.lbItems.ItemHeight = 20;
			this.lbItems.Location = new System.Drawing.Point(28, 114);
			this.lbItems.Name = "lbItems";
			this.lbItems.Size = new System.Drawing.Size(249, 84);
			this.lbItems.TabIndex = 1;
			this.lbItems.Enter += new System.EventHandler(this.LbItems_Enter);
			this.lbItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbItems_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Количество";
			// 
			// txtCount
			// 
			this.txtCount.DecimalPlaces = 1;
			this.txtCount.Location = new System.Drawing.Point(28, 46);
			this.txtCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(120, 26);
			this.txtCount.TabIndex = 0;
			this.txtCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtCount.ValueChanged += new System.EventHandler(this.TxtCount_ValueChanged);
			this.txtCount.Enter += new System.EventHandler(this.TxtCount_Enter);
			this.txtCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCount_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Весовой вариант";
			// 
			// FormReceiptPositionBuild
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(322, 280);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbItems);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormReceiptPositionBuild";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormSelectItem";
			((System.ComponentModel.ISupportInitialize)(this.txtCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ListBox lbItems;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown txtCount;
		private System.Windows.Forms.Label label2;
	}
}