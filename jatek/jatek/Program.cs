using System.Runtime.CompilerServices;
using System.Threading;

namespace jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //üdvözlés

            Console.WriteLine("Vendéglátó: Üdvözlet utazó, mond, hogy hívnak?");
            string nev = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Vendéglátó: Örülök, hogy megismerhettelek {nev}");
            Thread.Sleep(1000);

            Console.WriteLine("Vendéglátó: Mi szél hozott ide?");
            Thread.Sleep(5000);

            Console.WriteLine("Vendéglátó: Nem vagy a legbeszédesebb kedvedben");
            Thread.Sleep(1000);
            Console.WriteLine("Vendéglátó: Na, de nem is baj");
            Thread.Sleep(1000);
            Console.WriteLine("Vendéglátó: Melyik szobát szeretnéd választani 1-től 10-ig? ");

            int szoba_szam = Convert.ToInt32(Console.ReadLine());

            if (szoba_szam > 10)
            {

                Console.WriteLine("Vendéglátó: Az egyetlen probléma ezzel a választással, hogy az a szoba foglalt.");
                Thread.Sleep(1000);
                Console.WriteLine("Vendéglátó: Tehát, melyik szobát szeretnéd választani 1-től 10-ig? ");

                szoba_szam = Convert.ToInt32(Console.ReadLine());

                int lehetosegek = 0;

                while (szoba_szam > 10)
                {
                    lehetosegek++;
                    Console.WriteLine("Vendéglátó: Az egyetlen probléma ezzel a választással, hogy az a szoba foglalt.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Vendéglátó: Tehát, melyik szobát szeretnéd választani 1-től 10-ig? ");

                    szoba_szam = Convert.ToInt32(Console.ReadLine());



                    if (lehetosegek == 2)
                    {
                        Console.WriteLine("Vendéglátó: Na jó, úgylátszik nem értetted a feladatot ezért én választom neked a 7-es szobát");
                        szoba_szam = 7;
                        break;
                    }
                }
            }
            else if (szoba_szam < 1)
            {
                Console.WriteLine("Vendéglátó: Az egyetlen probléma ezzel a választással, hogy az a szoba nem létezik.");
                Thread.Sleep(1000);
                Console.WriteLine("Vendéglátó: Tehát, melyik szobát szeretnéd választani 1-től 10-ig? ");

                szoba_szam = Convert.ToInt32(Console.ReadLine());

                int lehetosegek = 0;

                while (szoba_szam < 1)
                {
                    lehetosegek++;
                    Console.WriteLine("Vendéglátó: Az egyetlen probléma ezzel a választással, hogy az a szoba nem létezik.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Vendéglátó: Tehát, melyik szobát szeretnéd választani 1-től 10-ig? ");

                    szoba_szam = Convert.ToInt32(Console.ReadLine());



                    if (lehetosegek == 2)
                    {
                        Console.WriteLine("Vendéglátó: Na jó, úgylátszik nem értetted a feladatot ezért én választom neked a 7-es szobát");
                        szoba_szam = 7;
                        break;
                    }
                }
            }       

            if(szoba_szam <= 10)
            {
                Console.WriteLine("Vendéglátó: Tessék a kulcs");
                Thread.Sleep(1000);
                Console.WriteLine("Vendéglátó: Jó pihenést");
            }

        }
    }
}