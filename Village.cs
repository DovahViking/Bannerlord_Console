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

        string name;
        Faction.factions faction = new Faction.factions();
        string recruit_types;
        int recruits;
        string resource_types;
        int resources;
        int location;

        public Village(string name, Faction.factions faction, string recruit_types, int recruits, string resource_types, int resources, int location)
        {
            this.name = name;
            this.faction = faction;
            this.recruit_types = Recruit_Type();
            this.recruits = recruits;
            this.resource_types = resource_types;
            this.resources = resources;
            this.location = location;
        }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nFaction: {1}\nRecruit types: {2}\nRecruits: {3}\nResource types: {4}\nResources: {5}\nLocation: {6}", name, faction, recruit_types, recruits, resource_types, resources, location);
        }

        public string Recruit_Type()
        {
            switch (faction)
            {
                case Faction.factions.Aserai:
                    return Faction.Aserai_troops.Recruit.ToString();
                case Faction.factions.Battania:
                    return Faction.Battania_troops.Volunteer.ToString();
                case Faction.factions.Calradic_Empire:
                    return Faction.Calradic_Empire_troops.Recruit.ToString();
                case Faction.factions.Khuzait:
                    return Faction.Khuzait_troops.Nomad.ToString();
                case Faction.factions.Sturgia:
                    return Faction.Sturgia_troops.Recruit.ToString();
                case Faction.factions.Vlandia:
                    return Faction.Vlandia_troops.Recruit.ToString();
                default:
                    return null;
            }
        }
    }
}
