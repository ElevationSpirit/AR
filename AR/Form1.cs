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
    public partial class Form1 : Form
    {
        public Location curloc;
        public Dom_House dom = new Dom_House();
        public Country country;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Loc_Form.StarGame();
            for (int i = 0; i < curloc.botlist.Count; i++)
            {
                listBox1.Items.Add(curloc.botlist[i].name);
            }
            Hero_Atack.Interval = Convert.ToInt32(Hero2.GetSpeed());
            Enemy_Atack.Interval = Convert.ToInt32(curloc.botlist[0].GetSpeed());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (curloc.botlist[0].hp <= 0)
                {
                    listBox2.TopIndex = listBox2.Items.Add(string.Format("{0} побежден", curloc.botlist[0].name));
                    Hero2.GetExp(curloc.botlist[0].GetExpReward());
                    Hero2.LVLUP();
                    Hero2.money += curloc.botlist[0].GetMoneyReward();
                    curloc.botlist.RemoveAt(0);
                    listBox1.Items.RemoveAt(0);
                }
                if (Hero2.hp <= 20)
                {
                    Hero2.hp = Hero2.MaxHp / 50;    
                    
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                
                timer1.Enabled = false;
                listBox2.TopIndex = listBox2.Items.Add("Все враги на локации побеждены");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                curloc.botlist[0].TakeDMG();
                listBox2.TopIndex = listBox2.Items.Add(string.Format(" {0} поймал маслину , осталось {1} ХП!", curloc.botlist[0].name, curloc.botlist[0].hp));
                
            }
            catch
            {
                DialogResult = DialogResult.OK;
                Hero_Atack.Enabled = false;
            }
        }

        private void Enemy_Atack_Tick(object sender, EventArgs e)
        {
            try
            {
                Hero2.PTakeDamage(curloc.botlist[0].GetDMG());
                listBox2.TopIndex = listBox2.Items.Add(string.Format(" {0} поймал маслину , осталось {1} ХП!", Hero2.name, Hero2.hp));
            }
            catch
            {

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Application.OpenForms["Dom_House"] as Dom_House).Updatu();
            timer1.Enabled = false;
            timer2.Enabled = false;
            Enemy_Atack.Enabled = false;
            Hero_Atack.Enabled = false;
            
        }

       
    }
}
