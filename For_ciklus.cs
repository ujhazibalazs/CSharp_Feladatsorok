using System;

namespace for_ciklus
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("Press any key to continue . . . ");
			//int paros=0;
			//int paratlan=1;
			//int ketjegyu=11;
			int szam=0;
			bool prim=true;
			//int osszeg=0;
			Console.WriteLine("Adj meg egy számot");
			szam=Convert.ToInt32(Console.ReadLine());
			
			for(int i=2;i<szam;i++)
			{
				Console.WriteLine(i);
				if(szam%i==0)
				{
					prim=false;
				}
			}
			
			if(prim==true)
			{
				Console.WriteLine("A megadott szám prím.");
			}
			else
			{
				Console.WriteLine("A megadott szám nem prím.");
			}
			
			
			//for(int i=1;i<=szam;i++)
			//{
			//	Console.WriteLine(i);
				//osszeg+=i;
				//osszeg=i-1*i;
				
			//}
			//Console.WriteLine("A számok összege: {0}.",osszeg);
			//Console.WriteLine("A számok szorzata: {0}.",osszeg);
			
			
			//for(int i=1;i<=10;i++)
			//{
				//Console.WriteLine(ketjegyu);
				//paros+=2;
				//paratlan+=2;
				//ketjegyu+=10;
			//}
			
			Console.ReadKey(true);
		}
	}
}