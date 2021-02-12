using System;
using System.Collections.Generic;
using System.Drawing;

namespace LittleSellerKost.Models
{
	/// <summary>
	/// Выводит текст как на консоли с переносом слов.
	/// </summary>
	internal class PrintConsole
	{
		Graphics grOutput;
		float pos = 0;
		int maxWidth;

		public float Pos { get => pos; }

		public PrintConsole(Graphics gr, int width)
		{
			grOutput = gr;
			grOutput.PageUnit = GraphicsUnit.Millimeter;
			maxWidth = width;
		}

		public void Write(string str)
		{
			throw new NotImplementedException();
		}

		//public void WriteLine(string str, Font font = null)
		//{
		//	var f = font == null ? DefaultFont : font;
		//	grOutput.DrawString(str, f, Brushes.Black, new PointF(0, pos));
		//	pos += f.GetHeight(grOutput);
		//}

		public void WriteLine(string str, Font font = null)
		{
			var f = font == null ? DefaultFont : font;
			int fHeight = Convert.ToInt32(f.GetHeight(grOutput));

			//string[] strList = getWrapped(str, font);
			//foreach (var item in strList)
			//{
			//	grOutput.DrawString(item, f, Brushes.Black, new PointF(0, pos));
			//	pos += f.GetHeight(grOutput);
			//}

			// Ширина выводимого текста
			float strWidth = grOutput.MeasureString(str, f).Width;
			// Сколько строк занимает текст
			float linesCount = strWidth / maxWidth;
			// Целое количество, округленное в бОльшую сторону
			int linesCountInt = Convert.ToInt32(Math.Round(Convert.ToDouble(linesCount)) == 0 ? 1 : Math.Round(Convert.ToDouble(linesCount)));

			int rLeft = 0, rTop = Convert.ToInt32(pos), rWidth = maxWidth, rHeight = fHeight * linesCountInt;
			Rectangle r = new Rectangle(rLeft, rTop, rWidth, rHeight);
			grOutput.DrawString(str, f, Brushes.Black, r);
			pos += fHeight * Convert.ToSingle(linesCountInt);
		}

		Font DefaultFont = new Font("Lucida Sans", 10, FontStyle.Regular);

		/// <summary>
		/// Нарезать строку, чтобы куски вмещались в строку
		/// </summary>
		/// <param name="str"></param>
		string[] getWrapped(string str, Font f)
		{
			List<string> wrappedLines = new List<string>();
			string[] originWords = str.Split(new char[] { ' ' }, StringSplitOptions.None);

			foreach (var item in originWords)
			{
				var sss = grOutput.MeasureString(item, f);
			}

			return wrappedLines.ToArray();
		}
	}
}