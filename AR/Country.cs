using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR
{
    public class Country
    {
        public string namesd;
        public int lvl;
        public bool haveshop = true;
        public List<Location> curloc = new List<Location>();
        public Country(string new_nameloc, bool shop, int new_lvl)
        {
            haveshop = shop;
            namesd = new_nameloc;
            lvl = new_lvl;

        }
        public void AddLoc(Location newloc)
        {
            curloc.Add(newloc);
        }
        public int GetLevl()
        {
            return lvl;
        }
        public string GetLocName()
        {
            return namesd;
        }
    }
}
