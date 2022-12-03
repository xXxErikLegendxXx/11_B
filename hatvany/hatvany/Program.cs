namespace gyakorlás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Kérek egy számot:");
            int szaEm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kérek egy másik számot");
            int szamR2 = Convert.ToInt32(Console.ReadLine());
            double inttoDoubleI = szaEm1;

            //Console.WriteLine("A szam1 erteke: "+ szaEm1 + ", a szam2 erteke" + szaRm2+","+"az inttodouble erteke:" + InttoDouble);
            Console.WriteLine("A szam1 erteke:{0}, a szam2 erteke: {1}, az IntToDouble ertkeke: {2}", szaEm1,szamR2,inttoDoubleI);

            string szovegKi = $"A szam1 erteke: {szaEm1}, a szam2 erteke {szamR2}, az inToDouble erteke: {inttoDoubleI}";

            Console.WriteLine(szovegKi);

            if(szaEm1 >= szamR2)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A szam1 nagyobb mint a szam2");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A szam2 nagyobb mint a szam1");
            }
            Console.ResetColor();*/

            string title = "Ketto hatvanyok";
            string head1 = "Hatvany";
            string head2 = "Ertek";


            //Console pozíciók megadása

            int curTop = 0;
            int midL = Console.WindowWidth / 2 - 1;
            int midR = Console.WindowWidth / 2 + 1;


            //Cím
            Console.SetCursorPosition(midL + 1 - ((int)Math.Ceiling((double)title.Length / 2)), curTop);

            Console.Write(title);

            curTop += 2;


            //Első kettő rész cím rész kialakítása miL-ből kivonjuk a szöveg hosszát hogy ne tolódjon el és megadjuk nekik a színt
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(midL - head1.Length, curTop);
            Console.Write(head1);
            Console.SetCursorPosition(midR, curTop);
            Console.Write(head2);

            //reseteljük a színt 

            Console.ResetColor();

            //For ciklus segítségével kiírjuk a hatványokat
            //és ezeket az első sorban lévő cuccok alapján kiíratjuk és szerkesztjük                                    

            for (int e = 0; e <= 16; e++)
            {
                curTop++;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(midL - e.ToString().Length - 2, curTop);
                Console.Write($"2^{e}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(midR, curTop);
                Console.Write(Math.Pow(2, e));
            }
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}