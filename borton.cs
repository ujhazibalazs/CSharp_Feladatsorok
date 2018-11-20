using System;

namespace borton
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool[] cellak = new bool[100];
			
			//Kezdetben a cellák zárva vannak
			for(int i=0;i<100;i++)
			{
				cellak[i] = false;
			}
			
			//Játszik a rendőr
			for(int j=0;j<100;j++)
			{
				for(int i=0;i<100;i++)
				{
					if((i+1) % (j+1) == 0)
					{
						if(cellak[i] == false)
						{
							cellak[i] = true;
						}
						else if(cellak[i] == true)
						{
							cellak[i] = false;
						}
					}
				}
			}
			
			//Kiiratás
			for(int i=0;i<100;i++)
			{
				if(cellak[i] == true)
				{
					Console.WriteLine("{0}. Cella: nyitva.",i);
				}
				else if(cellak[i] == false)
				{
					Console.WriteLine("{0}. Cella: zárva.",i);
				}
			}
			
			//A szabaduló rabok kiírása
			for(int i=0;i<100;i++)
			{
				if(cellak[i] == true)
				{
					Console.WriteLine("A {0}. cella rabja szabadul",i);
				}
			}
			
			Console.ReadKey(true);
		}
	}
}