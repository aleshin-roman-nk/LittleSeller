namespace LittleSellerKost.Forms
{
	partial class FormChangeSettings
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbPrinterCashValue = new System.Windows.Forms.LinkLabel();
			this.tbPrinterMenu = new System.Windows.Forms.LinkLabel();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Принтер чеков";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Принтер меню";
			// 
			// tbPrinterCashValue
			// 
			this.tbPrinterCashValue.AutoSize = true;
			this.tbPrinterCashValue.Location = new System.Drawing.Point(137, 21);
			this.tbPrinterCashValue.Name = "tbPrinterCashValue";
			this.tbPrinterCashValue.Size = new System.Drawing.Size(18, 19);
			this.tbPrinterCashValue.TabIndex = 4;
			this.tbPrinterCashValue.TabStop = true;
			this.tbPrinterCashValue.Text = "0";
			this.tbPrinterCashValue.VisitedLinkColor = System.Drawing.Color.Blue;
			this.tbPrinterCashValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tbPrinterCashValue_LinkClicked);
			// 
			// tbPrinterMenu
			// 
			this.tbPrinterMenu.AutoSize = true;
			this.tbPrinterMenu.Location = new System.Drawing.Point(137, 52);
			this.tbPrinterMenu.Name = "tbPrinterMenu";
			this.tbPrinterMenu.Size = new System.Drawing.Size(18, 19);
			this.tbPrinterMenu.TabIndex = 5;
			this.tbPrinterMenu.TabStop = true;
			this.tbPrinterMenu.Text = "0";
			this.tbPrinterMenu.VisitedLinkColor = System.Drawing.Color.Blue;
			this.tbPrinterMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tbPrinterMenu_LinkClicked);
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Location = new System.Drawing.Point(480, 112);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(121, 43);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// FormChangeSettings
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(613, 165);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tbPrinterMenu);
			this.Controls.Add(this.tbPrinterCashValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormChangeSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormPrinters";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel tbPrinterCashValue;
		private System.Windows.Forms.LinkLabel tbPrinterMenu;
		private System.Windows.Forms.Button btnOk;
	}
}