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
    public partial class Portal : Form
    {
        public Country listder;
        public Location curloc;
        
        public Portal()
        {
            InitializeComponent();
        }

        private void dombutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < Loc_Form.listder[comboBox1.SelectedIndex].curloc.Count; i++)
            {
                comboBox2.Items.Add(Loc_Form.listder[comboBox1.SelectedIndex].curloc[i].GetName());
            }
        }   

        private void button1_Click(object sender, EventArgs e)
        {
                timer1.Enabled = false;
                Form1 LF = new Form1();
                LF.country = Loc_Form.listder[comboBox1.SelectedIndex];
                LF.curloc = Loc_Form.listder[comboBox1.SelectedIndex].curloc[comboBox2.SelectedIndex];
                LF.ShowDialog(this);
                this.Close();
        }
        public void timer1_Tick(object sender, EventArgs e)
        {           
            comboBox2.Items.Clear();
            comboBox1.SelectedIndex = Loc_Form.listder.IndexOf(Hero.GetCountry());
            comboBox2.SelectedIndex = Hero.GetCountry().curloc.IndexOf(Hero.GetLoc());
            timer1.Enabled = false;
            button1_Click(sender, e);
        }

        private void Portal_Activated(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < Loc_Form.listder.Count; i++)
            {
                comboBox1.Items.Add(Loc_Form.listder[i].GetLocName());
            }
        }
    }
}
