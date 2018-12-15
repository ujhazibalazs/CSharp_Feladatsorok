using System;
using System.IO;

namespace kapcsolo
{
	class Program
	{
		public static void Main(string[] args)
		{
			string szin = "";
			
			Console.WriteLine("Adj meg egy színt");
			szin = Console.ReadLine();
			
			switch(szin)
			{
				case "piros":
					Console.WriteLine("A megadott szín piros.");
					break;
				case "kék":
					Console.WriteLine("A megadott szín kék.");
					break;
				case "zöld":
					Console.WriteLine("A megadott szín zöld.");
					break;
				default:
					Console.WriteLine("A megadott szín ismeretlen.");
					break;
			}
			
			StreamWriter sw = new StreamWriter("szinek.txt",true);
			sw.WriteLine(szin);
			sw.Close();
			
			Console.ReadKey(true);
		}
	}
}