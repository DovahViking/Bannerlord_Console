using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class Village
    {
        //public string[] villages = // Test, no idea if arrays are a good idea for this, no idea when to use arrays
        //    { "Aab Hon", "Ab Comer", "Abghan", "Abou Khih", "Aegosca", "Aeoria", "Ain Baliq", "Akiser",
        //    "Alantas", "Alebat", "Alision", "Alorstan", "Alov", "Alsasos", "Amycon", "Andum", "Arpotis", "Arromanc",
        //    "Aster", "Ath Caral", "Atrion", "Avalyps" }; // to be continued.. ?

        //public enum Villages // Test, no idea if enums are a good idea for this, no idea when to use enums
        //{
        //    Aab_Hon = Faction.factions.Aserai, // Maybe do it like this??
        //    Ab_Comer, Abghan, Abou_Khih, Aegosca, Aeoria, Ain_Baliq, Akiser, Alantas, Alebat,
        //    Alision, Alorstan, Alov, Alsasos, Amycon, Andum, Arpotis, Arromanc, Aster, Ath_Caral, Atrion,
        //    Avalyps, Baq, Beglomuar, Bergum, Bir_Seif, Bog_Beth, Bryn_Glas, Bukits, Bunqaz, Caira, Caleus,
        //    Calioc, Cananc, Canoros, Canterion, Cantrec, Carphenion, Chanopsis, Chornobas, Clag_Ban,
        //    Corenia, Crios, Dalmengus, Deriah, Diantogmail, Dnin, Dradios, Druimmor, Durn, Dvorusta, Dyopalis,
        //}

        public List<Village> villages = new List<Village>();

        string name;
        public Faction.factions faction = new Faction.factions();
        string recruit_types;
        int recruits;
        string resource_types;
        int resources;
        int location;

        Faction fac = new Faction();

        public Village(string name, Faction.factions faction, string recruit_types, int recruits, string resource_types, int resources, int location)
        {
            this.name = name;
            this.faction = faction;
            this.recruit_types = Recruit_Type(fac);
            this.recruits = Troops_Amount();
            this.resource_types = resource_types;
            this.resources = resources;
            this.location = location;
            villages.Add(this);
        }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nFaction: {1}\nRecruit types: {2}\nRecruits: {3}\nResource types: {4}\nResources: {5}\nLocation: {6}", name, faction, recruit_types, recruits, resource_types, resources, location);
        }

        public string Recruit_Type(Faction fac) // ----- still need previous Tier troops to show up for each faction ----- \
        {
            switch (faction)
            {
                case Faction.factions.Aserai:
                    return fac.Recruit_Tiers(this);
                case Faction.factions.Battania:
                    return fac.Recruit_Tiers(this);
                case Faction.factions.Calradic_Empire:
                    return fac.Recruit_Tiers(this);
                case Faction.factions.Khuzait:
                    return fac.Recruit_Tiers(this);
                case Faction.factions.Sturgia:
                    return fac.Recruit_Tiers(this);
                case Faction.factions.Vlandia:
                    return fac.Recruit_Tiers(this);
                default:
                    return null;
            }
        }

        public int Troops_Amount()
        {
            Random rng_amount = new Random();

            switch (Faction.user_tier)
            {
                case 1:
                    return rng_amount.Next(0, 6);
                case 2:
                    return rng_amount.Next(0, 9);
                case 3:
                    return rng_amount.Next(0, 12);
                case 4:
                    return rng_amount.Next(0, 14);
                case 5:
                    return rng_amount.Next(0, 16);
                case 6:
                    return rng_amount.Next(0, 18);
                default:
                    return 0;
            }
        }
    }
}
