namespace iksz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char iksz = 'x';
            int x = 0;
            int yF = 0;
            int yL = Console.WindowHeight;

            //x közepe (viszonyítási alapnak)
            int kozep_x = Console.WindowWidth / 2;
            int kozep_y = Console.WindowHeight / 2;
            Console.SetCursorPosition(kozep_x, kozep_y);
            Console.Write(iksz);

            //Kiírja az x-et

            while (x != kozep_x * 2 && yF != kozep_y * 2)
            {
                Console.SetCursorPosition(x, yF);
                Console.Write(iksz);
                Console.SetCursorPosition(x, yL);
                Console.Write(iksz);

                x += 4;
                yF++;
                yL--;
            }

            Console.ReadLine();


        }
    }
}