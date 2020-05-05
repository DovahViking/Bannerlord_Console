using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class Faction
    {
        public enum factions
        {
            Aserai,
            Battania,
            Khuzait,
            Northern_Empire,
            Southern_Empire,
            Sturgia,
            Vlandia,
            Western_Empire
        }
        enum Aserai_troops
        {
            Recruit, // Tier 1
            Tribesman, Mameluke_Soldier, // Tier 2
            Skirmisher, Footman, Mameluke_Regular, Mameluke_Axeman, // Tier 3
            Archer, Infantry, Mameluke_Cavalry, Mameluke_Guard, // Tier 4
            Master_Archer, Veteran_Infantry, Mameluke_Heavy_Cavalry, Mameluke_Palace_Guard // Tier 5
        }
    }
}
