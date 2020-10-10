using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AR
{
    public partial class Dom_House : Form
    {

        public Dom_House()
        {
            InitializeComponent();
            ItemsDB.ListItems();
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dead_Form de = new Dead_Form();
            Portal port = new Portal();
            timer1.Enabled = false;
            if (A_on.Checked == false)
            {
                port.timer1.Enabled = false;
                if (Hero.hp <= 20 && Hero.money == 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    this.Hide();
                    de.ShowDialog();
                }
            }
            port.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.ShowDialog();
            timer1.Enabled = false;
        }
        private void HPBuy_Click(object sender, EventArgs e)
        {
            Hero.TakeMoney((10 * Hero.lvl) / 2);
            Hero.GetHpFromButton(50);

            Updatu();
        }

        public void Updatu()
        {
            double tmpas = Convert.ToDouble(Hero.GetSpeed());

            groupBox1.Text = "Текущий уровень — " + Hero.GetLvl();
            textBox1.Text = Hero.GetHp() + "/" + Hero.GetMaxHp();
            listBox1.Items.Clear();
            textBox2.Text = Hero.GetDmg().ToString();
            textBox3.Text = Hero.GetSpeed().ToString();
            textBox4.Text = Hero.GetMoney().ToString();
            textBox5.Text = Hero.GetSkill().ToString();
            textBox6.Text = Hero.GetExp() + "/" + Hero.GetLvl() * Hero.GetMD();
            HPBuy.Text = "Восполнить здоровье за " + ((10 * Hero.lvl) / 2) + " Золота";
            if (Hero.GetSkill() > 0)
            {
                DmgGain.Visible = true;
                HPgain.Visible = true;
                ASpeedGain.Visible = true;
            }
            else
            {
                DmgGain.Visible = false;
                HPgain.Visible = false;
                ASpeedGain.Visible = false;
            }
            if (Hero.money < ((10 * Hero.lvl)/ 2) | Hero.hp == Hero.MaxHp)
            {
                HPBuy.Enabled = false;
            }
            else
            {
                HPBuy.Enabled = true;
            }

            for (int i = 0; i < ItemsDB.items_in_invintarb.Count; i++)
            {
                listBox1.Items.Add(ItemsDB.items_in_invintarb[i].GetName());
            }
           
        }
        private void A_on_CheckedChanged(object sender, EventArgs e)
        {
            if (A_on.Checked == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }
        private void HPgain_Click(object sender, EventArgs e)
        {
            
            Hero.GetMaxHpFromStat(15);
            
            Updatu();
        }
       
        private void DmgGain_Click(object sender, EventArgs e)
        {
            Hero.GetDmgFromStat(5);
            Updatu();
        }

        private void ASpeedGain_Click(object sender, EventArgs e)
        {
            Hero.GetAttackSpeedFromStat(50);
            Updatu();
        }

        private void Dom_House_Load(object sender, EventArgs e)
        {
            A_on.Checked = false;
            Updatu();
            Loc_Form.StarGame();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dead_Form df = new Dead_Form();
            if (A_on.Checked == true)
            {
                if (Hero.hp <= 20 && Hero.money == 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    this.Hide();
                    df.ShowDialog();
                }
                if (Hero.hp <= 20)
                {
                    HPBuy_Click(sender, e);
                }
                Hero.WhatUP();
                if (Hero.GetSkill() == 0)
                {
                    button1_Click(sender, e); 
                }
               
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Updatu();
            Hero.KudaIdti();
            Hero.WhatToBuy();
        }

        

        private void Dom_House_Activated(object sender, EventArgs e)
        {
            if (A_on.Checked == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

    }
}
