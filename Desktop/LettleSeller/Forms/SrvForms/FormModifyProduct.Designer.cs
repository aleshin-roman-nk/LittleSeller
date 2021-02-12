namespace LittleSellerKost.Forms
{
	partial class FormModifyProduct
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
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cbProdCategs = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEditWP = new System.Windows.Forms.Button();
			this.txtWPInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название";
			// 
			// tbProductName
			// 
			this.tbProductName.Location = new System.Drawing.Point(138, 21);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(432, 27);
			this.tbProductName.TabIndex = 0;
			this.tbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
			this.tbProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProductName_KeyPress);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(456, 188);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(114, 54);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Отменить";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(336, 188);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(114, 54);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "ОК";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "Категория";
			// 
			// cbProdCategs
			// 
			this.cbProdCategs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProdCategs.FormattingEnabled = true;
			this.cbProdCategs.Location = new System.Drawing.Point(138, 120);
			this.cbProdCategs.Name = "cbProdCategs";
			this.cbProdCategs.Size = new System.Drawing.Size(432, 29);
			this.cbProdCategs.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 21);
			this.label2.TabIndex = 15;
			this.label2.Text = "Вес - Цена";
			// 
			// btnEditWP
			// 
			this.btnEditWP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEditWP.Location = new System.Drawing.Point(138, 63);
			this.btnEditWP.Name = "btnEditWP";
			this.btnEditWP.Size = new System.Drawing.Size(114, 39);
			this.btnEditWP.TabIndex = 16;
			this.btnEditWP.Text = "...";
			this.btnEditWP.UseVisualStyleBackColor = true;
			this.btnEditWP.Click += new System.EventHandler(this.btnEditWP_Click);
			// 
			// txtWPInfo
			// 
			this.txtWPInfo.AutoSize = true;
			this.txtWPInfo.Location = new System.Drawing.Point(258, 72);
			this.txtWPInfo.Name = "txtWPInfo";
			this.txtWPInfo.Size = new System.Drawing.Size(19, 21);
			this.txtWPInfo.TabIndex = 17;
			this.txtWPInfo.Text = "0";
			// 
			// FormModifyProduct
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(582, 260);
			this.Controls.Add(this.txtWPInfo);
			this.Controls.Add(this.btnEditWP);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbProdCategs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.tbProductName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormModifyProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавление продукта";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbProductName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbProdCategs;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEditWP;
		private System.Windows.Forms.Label txtWPInfo;
	}
}