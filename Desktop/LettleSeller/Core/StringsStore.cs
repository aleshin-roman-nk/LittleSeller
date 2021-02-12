using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LettleSellerKost.Core
{
	public static class StringsStore
	{
		public static void Store(string[] lines, string filename)
		{
			File.WriteAllLines(filename, lines, Encoding.UTF8);
		}
	}
}
