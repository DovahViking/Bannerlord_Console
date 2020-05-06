using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class UI
    {
        string location = null;
        string first_location = null;
        string second_location = null;
        string third_location = null;
        string fourth_location = null;
        public void User_Interface()
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

                    Console.ReadKey();
                }
                if (input.Key == ConsoleKey.D2)
                {
                    quit = true;
                }
            }
        }

        public void Player_Location()
        {
            if (location == null)
            {
                location = "Training Grounds";
            }
            else
            {
                
            }

            Console.WriteLine($"\nLocation: {location}");
        }

        public void Available_Locations()
        {
            // Adjacent village locations
            // Something like 4 different adjacent locations
            // If a village has the location 35, then its adjacent locations would be 33, 34, 36, 37, which you can travel to
        }
    }
}
