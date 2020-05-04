using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class UI
    {
        public void User_Interface()
        {
            bool quit = false;
            while (!quit)
            {
                ConsoleKeyInfo input = Console.ReadKey(true); // shit is bugged or something, doesn't usually do this

                // ---------- Introduction ---------- \\

                string intro = "Mount & Blade II: Consolelord";
                Console.SetCursorPosition((Console.WindowWidth - intro.Length) / 2, Console.CursorTop + 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(intro, Console.ForegroundColor);
                Console.ResetColor();
                Console.ReadLine();

                // ---------- Create a new lord ---------- \\

                Console.WriteLine("1. Create a new lord.\n");
                Console.WriteLine("2. Quit");

                if (input.Key == ConsoleKey.D1)
                {
                    Console.Write("Enter your lord's name: ");
                    string user_name = Console.ReadLine();
                    while (double.TryParse(user_name, out _))
                    {
                        Console.Write("Enter your lord's name: ");
                        user_name = Console.ReadLine();
                    }
                    Console.Write("Enter your lord's age: ");
                    string user_age = Console.ReadLine();
                    while (!int.TryParse(user_age, out _))
                    {
                        Console.Write("Enter your lord's age: ");
                        user_age = Console.ReadLine();
                    }
                    string user_faction = null;
                    Lord user_lord = new Lord(user_name, Convert.ToInt32(user_age), user_faction);

                    Console.ReadKey();
                }
                if (input.Key == ConsoleKey.D2)
                {
                    quit = true;
                }
            }
        }
    }
}
