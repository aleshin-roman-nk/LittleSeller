using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TransacSender
{
	public static class Logger
	{
		public static void Write(string msg)
		{
			File.AppendAllText("log.txt", msg, Encoding.UTF8);
			File.AppendAllText("log.txt", "\n", Encoding.UTF8);
		}
	}
}
