using System;

namespace Bannerlord_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- Instead of making 100s of villages manually, use a loop ---------- \\
            Village Aab_Hon = new Village("", Faction.factions.Aserai, "", 0, "", 0, 1);
            Village Ab_Comer = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer1 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer2 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer3 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer4 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer5 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer6 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer7 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer8 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer9 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Village Ab_Comer0 = new Village("", Faction.factions.Battania, "", 0, "", 0, 35);
            Console.WriteLine(Aab_Hon);
            Console.WriteLine(Ab_Comer);
            Console.WriteLine(Ab_Comer1);
            Console.WriteLine(Ab_Comer2);
            Console.WriteLine(Ab_Comer3);
            Console.WriteLine(Ab_Comer4);
            Console.WriteLine(Ab_Comer5);
            Console.WriteLine(Ab_Comer6);
            Console.WriteLine(Ab_Comer7);
            Console.WriteLine(Ab_Comer8);
            Console.WriteLine(Ab_Comer9);
            Console.WriteLine(Ab_Comer0);


            UI user_interface = new UI();
            Faction.Playtime();
            user_interface.User_Interface();
        }
    }
}
