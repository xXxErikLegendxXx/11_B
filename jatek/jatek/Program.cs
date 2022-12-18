using System.Runtime.CompilerServices;

namespace jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //üdvözlés

            Console.WriteLine("Narrátor: Üdvözlet utazó, mond, hogy hívnak?");
            string nev = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Narrátor: Örülök, hogy megismerhettelek {nev}");

        }
    }
}