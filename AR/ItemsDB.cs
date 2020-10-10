using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR
{
    public static class ItemsDB
    {
        public static List<Items> items_in_magazin = new List<Items>();
        public static List<Items> items_in_invintarb = new List<Items>();

        public static void ListItems()
        {
            items_in_magazin.Add(new Items("Меч павшего дипломника", 10, 0, 400, 100));
            items_in_magazin.Add(new Items("Лук страдальца на пересдаче", 25, 20, 1500, 0));
            items_in_magazin.Add(new Items("Убийца зачеток", 40, 0, 5000, 0));
            items_in_magazin.Add(new Items("Посох уборщицы", 100, 50, 12000, 200));
            items_in_magazin.Add(new Items("Ярость башкира", 1000, 100, 100000, 400));

        }

        public static void BuyItem(Items item)
        {
            items_in_invintarb.Add(item);
            items_in_magazin.Remove(item);
            Hero.GetItem(item);
        }
    }
}
