using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class Faction
    {
        public int Player_Tier()
        {
            int user_tier = 1;
            // if something something
            return user_tier;
        }

        public enum factions
        {
            Aserai,
            Battania,
            Khuzait,
            Northern_Empire,
            Southern_Empire,
            Sturgia,
            Vlandia,
            Western_Empire,
            Calradic_Empire = Northern_Empire + Southern_Empire + Western_Empire
        }
        public enum Aserai_troops
        {
            Recruit, // Tier 1
            Tribesman, Mameluke_Soldier, // Tier 2
            Skirmisher, Footman, Mameluke_Regular, Mameluke_Axeman, // Tier 3
            Archer, Infantry, Mameluke_Cavalry, Mameluke_Guard, // Tier 4
            Master_Archer, Veteran_Infantry, Mameluke_Heavy_Cavalry, Mameluke_Palace_Guard // Tier 5
        }

        public enum Battania_troops
        {
            Volunteer, // Tier 1
            Clan_Warrior, Wood_Runner, Highborn_Youth, // Tier 2
            Trained_Warrior, Raider, Skirmisher, Highborn_Warrior, // Tier 3
            Picked_Warrior, Scout, Falxman, Veteran_Skirmisher, Hero, // Tier 4
            Trained_Spearman, Horseman, Veteran_Falxman, Wildling, Mounted_Skirmisher, Fian, // Tier 5
            Fian_Champion // Tier 6
        }

        public enum Calradic_Empire_troops // All 3 Empire factions share this
        {
            Recruit, // Tier 1
            Infantryman, Archer, Vigla_Recruit, // Tier 2
            Trained_Infantryman, Trained_Archer, Equite, // Tier 3
            Veteran_Infantryman, Menavliaton, Veteran_Archer, Crossbowman, Heavy_Horseman, // Tier 4
            Legionary, Elite_Menavliaton, Palatine_Guard, Bucellarii, Sergeant_Crossbowman, Cataphract, // Tier 5
            Elite_Cataphract // Tier 6
        }

        public enum Khuzait_troops
        {
            Nomad, // Tier 1
            Tribal_Warrior, Footman, Nobles_Son, // Tier 2
            Raider, Horseman, Hunter, Spearman, Nobles_Son_T3, // Tier 3
            Horse_Archer, Lancer, Archer, Spear_Infantry, Torguud, // Tier 4
            Heavy_Horse_Archer, Heavy_Lancer, Marksman, Darkhan, Kheshig, // Tier 5
            Khans_Guard // Tier 6
        }

        public enum Sturgia_troops
        {
            Recruit, // Tier 1
            Warrior, Woodsman, Warrior_Son, // Tier 2
            Soldier, Brigand, Hunter, Varyag, // Tier 3
            Spearman, Berserker, Hardened_Brigand, Archer, Varyag_Veteran, // Tier 4
            Shock_Troop, Veteran_Warrior, Ulfhednar, Horse_Raider, Veteran_Bowman, Druzhinnik, // Tier 5
            Druzhinnik_Champion // Tier 6
        }

        public enum Vlandia_troops
        {
            Recruit, // Tier 1
            Levy_Crossbowman, Footman, Squire, // Tier 2
            Crossbowman, Spearman, Infantry, Gallant, // Tier 3
            Hardened_Crossbowman, Billman, Light_Cavalry, Swordsman, Knight, // Tier 4
            Sharpshooter, Voulgier, Pikeman, Vanguard, Sergeant, Champion, // Tier 5
            Banner_Knight // Tier 6
        }
    }
}
