using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSellerKost.Models
{
	public class KeyConverter
	{
		Dictionary<Keys, int> keyValues = new Dictionary<Keys, int>();

		public KeyConverter()
		{
			keyValues.Add(Keys.D1, 1);
			keyValues.Add(Keys.D2, 2);
			keyValues.Add(Keys.D3, 3);
			keyValues.Add(Keys.D4, 4);
			keyValues.Add(Keys.D5, 5);
			keyValues.Add(Keys.D6, 6);
			keyValues.Add(Keys.D7, 7);
			keyValues.Add(Keys.D8, 8);
			keyValues.Add(Keys.D9, 9);
		}

		public int ToDigit1_9(Keys keys)
		{
			if (keyValues.ContainsKey(keys))
			{
				return keyValues[keys];
			}
			else
			{
				return -1;
			}
		}
	}
}
