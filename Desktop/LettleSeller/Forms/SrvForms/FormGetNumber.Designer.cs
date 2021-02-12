namespace LittleSellerKost.Forms
{
	partial class FormGetNumber
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbCount = new System.Windows.Forms.NumericUpDown();
			this.txtMsg = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tbCount)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(127, 90);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(39, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = false;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(231, 90);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(69, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// tbCount
			// 
			this.tbCount.DecimalPlaces = 2;
			this.tbCount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.tbCount.Location = new System.Drawing.Point(12, 46);
			this.tbCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.tbCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.tbCount.Name = "tbCount";
			this.tbCount.Size = new System.Drawing.Size(288, 29);
			this.tbCount.TabIndex = 3;
			this.tbCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtMsg
			// 
			this.txtMsg.AutoSize = true;
			this.txtMsg.Location = new System.Drawing.Point(12, 19);
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.Size = new System.Drawing.Size(21, 24);
			this.txtMsg.TabIndex = 4;
			this.txtMsg.Text = "0";
			// 
			// FormGetNumber
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(312, 125);
			this.Controls.Add(this.txtMsg);
			this.Controls.Add(this.tbCount);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormGetNumber";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormGetCount";
			((System.ComponentModel.ISupportInitialize)(this.tbCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown tbCount;
		private System.Windows.Forms.Label txtMsg;
	}
}