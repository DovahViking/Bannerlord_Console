using System;

namespace Bannerlord_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Village Aab_Hon = new Village("Aab Hon", Faction.factions.Aserai, "", 0, "", 0, 1);
            Village Ab_Comer = new Village("Ab_Comer", Faction.factions.Battania, "", 0, "", 0, 35);
            Console.WriteLine(Aab_Hon);
            Console.WriteLine(Ab_Comer);
            UI user_interface = new UI();
            user_interface.Player_Location();
            user_interface.User_Interface();
        }
    }
}
