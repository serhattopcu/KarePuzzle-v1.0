using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KarePuzzle
{
    public partial class YetkiliGirisForm : Form
    {
        public YetkiliGirisForm()
        {
            InitializeComponent();
        }

      //------<-<------------Yetkili Giriş form tanımlamalar------------------------------------//
        GirisForm grsfrm = new GirisForm();
        OleDbConnection baglanti2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath+"/superUserDB.mdb");
        public string parola, parolaKont, yetkiliAdi, meslek, eposta;
        //------------------------------------------------------------------------------->->-------//
        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 393;
        }

        private void btn_onayla_MouseMove(object sender, MouseEventArgs e)
        {
            btn_onayla.BackgroundImage = Properties.Resources.onay2;
        }
        private void btn_onayla_MouseLeave(object sender, EventArgs e)
        {
            btn_onayla.BackgroundImage = Properties.Resources.onay1;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.vazgec2;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.vazgec1;
        }

        private void btn_ykayit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_ykayit.BackgroundImage = Properties.Resources.kayıt2;
        }
        private void btn_ykayit_MouseLeave(object sender, EventArgs e)
        {
            btn_ykayit.BackgroundImage = Properties.Resources.kayıt1;
        }

        private void btn_ygiris_MouseMove(object sender, MouseEventArgs e)
        {
            btn_ygiris.BackgroundImage = Properties.Resources.giris2;
        }
        private void btn_ygiris_MouseLeave(object sender, EventArgs e)
        {
            btn_ygiris.BackgroundImage = Properties.Resources.giris1;
        }


        private void btn_ygiris_Click(object sender, EventArgs e)               // Yetkili giriş
        {
            if ((tx_giris_yAdi.Text != "") & (tx_giris_prl.Text != ""))
            {
                if (baglanti2.State == ConnectionState.Closed) baglanti2.Open();
                OleDbCommand komut3 = new OleDbCommand("SELECT *FROM yetkili_bilgileri WHERE Yetkili_Adi='" + tx_giris_yAdi.Text + "'AND Parola='" + tx_giris_prl.Text + "'", baglanti2);
               
                OleDbDataReader dr = komut3.ExecuteReader();
                if (dr.Read())
                {
                    baglanti2.Close();
                    AnalizForm anf = new AnalizForm();   anf.Show();   this.Hide();
                }
                else
                {
                    MessageBox.Show("Girilen bilgiler hatalıdır.Lütfen yeniden deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tx_giris_yAdi.Text = "";    tx_giris_prl.Text = "";
                    baglanti2.Close();
                }
            }
        }




        private void btn_ykayit_Click(object sender, EventArgs e)           // Yetkili kayıt ekranı geçiş
        {
            this.Width = 648;
        }

        private void btn_onayla_Click(object sender, EventArgs e)           // Yetkili kayıt
        {
            yetkiliAdi = tx_yAdi.Text;   meslek = Convert.ToString(cbx_meslek.SelectedItem);
            eposta = tx_eposta.Text;     parola = tx_parola.Text;      parolaKont = tx_parolaKontrol.Text;
            if (baglanti2.State == ConnectionState.Closed) baglanti2.Open();
            if ((yetkiliAdi != "") && (meslek != "") && (eposta != "") && (parola != "") && (parolaKont != ""))
            {
                OleDbCommand dr = new OleDbCommand("INSERT INTO yetkili_bilgileri(Yetkili_Adi, Meslek, Eposta, Parola)VALUES('" + yetkiliAdi + "', '" + meslek + "', '" + eposta + "', '" + parola + "')", baglanti2);
                dr.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı");
                    tx_yAdi.Text = ""; cbx_meslek.Text = ""; tx_eposta.Text = ""; tx_parola.Text = ""; tx_parolaKontrol.Text = "";
                    baglanti2.Close();
                  
                this.Width = 394;
            }
            else
            { 
                MessageBox.Show("Bilgiler hatalı veya eksik girildi.Yeniden deneyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tx_yAdi.Text = "";    cbx_meslek.Text = "";    tx_eposta.Text="";    tx_parola.Text="";    tx_parolaKontrol.Text=""; 
            }
        }


        private void tx_parolaKontrol_TextChanged(object sender, EventArgs e)
        {
            int deger = String.Compare(tx_parola.Text, tx_parolaKontrol.Text, false);
            if ((tx_parola.TextLength== tx_parolaKontrol.TextLength)&(deger==0))
            {
                lbl_prla.ForeColor = System.Drawing.Color.Green;
                if(tx_parola.TextLength!=0)
                lbl_prla.Text = "Doğru";
            }
            else
            {
                lbl_prla.ForeColor = System.Drawing.Color.Red;
                lbl_prla.Text = "Parolalar eşleşmiyor!";
            }
        }
    }
}
