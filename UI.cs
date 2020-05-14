using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class UI
    {
        int location = 0;

        public void User_Interface(Village village)
        {
            bool quit = false;
            while (!quit)
            {
                // ---------- Introduction ---------- \\

                string intro = "Mount & Blade II: Consolelord";
                Console.SetCursorPosition((Console.WindowWidth - intro.Length) / 2, Console.CursorTop + 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(intro, Console.ForegroundColor);
                Console.ResetColor();
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();

                // ---------- Create a new lord ---------- \\

                Console.WriteLine("1. Create a new lord.\n");
                Console.WriteLine("2. Quit");

                ConsoleKeyInfo input = Console.ReadKey(true); // Has to be placed right before the inputs, no prints allowed in between

                if (input.Key == ConsoleKey.D1)
                {
                    Console.Write("Enter your lord's name: ");
                    string user_name = Console.ReadLine();
                    while (double.TryParse(user_name, out _) || user_name == "")
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

                    Player_Location(village);

                    Console.ReadKey();
                }
                if (input.Key == ConsoleKey.D2)
                {
                    quit = true;
                }
            }
        }

        public void Player_Location(Village village)
        {
            string location_name;

            if (location == 0)
            {
                location_name = "Training grounds";
            }
            else
            {
                location = village.location;
                location_name = village.name;
            }

            Console.WriteLine($"Location: {location_name}");
        }

        public void Available_Locations(int first, int second, int third, int fourth)
        {
            // Adjacent village locations
            // Something like 4 different adjacent locations
            // If a village has the location 35, then its adjacent locations would be 33, 34, 36, 37, which you can travel to

            first = location - 2;
            second = location - 1;
            third = location + 1;
            fourth = location + 2;
        }
    }
}
