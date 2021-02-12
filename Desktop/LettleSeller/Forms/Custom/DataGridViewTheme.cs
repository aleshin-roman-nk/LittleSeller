using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public class DataGridViewTheme: DataGridView
	{
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleHead = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleField = new System.Windows.Forms.DataGridViewCellStyle();

		public DataGridViewTheme(): base()
		{
			setup();
		}

		public Color HeaderColor
		{
			get
			{
				return dataGridViewCellStyleHead.BackColor;
			}
			set
			{
				dataGridViewCellStyleHead.BackColor = value;
			}
		}

		public Color WorkFieldColor
		{
			set
			{
				BackgroundColor = value;
				dataGridViewCellStyleField.BackColor = value;
			}
			get
			{
				return dataGridViewCellStyleField.BackColor;
			}
		}

		void setup()
		{
			// 
			// dataGridViewTheme
			// 
			this.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
			dataGridViewCellStyleHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyleHead.BackColor = System.Drawing.Color.DarkOliveGreen;
			dataGridViewCellStyleHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyleHead.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyleHead.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyleHead.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyleHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleHead;
			this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyleField.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyleField.BackColor = System.Drawing.Color.DarkSeaGreen;
			dataGridViewCellStyleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyleField.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyleField.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyleField.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyleField.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DefaultCellStyle = dataGridViewCellStyleField;
			this.EnableHeadersVisualStyles = false;
			this.GridColor = System.Drawing.Color.Black;
		}
	}
}
