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
    public partial class Shop : Form
    {
        public Dom_House dom = new Dom_House();
        public Portal port = new Portal();    
        
        public Shop()
        {
            port.timer1.Enabled = false;
            InitializeComponent();
          
            for (int i = 0; i < ItemsDB.items_in_magazin.Count; i++)
            {
                listBox1.Items.Add(ItemsDB.items_in_magazin[i].GetName());
            }
            
        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            dom.Activate();
            for (int i = 0; i < ItemsDB.items_in_magazin.Count; i++)
            {
                listBox1.Items.Remove(ItemsDB.items_in_magazin[i].GetName());
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
                if (Hero.money < ItemsDB.items_in_magazin[listBox1.SelectedIndex].GetPrice())
                {
                    MessageBox.Show("Нет денег");
                }
                else
                {
                    Hero.GetItem(ItemsDB.items_in_magazin[listBox1.SelectedIndex]);
                }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = ItemsDB.items_in_magazin[listBox1.SelectedIndex].GetName();
                textBox2.Text = ItemsDB.items_in_magazin[listBox1.SelectedIndex].GetPrice().ToString();
                richTextBox1.Text = "Урон +" + ItemsDB.items_in_magazin[listBox1.SelectedIndex].GetDmg() + "\n" + "Скорость атаки +" + ItemsDB.items_in_magazin[listBox1.SelectedIndex].GetSpeed() + "\n" + "Здоровье +" + ItemsDB.items_in_magazin[listBox1.SelectedIndex].GetMaxHP();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
      
    }
}
