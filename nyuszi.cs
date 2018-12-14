using System;
using System.IO;

namespace nyuszi
{
	class Program
	{
		public static void Main(string[] args)
		{
			int tojas = 0;
			int suti = 0;
			int csoki = 0;
			string sor = "";
			int i = 0;
			
			string[] nevek = new string[100];
			
			StreamReader sr = new StreamReader("nyuszi.txt");
			
			while(!sr.EndOfStream)
			{
				sor = sr.ReadLine();
				nevek[i] = sor;
				i++;
				sor = sr.ReadLine();
				tojas += Convert.ToInt32(sor);
				sor = sr.ReadLine();
				csoki += Convert.ToInt32(sor);
				sor = sr.ReadLine();
				suti += Convert.ToInt32(sor);
			}
			
			Console.WriteLine("A meglocsolt hölgyek neve:");
			
			for(int j=0;j<=i;j++)
			{
				Console.WriteLine(nevek[j]);
			}
			
			Console.WriteLine("Tojások száma: {0}",tojas);
			Console.WriteLine("Csokik száma: {0}",csoki);
			Console.WriteLine("Sütik száma: {0}",suti);
			
			sr.Close();
			Console.ReadKey(true);
		}
	}
}