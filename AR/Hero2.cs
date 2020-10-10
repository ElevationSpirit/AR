 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR
{
    public static class Hero
    {
        public static string name = "Владик";
        public static int dmg = 10;
        public static int lvl = 1;
        public static int hp = 100;
        public static int MaxHp = hp * GetLvl();
        public static int exp;
        public static int lvlmd = 50;
        public static int skillpoint = 5;
        public static Location location;
        public static Country country;
        public static int money = 0;
        public static double atackspeed = 3000;



        public static int GetDmg()
        {
            return dmg;
        }
        public static int GetHp()
        {
            return hp;
        }
        public static int GetMaxHp()
        {
            return MaxHp;
        }
        public static int GetLvl()
        {
            return lvl;
        }
        public static int GetMoney()
        {
            return money;
        }
        public static int GetSkill()
        {
            return skillpoint;
        }
        public static int GetExp()
        {
            return exp;
        }
        public static double GetSpeed()
        {
            if (atackspeed < 250)
            {
                atackspeed = 250;
            }
            return atackspeed;
        }
        public static int GetMD()
        {
            return lvlmd;
        }
        public static int TakeDmg(int omg)
        {
            hp -= omg;
            return hp;
        }
        public static int TakeMoney(int mon)
        {
            money -= mon;
            return money;
        }
        public static int GetExp(int expgain)
        {
            exp = exp + expgain;
            return exp;
        }
        public static int PTakeDamage(int odmg)
        {
            return hp -= odmg;
        }
        public static int LVLUP()
        {
            if (exp >= lvlmd * GetLvl())
            {
                skillpoint += 5;
                hp = MaxHp;
                exp = 0;
                return lvl = lvl + 1;
            }
            return lvl;
        }
        public static int GetDmgFromStat(int dmggain)
        {
            if (skillpoint > 0)
            {
                skillpoint -= 1;
                return dmg = dmg + dmggain;
            }
            return 0;
        }
        public static void GetHpFromButton(int hpgain)
        {
            TakeMoney((10 * lvl) / 2);
            hp = hp + (hpgain * lvl) / (3 / 2);
            hp = MaxHp;
        }

        public static double GetAttackSpeedFromStat(double asgain)
        {
            if (skillpoint > 0 && atackspeed != 250)
            {
                skillpoint -= 1;
                return atackspeed = atackspeed - asgain;
            }
            return 0;
        }
        public static int GetHpFromStat(int hpgain)
        {

            return hp = hp + hpgain;
        }

        public static void GetMaxHpFromStat(int Maxhpgain)
        {
            if (skillpoint > 0)
            {
                skillpoint -= 1;
                MaxHp = MaxHp + Maxhpgain;
                hp = MaxHp;
            }

        }
        public static void WhatUP()
        {
            if (skillpoint > 0)
            {
                GetDmgFromStat(5);
                GetAttackSpeedFromStat(100);
                GetMaxHpFromStat(50);
            }

        }
        public static void GetItem(Items items)
        {
            atackspeed -= items.GetSpeed();
            dmg += items.GetDmg();
            money -= items.GetPrice();
            MaxHp += items.GetMaxHP();
        }
        public static void KudaIdti()
        {
            for (int i = 0; i < Loc_Form.listder.Count; i++)
            {
                if (Loc_Form.listder[i].GetLevl() <= lvl)
                {
                    country = Loc_Form.listder[i];
                    for (int j = 0; j < country.curloc.Count; j++)
                    {
                        if (country.curloc[j].GetLevl() <= lvl && country.curloc[j].botlist != null)
                        {
                            location = country.curloc[j];
                        }
                    }
                }
            }
        }
        public static void WhatToBuy()
        {
            if (ItemsDB.items_in_magazin.Count != 0)
            {
                if (ItemsDB.items_in_magazin[0].GetPrice() < money)
                {
                    ItemsDB.BuyItem(ItemsDB.items_in_magazin[0]);
                }
            }

        }

        public static Location GetLoc()
        {
            return location;
        }
        public static Country GetCountry()
        {
            return country;
        }

    }
    public class Items
    {
        public string name;
        public int dmg;
        public int speed;
        public int price;
        public int maxhp;

        public Items(string name, int dmg, int speed, int price, int maxhp)
        {
            this.name = name;
            this.dmg = dmg;
            this.speed = speed;
            this.price = price;
            this.maxhp = maxhp;
        }
        public string GetName()
        {
            return name;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public int GetPrice()
        {
            return price;
        }
        public int GetMaxHP()
        {
            return maxhp;
        }
        public int GetDmg()
        {
            return dmg;
        }

    }
}









