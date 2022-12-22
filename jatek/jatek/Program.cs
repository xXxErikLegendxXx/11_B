using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;

namespace jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karakter felépítés
            

            Console.Write("Hogy hívnak?: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Narrátor: Üdvözlet {nev}!");
            Thread.Sleep(1000);
            Console.WriteLine("Narrátor: Sok szerencsét!"); //Ezt a mondatot fogadd meg ha a képességeket választod!
            Thread.Sleep(2000);

            Console.Clear();

            int ero = 0;
            int gyorsasag = 0;
            int szerencse = 0;
            int karizma = 0;
            int inteligencia = 0;

            int pontszam = 10;

            Console.WriteLine($"Erő = {ero}");
            Thread.Sleep(500);
            Console.WriteLine($"Gyorsaság = {gyorsasag}");
            Thread.Sleep(500);
            Console.WriteLine($"Szerencse = {szerencse}");
            Thread.Sleep(500);
            Console.WriteLine($"Karizma = {karizma}");
            Thread.Sleep(500);
            Console.WriteLine($"Inteligencia = {inteligencia}");
            Thread.Sleep(500);
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine($"{pontszam} pontot tudsz felhasználni.");


            Console.Write("Erő:");
            ero = Convert.ToInt32(Console.ReadLine());
            pontszam -= ero;

            if (ero < 0)
                ero = 0;

            Console.Write("Gyorsaság:");
            gyorsasag = Convert.ToInt32(Console.ReadLine());
            pontszam -= gyorsasag;
            if(gyorsasag < 0)
                gyorsasag = 0;

            Console.Write("Szerencse:");
            szerencse = Convert.ToInt32(Console.ReadLine());
            pontszam -= szerencse;
            if (szerencse < 0)
                szerencse = 0;

            Console.Write("Karizma:");
            karizma = Convert.ToInt32(Console.ReadLine());
            pontszam -= karizma;
            if (karizma < 0)
                karizma = 0;

            Console.Write("Inteligencia:");
            inteligencia = Convert.ToInt32(Console.ReadLine());
            pontszam -= inteligencia;
            if (inteligencia < 0)
                inteligencia = 0;


            int max_pontszam = ero + gyorsasag + szerencse + karizma + inteligencia;

            Console.WriteLine(max_pontszam);
            Console.WriteLine(pontszam);

            while (pontszam != 0)
            {
                Console.WriteLine($"Hékás, még van {10 - max_pontszam}");

                Console.WriteLine("Fel szeretnéd használni őket? (Igen/Nem):");
                string felhasznal = Convert.ToString(Console.ReadLine()).ToLower();


                if (felhasznal == "nem")
                {
                      break;
                }


            }
            

            //üdvözlés
            Console.WriteLine($"Vendéglátó: Üdvözlet utazó!");
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