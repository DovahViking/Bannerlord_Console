using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class Village
    {
        // Instead of making an array with ALL villages and
        // instead of making an enum with ALL villages and assigning factions to them there
        // I thought making arrays with villages for each faction would be the most efficient

        string[] aserai_villages =
        {
            "Aab Hon", "Abghan", "Abou Khih", "Ain Baliq", "Baq", "Bir Seif", "Bunqaz", "Ezbet Nahul", "Fanab",
            "Hamoshawat", "Hiblet", "Hoqqa", "Ismaily", "Jahasim", "Kuqa", "Lamesa", "Mabwaz", "Medim", "Mijayit",
            "Mossom", "Nahlan", "Qablab", "Qednar", "Sahel", "Shibal Zumr", "Tasheba", "Tubilis", "Uqba", "Wadar", "Zalm"
        };

        string[] battania_villages =
        {
            "Ab Comer", "Andum", "Aster", "Ath Caral", "Beglomuar", "Bog Beth", "Bryn Glas", "Cantrec", "Clag Ban",
            "Dalmengus", "Diantogmail", "Druimmor", "Durn", "Ebereth", "Fenon Tryn", "Flintolg", "Gainseth", "Glenlithrig",
            "Glintor", "Imlagh", "Inveth", "Lindorn", "Llanoc Hen", "Mag Arba", "Morihig", "Pendraic", "Pennit Nal",
            "Rhemtoil", "Seordas", "Swenrin", "Tor Leiad", "Tor Melina", "Uthelaim"
        };

        string[] khuzait_villages =
        {
            "Akiser", "Gereden", "Hanekhy", "Ispantar", "Karakalat", "Kiraz", "Makeb", "Mazen",
            "Mivanjan", "Omrotok", "Pabastan", "Ransam", "Shapeshte", "Simira", "Tismirr", "Ulaan", "Okhutan", "Urunjan"
        };

        string[] northern_empire_villages =
        {
            "Acragora", "Aeoria", "Agalmon", "Alatys", "Alosea", "Ataconia", "Atrion", "Avasinton", "Crios", "Dyopalis",
            "Epinosa", "Enosia", "Gaos", "Gymos", "Hetania", "Jeracos", "Lochana", "Marathea", "Masangara",
            "Mecalovea", "Nortanisa", "Orthra", "Pons", "Potamis", "Rhesos", "Samatha", "Stathymos", "Syratos",
            "Temhem", "Themys", "Varagos", "Vealos"
        };

        string[] southern_empire_villages =
        {
            "Alision", "Amycon", "Atphynia", "Avalyps", "Caira", "Canoros", "Canterion", "Chanopsis", "Corenia",
            "Erebulos", "Ethemisa", "Eunalica", "Gorcorys", "Jogurys", "Lanthas", "Lartusys", "Melion", "Metachia", "Morenia",
            "Odrysa", "Parasemnos", "Polisia", "Popsia", "Psotai", "Sagolina", "Sagora", "Saldannis",
            "Sestadeim", "Spotia", "Tevea", "Vargornis", "Zestea"
        };

        string[] sturgia_villages =
        {
            "Alebat", "Alov", "Borchovagorka", "Bukits", "Chornobas", "Dnin", "Dvorusta", "Ferth", "Forin",
            "Glavstrom", "Ismilkorg", "Karbur", "Kargrev", "Korsyas", "Kranirog", "Kvol", "Mazhadan", "Marabrot",
            "Nevyansk", "Omkany", "Ov", "Radakmed", "Rodobas", "Safna", "Skorin", "Takor", "Urikskala", "Ustokol",
            "Visibrot", "Vladiv", "Yangutum", "Zhemyan"
        };

        string[] vlandia_villages =
        {
            "Alantas", "Alorstan", "Arromanc", "Caleus", "Calioc", "Cananc", "Chornad", "Drapand", "Deriat", "Etirburg",
            "Ferton", "Fregian", "Furbec", "Halisvust", "Hongard", "Horsger", "Larnac", "Mareiven", "Marin", "Meroc", "Mot",
            "Nogrent", "Oritan", "Ormanfard", "Palisona", "Rodetan", "Remental", "Rulund", "Savinth", "Sirindac",
            "Talivel", "Tirby", "Usanc", "Valanby", "Verecsand", "Vesin"
        };

        string[] western_empire_villages =
        {
            "Aegosca", "Alsasos", "Arpotis", "Bergum", "Carphenion", "Dradios", "Elvania", "Elipa", "Gamardan",
            "Garontor", "Gersegos", "Goleryn", "Garengolia", "Hertogea", "Leblenion", "Lysia", "Montos",
            "Neocorys", "Nideon", "Onica", "Oristocorys", "Phasos", "Primessos", "Tarcutis", "Thersenion", "Thorios",
            "Thractorae", "Vathea", "Veron", "Vinela", "Zeocorys"
        };

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
