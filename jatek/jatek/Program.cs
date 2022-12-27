﻿using System.ComponentModel.DataAnnotations;
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

            int pontszam = 10;
            int e = 0;
            int gy = 0;
            int i = 0;
            int k = 0;
            int se = 0;

            Console.WriteLine($"Erő = {e}");
            Thread.Sleep(500);
            Console.WriteLine($"Gyorsaság = {gy}");
            Thread.Sleep(500);
            Console.WriteLine($"Inteligencia = {i}");
            Thread.Sleep(500);
            Console.WriteLine($"Karizma = {k}");
            Thread.Sleep(500);
            Console.WriteLine($"SzErencse = {se}");
            Thread.Sleep(500);
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine($"{pontszam} pontot tudsz felhasználni.");

            while (true)
            {
                Console.Write("Erő:");

                string ero_szam = Console.ReadLine();

                if(int.TryParse(ero_szam,out int ero) && ero > 0 && ero <= 10)
                {
                    e = ero;
                    pontszam -= ero;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Gyorsaság:");

                string gyorsasag_szam = Console.ReadLine();

                if (int.TryParse(gyorsasag_szam, out int gyorsasag) && gyorsasag >= 0 && gyorsasag <= pontszam)
                {
                    gy = gyorsasag;
                    pontszam -= gyorsasag;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Inteligencia:");

                string inteligencia_szam = Console.ReadLine();

                if (int.TryParse(inteligencia_szam, out int inteligencia) && inteligencia >= 0 && inteligencia <= pontszam)
                {
                    i = inteligencia;
                    pontszam -= inteligencia;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Karizma:");

                string karizma_szam = Console.ReadLine();

                if (int.TryParse(karizma_szam, out int karizma) && karizma >= 0 && karizma <= pontszam)
                { 
                    k = karizma;
                    pontszam -= karizma;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Szerencse:");

                string szerencse_szam = Console.ReadLine();

                if (int.TryParse(szerencse_szam, out int szerencse) && szerencse >= 0 && szerencse <= pontszam)
                {
                    se = szerencse;
                    pontszam -= szerencse;
                    break;
                }
            }

            Console.WriteLine(pontszam);


            //Marad még pontod
            while (pontszam > 0)
            {
                Console.WriteLine($"Narrátor: Nem tudom észrevetted-e,de még van {pontszam} pontod");

                Console.WriteLine("Narrátor: Fel szeretnéd használni őket? (Igen/Nem):");
                string felhasznal = Console.ReadLine().ToLower();

                while(felhasznal != "igen" && felhasznal !="nem")
                {
                    Console.WriteLine("Narrátor: Fel szeretnéd használni őket? (Igen/Nem):");
                    felhasznal = Console.ReadLine().ToLower();
                }

                if (felhasznal == "nem")
                {
                      break;
                }
                else if (felhasznal == "igen")
                {
                
                    Console.WriteLine($"Erő = {e}");
                    Thread.Sleep(500);
                    Console.WriteLine($"Gyorsaság = {gy}");
                    Thread.Sleep(500);
                    Console.WriteLine($"Inteligencia = {i}");
                    Thread.Sleep(500);
                    Console.WriteLine($"Karizma = {k}");
                    Thread.Sleep(500);
                    Console.WriteLine($"SzErencse = {se}");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Thread.Sleep(500);

                    Console.WriteLine($"Narrátor: Maradék elkölthető pont:{pontszam}");

                    Console.WriteLine("Narrátor: Válasz egy képességet amire felakarod használni a maradék pontodat(E /GY /I /K /SE)");

                    string maradek_pont = Console.ReadLine().ToLower();

                    if (maradek_pont == "e")
                    {
                        e += pontszam;
                        pontszam = 0;
                    }

                    else if (maradek_pont == "gy")
                    {
                        gy += pontszam;
                        pontszam = 0;
                    }

                    else if (maradek_pont == "i")
                    {
                        i += pontszam;
                        pontszam = 0;
                    }
                    else if (maradek_pont == "k")
                    {
                        k += pontszam;
                        pontszam = 0;
                    }
                    else if (maradek_pont == "se")
                    {
                        se += pontszam;
                        pontszam = 0;
                    }
                    else if (maradek_pont == "egyikse")
                    {
                        pontszam = 0;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Narrátor: Válasz egy képességet amire felakarod használni a maradék pontodat(E /GY /I /K /SE)");

                            maradek_pont = Console.ReadLine().ToLower();

                            if (maradek_pont == "e")
                            {
                                e += pontszam;
                                pontszam = 0;
                                break;
                            }
                            else if (maradek_pont == "gy")
                            {
                                gy += pontszam;
                                pontszam = 0;
                                break;
                            }
                            else if (maradek_pont == "i")
                            {
                                i += pontszam;
                                pontszam = 0;
                                break;
                            }
                            else if (maradek_pont == "k")
                            {
                                k += pontszam;
                                pontszam = 0;
                                break;
                            }
                            else if (maradek_pont == "se")
                            {
                                se += pontszam;
                                pontszam = 0;
                                break;
                            }
                            else if(maradek_pont == "egyikse")
                            {
                                pontszam = 0;
                                break;
                            }
                        }
                    }
                }
            }


            //üdvözlés
            Console.Clear();
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