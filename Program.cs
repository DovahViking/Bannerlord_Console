using System;

namespace Bannerlord_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                ConsoleKeyInfo input = Console.ReadKey(true); // Behaves like it should

                if (input.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("1aaaaaaaaaaaaa");
                }
                if (input.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("2bbbbbbbbbbbb");
                }
                if (input.Key == ConsoleKey.Q)
                {
                    quit = true;
                }
            }

            UI user_interface = new UI();
            user_interface.User_Interface();
        }
    }
}
