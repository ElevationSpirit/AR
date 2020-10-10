using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR
{
    public class Enemy
    {

        public string name;
        public int dmg;
        public int hp;
        public int money;
        public int exp;
        public double speed;
        public int lvligrat;
        public Enemy(string new_name, int new_dmg, int new_hp, int new_exp, int new_money, double new_speed, int new_lvligrat)
        {
            this.name = new_name;
            this.dmg = new_dmg;
            this.hp = new_hp;
            this.exp = new_exp;
            this.money = new_money;
            this.speed = new_speed;
            this.lvligrat = new_lvligrat;
        }
        public virtual int TakeDMG()
        {
            hp -= Hero.GetDmg();
            return hp;
        }
        public virtual int GetDMG()
        {
            return this.dmg;
        }
        public virtual int GetExpReward()
        {
            return this.exp;
        }
        public virtual int GetMoneyReward()
        {
            return this.money;
        }
        public virtual double GetSpeed()
        {
            return this.speed;
        }
        public virtual int GetLvligrat()
        {
            return lvligrat;
        }

    }

}
