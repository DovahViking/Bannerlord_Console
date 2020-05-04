using System;
using System.Collections.Generic;
using System.Text;

namespace Bannerlord_Console
{
    class Lord
    {
        List<Lord> Lords = new List<Lord>();

        string lord_name;
        int lord_age;
        string lord_faction;
        public Lord(string lord_name, int lord_age, string lord_faction)
        {
            this.lord_name = lord_name;
            this.lord_age = lord_age;
            this.lord_faction = lord_faction;
            Lords.Add(this);
        }

        public void Get_Lords()
        {
            foreach (Lord lord in Lords)
            {
                Console.WriteLine($"Lords: {lord}");
            }
        }

        public override string ToString()
        {
            return string.Format(lord_name, lord_age, lord_faction);
        }
    }
}
