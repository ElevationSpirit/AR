using System.Windows.Forms;

namespace AR
{
    public partial class Dead_Form : Form
    {
        public Dead_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }
    }
}
