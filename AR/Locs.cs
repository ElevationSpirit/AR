using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR
{
    public class Location
    {
        public string loc_name;
        public int lvl;
        public List<Enemy> botlist = new List<Enemy>();
        public Location(string new_locname, int new_lvl)
        {
            loc_name = new_locname;
            lvl = new_lvl;
        }
        public void AddBot(Enemy newbot)
        {
            botlist.Add(newbot);
        }
        public int GetLevl()
        {
            return lvl;
        }
        public string GetName()
        {
            return loc_name;
        }

    }
}
