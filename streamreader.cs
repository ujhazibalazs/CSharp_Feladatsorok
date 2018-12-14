using System;
using System.IO;

namespace io2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int szam;
			int sor = 0;
			
			Console.WriteLine("Adj meg egy számot.");
			szam = Convert.ToInt32(Console.ReadLine());
			
			StreamReader sr = new StreamReader("szavak.txt");
			Console.WriteLine(sr.ReadLine());
			sor++;
			while(!sr.EndOfStream)
			{
				sr.ReadLine();
				
				if(sor%szam == 0)
				{
					Console.WriteLine(sr.ReadLine());
				}
				sor++;
			}
			
			sr.Close();
			
			
			
			Console.ReadKey(true);
		}
	}
}