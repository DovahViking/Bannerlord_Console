using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Timers;

namespace Bannerlord_Console
{
    class Faction
    {
        public static int user_tier = 1;

        public static void Playtime()
        {
            Timer start_time = new Timer(120000);
            start_time.Elapsed += (sender, e) => Time_Tier_Up(sender, e, start_time);
            start_time.Start();
            start_time.Enabled = true;
            start_time.AutoReset = true;
        }

        public static void Time_Tier_Up(object source, ElapsedEventArgs e, Timer start_time)
        {
            if (user_tier >= 6)
            {
                start_time.Stop();
                start_time.Enabled = false;
                start_time.AutoReset = false;
            }
            else
            {
                user_tier += 1;
                Console.WriteLine(user_tier);
            }
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

        public string Recruit_Tiers(Village vill)
        {
            if (user_tier == 1)
            {
                switch (vill.faction)
                {
                    case factions.Aserai:
                        return Aserai_troops.Recruit.ToString();
                    case factions.Battania:
                        return Battania_troops.Volunteer.ToString();
                    case factions.Calradic_Empire:
                        return Calradic_Empire_troops.Recruit.ToString();
                    case factions.Khuzait:
                        return Khuzait_troops.Nomad.ToString();
                    case factions.Sturgia:
                        return Sturgia_troops.Recruit.ToString();
                    case factions.Vlandia:
                        return Vlandia_troops.Recruit.ToString();
                    default:
                        return null;
                }
            }
            if (user_tier == 2)
            {
                switch (vill.faction)
                {
                    case factions.Aserai:
                        return $"{Aserai_troops.Tribesman.ToString()}, {Aserai_troops.Mameluke_Soldier.ToString()}";
                    case factions.Battania:
                        return $"{Battania_troops.Clan_Warrior.ToString()}, {Battania_troops.Wood_Runner.ToString()}, {Battania_troops.Highborn_Youth.ToString()}";
                    case factions.Calradic_Empire:
                        return $"{Calradic_Empire_troops.Infantryman.ToString()}, {Calradic_Empire_troops.Archer.ToString()}, {Calradic_Empire_troops.Vigla_Recruit.ToString()}";
                    case factions.Khuzait:
                        return $"{Khuzait_troops.Tribal_Warrior.ToString()}, {Khuzait_troops.Footman.ToString()}, {Khuzait_troops.Nobles_Son.ToString()}";
                    case factions.Sturgia:
                        return $"{Sturgia_troops.Warrior.ToString()}, {Sturgia_troops.Woodsman.ToString()}, {Sturgia_troops.Warrior_Son.ToString()}";
                    case factions.Vlandia:
                        return $"{Vlandia_troops.Levy_Crossbowman.ToString()}, {Vlandia_troops.Footman.ToString()}, {Vlandia_troops.Squire.ToString()}";
                    default:
                        return null;
                }
            }
            if (user_tier == 3)
            {
                switch (vill.faction)
                {
                    case factions.Aserai:
                        return $"{Aserai_troops.Skirmisher.ToString()}, {Aserai_troops.Footman.ToString()}, {Aserai_troops.Mameluke_Regular.ToString()}, {Aserai_troops.Mameluke_Axeman.ToString()}";
                    case factions.Battania:
                        return $"{Battania_troops.Trained_Warrior.ToString()}, {Battania_troops.Raider.ToString()}, {Battania_troops.Skirmisher.ToString()}, {Battania_troops.Highborn_Warrior.ToString()}";
                    case factions.Calradic_Empire:
                        return $"{Calradic_Empire_troops.Trained_Archer.ToString()}, {Calradic_Empire_troops.Trained_Archer.ToString()}, {Calradic_Empire_troops.Equite.ToString()}";
                    case factions.Khuzait:
                        return $"{Khuzait_troops.Raider.ToString()}, {Khuzait_troops.Horseman.ToString()}, {Khuzait_troops.Hunter.ToString()}, {Khuzait_troops.Spearman.ToString()}, {Khuzait_troops.Nobles_Son_T3.ToString()}";
                    case factions.Sturgia:
                        return $"{Sturgia_troops.Soldier.ToString()}, {Sturgia_troops.Brigand.ToString()}, {Sturgia_troops.Hunter.ToString()}, {Sturgia_troops.Varyag.ToString()}";
                    case factions.Vlandia:
                        return $"{Vlandia_troops.Crossbowman.ToString()}, {Vlandia_troops.Spearman.ToString()}, {Vlandia_troops.Infantry.ToString()}, {Vlandia_troops.Gallant.ToString()}";
                    default:
                        return null;
                }
            }
            if (user_tier == 4)
            {
                switch (vill.faction)
                {
                    case factions.Aserai:
                        return $"{Aserai_troops.Archer.ToString()}, {Aserai_troops.Infantry.ToString()}, {Aserai_troops.Mameluke_Cavalry.ToString()}, {Aserai_troops.Mameluke_Guard.ToString()}";
                    case factions.Battania:
                        return $"{Battania_troops.Picked_Warrior.ToString()}, {Battania_troops.Scout.ToString()}, {Battania_troops.Falxman.ToString()}, {Battania_troops.Veteran_Skirmisher.ToString()}, {Battania_troops.Hero.ToString()}";
                    case factions.Calradic_Empire:
                        return $"{Calradic_Empire_troops.Veteran_Infantryman.ToString()}, {Calradic_Empire_troops.Menavliaton.ToString()}, {Calradic_Empire_troops.Veteran_Archer.ToString()}, {Calradic_Empire_troops.Crossbowman.ToString()}, {Calradic_Empire_troops.Heavy_Horseman.ToString()}";
                    case factions.Khuzait:
                        return $"{Khuzait_troops.Horse_Archer.ToString()}, {Khuzait_troops.Lancer.ToString()}, {Khuzait_troops.Archer.ToString()}, {Khuzait_troops.Spear_Infantry.ToString()}, {Khuzait_troops.Torguud.ToString()}";
                    case factions.Sturgia:
                        return $"{Sturgia_troops.Spearman.ToString()}, {Sturgia_troops.Berserker.ToString()}, {Sturgia_troops.Hardened_Brigand.ToString()}, {Sturgia_troops.Archer.ToString()}, {Sturgia_troops.Varyag_Veteran.ToString()}";
                    case factions.Vlandia:
                        return $"{Vlandia_troops.Hardened_Crossbowman.ToString()}, {Vlandia_troops.Billman.ToString()}, {Vlandia_troops.Light_Cavalry.ToString()}, {Vlandia_troops.Swordsman.ToString()}, {Vlandia_troops.Knight.ToString()}";
                    default:
                        return null;
                }
            }
            if (user_tier == 5)
            {
                switch (vill.faction)
                {
                    case factions.Aserai:
                        return $"{Aserai_troops.Master_Archer.ToString()}, {Aserai_troops.Veteran_Infantry.ToString()}, {Aserai_troops.Mameluke_Heavy_Cavalry.ToString()}, {Aserai_troops.Mameluke_Palace_Guard.ToString()}";
                    case factions.Battania:
                        return $"{Battania_troops.Trained_Spearman.ToString()}, {Battania_troops.Horseman.ToString()}, {Battania_troops.Veteran_Falxman.ToString()}, {Battania_troops.Wildling.ToString()}, {Battania_troops.Mounted_Skirmisher.ToString()}, {Battania_troops.Fian.ToString()}";
                    case factions.Calradic_Empire:
                        return $"{Calradic_Empire_troops.Legionary.ToString()}, {Calradic_Empire_troops.Elite_Menavliaton.ToString()}, {Calradic_Empire_troops.Palatine_Guard.ToString()}, {Calradic_Empire_troops.Bucellarii.ToString()}, {Calradic_Empire_troops.Sergeant_Crossbowman.ToString()}, {Calradic_Empire_troops.Cataphract.ToString()}";
                    case factions.Khuzait:
                        return $"{Khuzait_troops.Heavy_Horse_Archer.ToString()}, {Khuzait_troops.Heavy_Lancer.ToString()}, {Khuzait_troops.Marksman.ToString()}, {Khuzait_troops.Darkhan.ToString()}, {Khuzait_troops.Kheshig.ToString()}";
                    case factions.Sturgia:
                        return $"{Sturgia_troops.Shock_Troop.ToString()}, {Sturgia_troops.Veteran_Warrior.ToString()}, {Sturgia_troops.Ulfhednar.ToString()}, {Sturgia_troops.Horse_Raider.ToString()}, {Sturgia_troops.Veteran_Bowman.ToString()}, {Sturgia_troops.Druzhinnik.ToString()}";
                    case factions.Vlandia:
                        return $"{Vlandia_troops.Sharpshooter.ToString()}, {Vlandia_troops.Voulgier.ToString()}, {Vlandia_troops.Pikeman.ToString()}, {Vlandia_troops.Vanguard.ToString()}, {Vlandia_troops.Sergeant.ToString()}, {Vlandia_troops.Champion.ToString()}";
                    default:
                        return null;
                }
            }
            if (user_tier == 6)
            {
                switch (vill.faction)
                {
                    case factions.Aserai:
                        return null;
                    case factions.Battania:
                        return $"{Battania_troops.Fian_Champion.ToString()}";
                    case factions.Calradic_Empire:
                        return $"{Calradic_Empire_troops.Elite_Cataphract.ToString()}";
                    case factions.Khuzait:
                        return $"{Khuzait_troops.Khans_Guard.ToString()}";
                    case factions.Sturgia:
                        return $"{Sturgia_troops.Druzhinnik_Champion.ToString()}";
                    case factions.Vlandia:
                        return $"{Vlandia_troops.Banner_Knight.ToString()}";
                    default:
                        return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
