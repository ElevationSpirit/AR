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
            Country d1 = new Country("Касли", true);
            listder.Add(d1);

            Location l1 = new Location("Частный сектор");
            d1.AddLoc(l1);

            for (int i = 0; i < 5; i++)
            {
                l1.AddBot(new Enemy("Гопники" + i, 5, 10, 10, 5,3000));
            }

            Location l2 = new Location("Центр города");
            d1.AddLoc(l2);

            for (int i = 0; i < 5; i++)
            {
                l2.AddBot(new Enemy("Менты: " + i,20, 15, 25,20,2500));
            }

            Country d2 = new Country("Челябинск", true);
            listder.Add(d2);

            Location l3 = new Location("Шарага");
            d2.AddLoc(l3);

            for (int i = 0; i < 5; i++)
            {
                l3.AddBot(new Enemy("Гопник" + i, 10, 15,40,25,2200));
            }

            Location l4 = new Location("Столовка");
            d2.AddLoc(l4);

            for (int i = 0; i < 5; i++)
            {
                l4.AddBot(new Enemy("Повара" + i, 25, 50,100,50,1700));
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

        public static Location GetLoc(int der_id, int loc_id)
        {
            return listder[der_id].curloc[loc_id];
        }
    }
}
