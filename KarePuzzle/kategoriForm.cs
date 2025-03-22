using System;
using System.Windows.Forms;

namespace KarePuzzle
{
    public partial class kategoriForm : Form
    {
        public kategoriForm()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_ktgri_hayvan_Click(object sender, EventArgs e)
        {
           OyunForm.secilen = "Hayvanlar | Animals";
            this.Hide();
          
        }

        private void kategoriForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           // MessageBox.Show(secilen);
        }
       
        private void kategoriForm_Load(object sender, EventArgs e)
        {
           label2.Text = Convert.ToString(GirisForm.isim);
        }

        private void btn_kategori2_Click(object sender, EventArgs e)
        {
           
            OyunForm.secilen  = "Bitkiler | Plants";
            this.Hide();
           
        }

        private void btn_kategori3_Click(object sender, EventArgs e)
        {
            //secilen = "Uzay | Space";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // secilen = "Böcekler | Insects";
            this.Close();
        }
    }
}
