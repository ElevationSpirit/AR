using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR
{
    public static class Loc_Form
    {
        public static List<Country> listder;

        public static void StarGame()
        {

            listder = new List<Country>();
            Country d1 = new Country("Касли", true, 1);
            listder.Add(d1);

            Location l1 = new Location("Частный сектор", 1);
            d1.AddLoc(l1);

            for (int i = 0; i < 5; i++)
            {
                l1.AddBot(new Enemy("Гопники: " + i, 10, 100, 10, 5, 3000, 1));
            }

            Location l2 = new Location("Центр города", 5);
            d1.AddLoc(l2);

            for (int i = 0; i < 5; i++)
            {
                l2.AddBot(new Enemy("Менты: " + i, 40, 100, 25, 20, 2500, 5));
            }

            Country d2 = new Country("Челябинск", true, 15);
            listder.Add(d2);

            Location l3 = new Location("Шарага", 15);
            d2.AddLoc(l3);

            for (int i = 0; i < 5; i++)
            {
                l3.AddBot(new Enemy("Гопник" + i, 50, 500, 40, 25, 2200, 15));
            }

            Location l4 = new Location("Столовка", 30);
            d2.AddLoc(l4);

            for (int i = 0; i < 5; i++)
            {
                l4.AddBot(new Enemy("Повара" + i, 100, 1500, 100, 50, 1700, 30));
            }

        }

        public static List<string> GetDerName()
        {
            List<string> tmp = new List<string>();
            for (int i = 0; i < listder.Count; i++)
            {
                tmp.Add(listder[i].namesd);
            }
            return tmp;
        }

        public static List<string> GetLocName(int derevna_id)
        {
            List<string> tmp = new List<string>();
            for (int i = 0; i < listder[derevna_id].curloc.Count; i++)
            {
                tmp.Add(listder[derevna_id].curloc[i].loc_name);
            }
            return tmp;
        }

        public static Location GetLocl(int der_id, int loc_id)
        {
            return listder[der_id].curloc[loc_id];
        }
    }
}
