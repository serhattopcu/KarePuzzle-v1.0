using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace KarePuzzle

{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

      //------<-<------------Giriş form tanımlamalar------------------------
        public string cinsiyet = "",yas="";
        public static string isim = "";
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath+"/usersdb.mdb");
        public bool girisKontrol = false;
      
      //------------------------------------------------------------>->------

        private void btn_kız_Click(object sender, EventArgs e)
        {
            cinsiyet = "Kız";
            this.BackgroundImage = Properties.Resources.mavi;
            btn_kız.BackgroundImage = Properties.Resources.k2;
            btn_erkek.BackgroundImage = Properties.Resources.e1;
        }
        private void btn_erkek_Click_1(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
            this.BackgroundImage = Properties.Resources.mavi;
            btn_erkek.BackgroundImage = Properties.Resources.e2;
            btn_kız.BackgroundImage = Properties.Resources.k1;
        }
        private void GirisForm_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.Control)&(e.Shift)&( e.KeyCode == Keys.Y))
            {
                DialogResult gecis = MessageBox.Show("Yetkili moda geçis yapmak için Tamam'a tıklayınız.", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (gecis == DialogResult.OK)
                {
                    YetkiliGirisForm ygf = new YetkiliGirisForm();
                    ygf.Show();
                    this.Hide();
                }   
            }
        }

        private void tx_isim_Click(object sender, EventArgs e)
        {
            tx_isim.Text = "";
            this.BackgroundImage = Properties.Resources.kırmızı;
        }

       

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbx_yas_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.yesil;
        }
       

        private void btn_giris_MouseMove(object sender, MouseEventArgs e)
        {
           this.BackgroundImage = Properties.Resources.turuncu;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            yas = Convert.ToString(cbx_yas.SelectedItem);
            isim = tx_isim.Text;
            if ((isim!= "") && (yas!="") && (cinsiyet!= ""))
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("INSERT INTO Users(KullanıcıAdı,Yas,Cinsiyet)VALUES('"+isim+"','"+Convert.ToInt16(yas)+"','"+cinsiyet+"')",baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    girisKontrol = true;
                    OyunForm of = new OyunForm();
                    this.Hide();
                    of.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Bilgileri eksik ya da hatalı girdiniz.Lütfen tekrar deneyiniz!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Information);
                tx_isim.Text = "";   cbx_yas.Text = "";  isim = "";    cinsiyet = "";   yas = "";
            }
            
            
        }
    }
}