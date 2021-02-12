namespace LittleSellerKost.Forms
{
	partial class FormReceiptCommit
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblCashVoucherSource = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.tbCash = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCashVoucherChange = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chbIsReserved = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.tbCash)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сумма по чеку";
			// 
			// lblCashVoucherSource
			// 
			this.lblCashVoucherSource.AutoSize = true;
			this.lblCashVoucherSource.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCashVoucherSource.Location = new System.Drawing.Point(217, 30);
			this.lblCashVoucherSource.Name = "lblCashVoucherSource";
			this.lblCashVoucherSource.Size = new System.Drawing.Size(22, 23);
			this.lblCashVoucherSource.TabIndex = 1;
			this.lblCashVoucherSource.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(30, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Наличные";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnCancel.Location = new System.Drawing.Point(166, 292);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(202, 37);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Отмена [Esc]";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnOk.Location = new System.Drawing.Point(12, 292);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(138, 37);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "OK [Enter]";
			this.btnOk.UseVisualStyleBackColor = false;
			// 
			// tbCash
			// 
			this.tbCash.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
			this.tbCash.Location = new System.Drawing.Point(221, 83);
			this.tbCash.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.tbCash.Name = "tbCash";
			this.tbCash.Size = new System.Drawing.Size(120, 30);
			this.tbCash.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(30, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Сдача";
			// 
			// lblCashVoucherChange
			// 
			this.lblCashVoucherChange.AutoSize = true;
			this.lblCashVoucherChange.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCashVoucherChange.Location = new System.Drawing.Point(217, 137);
			this.lblCashVoucherChange.Name = "lblCashVoucherChange";
			this.lblCashVoucherChange.Size = new System.Drawing.Size(22, 23);
			this.lblCashVoucherChange.TabIndex = 8;
			this.lblCashVoucherChange.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(228, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Продолжить продажу";
			// 
			// chbIsReserved
			// 
			this.chbIsReserved.AutoSize = true;
			this.chbIsReserved.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chbIsReserved.Location = new System.Drawing.Point(34, 196);
			this.chbIsReserved.Name = "chbIsReserved";
			this.chbIsReserved.Size = new System.Drawing.Size(102, 27);
			this.chbIsReserved.TabIndex = 11;
			this.chbIsReserved.Text = "РЕЗЕРВ";
			this.chbIsReserved.UseVisualStyleBackColor = true;
			// 
			// FormReceiptCommit
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(380, 341);
			this.Controls.Add(this.chbIsReserved);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblCashVoucherChange);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbCash);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblCashVoucherSource);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormReceiptCommit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormCashVoucherCommit";
			((System.ComponentModel.ISupportInitialize)(this.tbCash)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCashVoucherSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.NumericUpDown tbCash;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCashVoucherChange;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chbIsReserved;
	}
}