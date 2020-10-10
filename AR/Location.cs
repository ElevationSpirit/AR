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
        public List<Enemy> botlist = new List<Enemy>();
        public Location(string new_locname)
        {
            loc_name = new_locname;
        }
        public void AddBot(Enemy newbot)
        {
            botlist.Add(newbot);
        }
    }
}
