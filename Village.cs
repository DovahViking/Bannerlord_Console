using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class Village
    {
        public string[] villages = // Test, no idea if arrays are a good idea for this, no idea when to use arrays
            { "Aab Hon", "Ab Comer", "Abghan", "Abou Khih", "Aegosca", "Aeoria", "Ain Baliq", "Akiser",
            "Alantas", "Alebat", "Alision", "Alorstan", "Alov", "Alsasos", "Amycon", "Andum", "Arpotis", "Arromanc",
            "Aster", "Ath Caral", "Atrion", "Avalyps" }; // to be continued.. ?

        public enum Villages // Test, no idea if enums are a good idea for this, no idea when to use enums
        {
            Aab_Hon = Faction.factions.Aserai, // Maybe do it like this??
            Ab_Comer, Abghan, Abou_Khih, Aegosca, Aeoria, Ain_Baliq, Akiser, Alantas, Alebat,
            Alision, Alorstan, Alov, Alsasos, Amycon, Andum, Arpotis, Arromanc, Aster, Ath_Caral, Atrion,
            Avalyps, Baq, Beglomuar, Bergum, Bir_Seif, Bog_Beth, Bryn_Glas, Bukits, Bunqaz, Caira, Caleus,
            Calioc, Cananc, Canoros, Canterion, Cantrec, Carphenion, Chanopsis, Chornobas, Clag_Ban,
            Corenia, Crios, Dalmengus, Deriah, Diantogmail, Dnin, Dradios, Druimmor, Durn, Dvorusta, Dyopalis,
        }

        string recruit_types;
        int recruits;
        string resource_types;
        int resources;

        public Village(string[] name, string recruit_types, int recruits, string resource_types, int resources)
        {
            this.villages = name;
            this.recruit_types = recruit_types;
            this.recruits = recruits;
            this.resource_types = resource_types;
            this.resources = resources;
        }
    }
}
