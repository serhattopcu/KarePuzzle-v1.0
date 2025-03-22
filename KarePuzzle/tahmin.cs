using System;
using System.Drawing;
using System.Windows.Forms;

namespace KarePuzzle
{
    public partial class tahmin : Form
    {
        public tahmin()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string degr = comboBox1.Text;
            if ((degr == "Sincap") || (degr=="Papatya"))
            {
                label2.Text = "Tebrikler..";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Yanlış tahmin";
                label2.ForeColor = Color.Red;
            }
            degr = "";
        }
        private void tahmin_Load(object sender, EventArgs e)
        {
            OyunForm onfrm = new OyunForm();
        }
    }
}
