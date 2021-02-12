using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Core.Printer
{
	public class GridModel
	{
		Graphics graphics;

		int PosX = 0;
		int PosY = 0;

		int currentRowYPos = 0;

		List<int> columnsWidths = new List<int>();

		List<List<Cell>> Rows { get; } = new List<List<Cell>>();

		// Или пока просто сетку отрисовать
		//public void DrawGrid(Graphics gr, int rowCount, int columnCount)
		public void DrawGrid()
		{
			//gr.PageUnit = GraphicsUnit.Millimeter;

			//Pen pen = new Pen(Brushes.Black, 0.1f);
			//Font CashItems = new Font("Lucida Sans", 10, FontStyle.Regular);

			//int xPos = 5;
			//int yPos = 5;

			////int height = 5;
			//int height = Convert.ToInt32(CashItems.GetHeight(gr));
			//int width = 10;

			//// Генерация таблицы
			//// Номер строчки
			//for (int irow = 0; irow < rowCount; irow++)
			//{
			//	var row = new List<Cell>();
			//	// Номер ячейки
			//	for (int icolumn = 0; icolumn < columnCount; icolumn++)
			//	{
			//		int x = icolumn * width + xPos;
			//		int y = irow * height + yPos;
			//		int w = width;
			//		int h = height;
			//		Rectangle r = new Rectangle(x, y, w, h);
			//		Cell cell = new Cell { Rectangle = r, Text = "xXx" };
			//		row.Add(cell);
			//	}
			//	Rows.Add(row);
			//}

			//foreach (var row in Rows)
			//{
			//	foreach (var cell in row)
			//	{
			//		gr.DrawRectangle(pen, cell.Rectangle);
			//		RectangleF rf = new RectangleF(cell.Rectangle.X, cell.Rectangle.Y, cell.Rectangle.Width, cell.Rectangle.Height);
			//		gr.DrawString(cell.Text, CashItems, Brushes.Black, rf);
			//	}
			//}

			Pen pen = new Pen(Brushes.Black, 0.1f);
			foreach (var row in Rows)
			{
				foreach (var cell in row)
				{
					graphics.DrawRectangle(pen, cell.Rectangle);

					// Центрируем по нижней части ячейки
					int fontHeight = Convert.ToInt32(cell.Font.GetHeight(graphics));
					int T = cell.Rectangle.Height - fontHeight;

					RectangleF rf = new RectangleF(cell.Rectangle.X, cell.Rectangle.Y + T, cell.Rectangle.Width, cell.Rectangle.Height);
					graphics.DrawString(cell.Text, cell.Font, Brushes.Black, rf);
				}
			}
		}

		public void AddRow(Font font, params string[] cells)
		{
			if (cells.Length > columnsWidths.Count) return;

			var row = new List<Cell>();

			int fontHeight = Convert.ToInt32(font.GetHeight(graphics));
			int rowHeight = fontHeight + Convert.ToInt32(Math.Round(fontHeight * 0.5f));

			int x = PosX;
			int y = currentRowYPos + PosY;

			for (int i = 0; i < columnsWidths.Count; i++)
			{
				Rectangle r = new Rectangle(x, y, columnsWidths[i], rowHeight);
				Cell cell = new Cell { Rectangle = r, Text = cells[i], Font = font };
				x += columnsWidths[i];
				row.Add(cell);
			}

			Rows.Add(row);
			currentRowYPos += rowHeight;
		}

		// Можно разделить слой данных и слой графики. Сетка данных, сетка графических ячеек.
		public GridModel(Graphics graphics, int[] columns, int xpos, int ypos)
		{
			columnsWidths.AddRange(columns);
			this.graphics = graphics;
			graphics.PageUnit = GraphicsUnit.Millimeter;
			PosX = xpos;
			PosY = ypos;
		}

		class Cell
		{
			public string Text { get; set; }
			public Rectangle Rectangle { get; set; }
			public Font Font { get; set; }
		}
	}

	//public class Column
	//{
	//	public Column()
	//	{

	//	}
	//}
}
