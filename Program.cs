using System;

namespace FeladatsorIV
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Első feladat
			//double az adattípus neve, elso a változó neve
			//a double lehet tört szám is
			double elso=0;
			double masodik=0;
			
			//hátultesztelős ciklus lefut a do utáni kód, majd megnézi a while utáni zárójelek közötti feltételt,
			//hogy igaz-e, ha igen akkor újra lefut a do utáni kód és ezt addig csinálja amég nem lesz hamis a feltétel
			do
			{
				//A Console.WriteLine függvénnyel tudunk kiírni a konzolban, ez automatikusan a következő sorba teszi a kurzort
				//A Console.Write függvény ugyan ezt csinálja, csak nem teszi a következő sorba a kurzort.
				Console.WriteLine("Kérem az első számot: ");
				//A Console.ReadLine() függvénnyel tudunk bekérni a felhasználótol.
				//Az elso nevű változóba akarjuk eltárolni a felhasználó által beadott számot
				//Mivel a Console.ReadLine string típusú adatot ad vissza, ezért a Convert függvényt használjuk, hogy doublet-
				//csináljunk a bekért adatból. A Convert után lehet ToInt és ToString is
				elso=Convert.ToDouble(Console.ReadLine());
			}while(elso==0);
			//elso==0 a feltétel, mert azt ellenőrizzük, hogy a bekért szám 0 vagy sem, ha 0 akkor újra be kell kérjük a számot.
			
			do
			{
			Console.WriteLine("Kérem a második számot: ");
			masodik=Convert.ToDouble(Console.ReadLine());
			}while(masodik==0);
			
			//A {0} helyére a vessző utáni "elso/masodik" eredménye fog bekerülni.
			Console.WriteLine("A két szám hányadosa: {0}.",elso/masodik);
			//Első feladat vége
			
			//Második feladat
			int szam=0;
			
			Console.WriteLine("Adj meg egy számot: ");
			szam=Convert.ToInt32(Console.ReadLine());
			
			//az if(ha) után van a feltétel, ha ez igaz akkor az alatta lévő rész fut le, ha nem akkor az else ágban lévő, ha van.
			//if-et else ág nélkül is lehet készíteni, így is működni fog, illetve else után lehet még egy if, mint ebben az esetben.
			if(szam>0)
			{
				Console.WriteLine("A szám pozitív előjelű.");
			}
			else if(szam<0)
			{
				Console.WriteLine("A szám negatív előjelű.");
			}
			else
			{
				Console.WriteLine("A szám nulla.");
			}
			//Második feladat vége
			
			//Harmadik feladat
			
			//int adattípus az egész szám.
			int A=0;
			int B=0;
			
			//kiírás
			Console.WriteLine("Adja meg az A számot:");
			//bekérés
			A=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adja meg a B számot:");
			B=Convert.ToInt32(Console.ReadLine());
			
			//A%B azt a maradékot adja eredményül amennyi osztás után maradna, így ha ez 0
			//akkor biztosan osztható A B-vel.
			//A felkiáltó jel a = előtt azt jelenti, hogy nem egyenlő
			if(A%B!=0)
			{
				Console.WriteLine("A szám nem osztható B-vel.");
			}
			else
			{
				Console.WriteLine("A szám osztható B-vel.");
			}
			
			//Harmadik feladat vége
			//Negyedik feladat
			
			int szam1=0;
			int szam2=0;
			int szam3=0;
			int legnagyobb=0;
			
			Console.WriteLine("Adja meg az első számot:");
			szam1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adja meg a második számot:");
			szam2=Convert.ToInt32(Console.ReadLine());			
			Console.WriteLine("Adja meg a harmadik számot:");
			szam3=Convert.ToInt32(Console.ReadLine());
			
			if(szam1>szam2)
			{
				if(szam1>szam3)
				{
					legnagyobb=szam1;
				}
				else
				{
					legnagyobb=szam3;
				}
			}
			else
			{
				if(szam2>szam3)
				{
					legnagyobb=szam2;
				}
				else
				{
					legnagyobb=szam3;
				}
			}
			
			Console.WriteLine("A legnagyobb szám: {0}.",legnagyobb);
			
			//Negyedik feladat vége
			
			//A Console.ReadKey() függvény egy karakter leütésre vár, ezt szokták a konzol programok végére hagyni,
			//hogy ne záródjon automatikusan be az ablak
			Console.ReadKey(true);
		}
	}
}