namespace iksz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char iksz = 'x';
            int x = 0;
            int y = 0;
            int kozep_x = Console.WindowWidth / 2;
            int kozep_y = Console.WindowHeight / 2;
            Console.SetCursorPosition(kozep_x, kozep_y);
            Console.WriteLine(iksz);

            while (x != kozep_x * 2 && y != kozep_y * 2)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(iksz);

                x+= 4;
                y++;
            }

        }
    }
}