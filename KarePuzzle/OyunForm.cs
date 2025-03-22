using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
namespace KarePuzzle
{
    public partial class OyunForm : Form
    {
        public OyunForm()
        {
            InitializeComponent();
        }

        //-------------Oyun Form Tanımlamalar--------------------

        Random rnd = new Random();
        public int tıksayac = 0, sayac2 = -1,sayac=0,rindex=0;
        List<int> kareler = new List<int>();
        GirisForm grfm = new GirisForm();
        public int index = 0;
        public int dogrusayac, yanlissayac, puan;
        kategoriForm ktfrm = new kategoriForm();
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/usersdb.mdb");
        public string deger1, deger2, deger3, deger4 = "";
        public static string secilen = "";
        public int toplamPuan = 0;
        public string karegori = "";
        bool cvpkont = false;
        public bool kareKont = false;
        public bool kareKont2 = false;
        int sorusayac = -1;

        //--------------------------------------------------------


        private void timer1_Tick(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btn_sonraki.Enabled = false;
            rindex = rnd.Next(0, kareler.Count);
            label2.Text = Convert.ToString(kareler[rindex]);
            rastgeleKare(kareler[rindex]);
            
            if (sayac > 12)
            {
                timer1.Stop();
                timer1.Enabled = false;
                btn_sonraki.Enabled = true;
                vericek(index);
               
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                kareler.RemoveAt(rindex);
                sayac2++;
               
                sayac = 0;
            }
            sayac++;
        }


        public void kareRenkDegistir()
        {
            kare1.BackColor = Color.Snow;         kare2.BackColor = Color.Snow;
            kare3.BackColor = Color.Snow;         kare4.BackColor = Color.Snow;
            kare5.BackColor = Color.Snow;         kare6.BackColor = Color.Snow;
            kare7.BackColor = Color.Snow;         kare8.BackColor = Color.Snow;
            kare9.BackColor = Color.Snow;         kare10.BackColor = Color.Snow;
            kare11.BackColor = Color.Snow;        kare12.BackColor = Color.Snow;
            kare13.BackColor = Color.Snow;        kare14.BackColor = Color.Snow;
            kare15.BackColor = Color.Snow;        kare16.BackColor = Color.Snow;
            kare17.BackColor = Color.Snow;        kare18.BackColor = Color.Snow;
            kare19.BackColor = Color.Snow;        kare18.BackColor = Color.Snow;
            kare20.BackColor = Color.Snow;        kare21.BackColor = Color.Snow;
            kare22.BackColor = Color.Snow;        kare23.BackColor = Color.Snow;
            kare24.BackColor = Color.Snow;        kare25.BackColor = Color.Snow;
        }




















        public void rastgeleKare(int deger)
        {
            switch (deger)
            {
                case 1:
                    {
                        kareRenkDegistir();
                        kare1.BackColor = Color.Chartreuse;
                        break;
                    }
                case 2:
                    {
                        kareRenkDegistir();
                        kare2.BackColor = Color.Chartreuse;
                        break;
                    }
                case 3:
                    {
                        kareRenkDegistir();
                        kare3.BackColor = Color.Chartreuse;
                        break;
                    }
                case 4:
                    {
                        kareRenkDegistir();
                        kare4.BackColor = Color.Chartreuse;
                        break;
                    }


                case 5:
                    {
                        kareRenkDegistir();
                        kare5.BackColor = Color.Chartreuse;
                        break;
                    }

                case 6:
                    {
                        kareRenkDegistir();
                        kare6.BackColor = Color.Chartreuse;
                        break;
                    }
                case 7:
                    {
                        kareRenkDegistir();
                        kare7.BackColor = Color.Chartreuse;
                        break;
                    }
                case 8:
                    {
                        kareRenkDegistir();
                        kare8.BackColor = Color.Chartreuse;
                        break;
                    }
                case 9:
                    {
                        kareRenkDegistir();
                        kare9.BackColor = Color.Chartreuse;
                        break;
                    }


                case 10:
                    {
                        kareRenkDegistir();
                        kare10.BackColor = Color.Chartreuse;
                        break;
                    }
                case 11:
                    {
                        kareRenkDegistir();
                        kare11.BackColor = Color.Chartreuse;
                        break;
                    }
                case 12:
                    {
                        kareRenkDegistir();
                        kare12.BackColor = Color.Chartreuse;
                        break;
                    }
                case 13:
                    {
                        kareRenkDegistir();
                        kare13.BackColor = Color.Chartreuse;
                        break;
                    }
                case 14:
                    {
                        kareRenkDegistir();
                        kare14.BackColor = Color.Chartreuse;
                        break;
                    }
                case 15:
                    {
                        kareRenkDegistir();
                        kare15.BackColor = Color.Chartreuse;
                        break;
                    }
                case 16:
                    {
                        kareRenkDegistir();
                        kare16.BackColor = Color.Chartreuse;
                        break;
                    }
                case 17:
                    {
                        kareRenkDegistir();
                        kare17.BackColor = Color.Chartreuse;
                        break;
                    }
                case 18:
                    {
                        kareRenkDegistir();
                        kare18.BackColor = Color.Chartreuse;
                        break;
                    }
                case 19:
                    {
                        kareRenkDegistir();
                        kare19.BackColor = Color.Chartreuse;
                        break;
                    }
                case 20:
                    {
                        kareRenkDegistir();
                        kare20.BackColor = Color.Chartreuse;
                        break;
                    }
                case 21:
                    {
                        kareRenkDegistir();
                        kare21.BackColor = Color.Chartreuse;
                        break;
                    }
                case 22:
                    {
                        kareRenkDegistir();
                        kare22.BackColor = Color.Chartreuse;

                        break;
                    }
                case 23:
                    {
                        kareRenkDegistir();
                        kare23.BackColor = Color.Chartreuse;

                        break;
                    }
                case 24:
                    {
                        kareRenkDegistir();
                        
                            kare24.BackColor = Color.Chartreuse;

                        break;
                    }
                case 25:
                    {
                        kareRenkDegistir();
                       
                            kare25.BackColor = Color.Chartreuse;

                        break;
                    }

            }
        }

        public void rastgeleKare3(int deger2)
        {
            if (deger2 == 1)
                kare1.BackgroundImage = Properties.Resources.image_1_1;
            else if (deger2 == 2)
                kare2.BackgroundImage = Properties.Resources.image_1_2;
            else if (deger2 == 3)
                kare3.BackgroundImage = Properties.Resources.image_1_3;
            else if (deger2 == 4)
                kare4.BackgroundImage = Properties.Resources.image_1_4;
            else if (deger2 == 5)
                kare5.BackgroundImage = Properties.Resources.image_1_5;
            else if (deger2 == 6)
                kare6.BackgroundImage = Properties.Resources.image_2_1;
            else if (deger2 == 7)
                kare7.BackgroundImage = Properties.Resources.image_2_2;
            else if (deger2 == 8)
                kare8.BackgroundImage = Properties.Resources.image_2_3;
            else if (deger2 == 9)
                kare9.BackgroundImage = Properties.Resources.image_2_4;
            else if (deger2 == 10)
                kare10.BackgroundImage = Properties.Resources.image_2_5;
            else if (deger2 == 11)
                kare11.BackgroundImage = Properties.Resources.image_3_1;
            else if (deger2 == 12)
                kare12.BackgroundImage = Properties.Resources.image_3_2;
            else if (deger2 == 13)
                kare13.BackgroundImage = Properties.Resources.image_3_3;
            else if (deger2 == 14)
                kare14.BackgroundImage = Properties.Resources.image_3_4;
            else if (deger2 == 15)
                kare15.BackgroundImage = Properties.Resources.image_3_5;

            else if (deger2 == 16)
                kare16.BackgroundImage = Properties.Resources.image_4_1;
            else if (deger2 == 17)
                kare17.BackgroundImage = Properties.Resources.image_4_2;
            else if (deger2 == 18)
                kare18.BackgroundImage = Properties.Resources.image_4_3;
            else if (deger2 == 19)
                kare19.BackgroundImage = Properties.Resources.image_4_4;
            else if (deger2 == 20)
                kare20.BackgroundImage = Properties.Resources.image_4_5;
            else if (deger2 == 21)
                kare21.BackgroundImage = Properties.Resources.image_5_1;
            else if (deger2 == 22)
                kare22.BackgroundImage = Properties.Resources.image_5_2;
            else if (deger2 == 23)
                kare23.BackgroundImage = Properties.Resources.image_5_3;
            else if (deger2 == 24)
                kare24.BackgroundImage = Properties.Resources.image_5_4;
            else if (deger2 == 25)
                kare25.BackgroundImage = Properties.Resources.image_5_5;
        }


        public void rastgeleKare2(int deger2)
        {
            if (deger2 == 1)
                kare1.BackgroundImage = Properties.Resources.image__1_1;
            else if (deger2 == 2)
                kare2.BackgroundImage = Properties.Resources.image__1_2;
            else if (deger2 == 3)
                kare3.BackgroundImage = Properties.Resources.image__1_3;
            else if (deger2 == 4)
                kare4.BackgroundImage = Properties.Resources.image__1_4;
            else if (deger2 == 5)
                kare5.BackgroundImage = Properties.Resources.image__1_5;
            else if (deger2 == 6)
                kare6.BackgroundImage = Properties.Resources.image__2_1;
            else if (deger2 == 7)
                kare7.BackgroundImage = Properties.Resources.image__2_2;
            else if (deger2 == 8)
                kare8.BackgroundImage = Properties.Resources.image__2_3;
            else if (deger2 == 9)
                kare9.BackgroundImage = Properties.Resources.image__2_4;
            else if (deger2 == 10)
                kare10.BackgroundImage = Properties.Resources.image__2_5;
            else if (deger2 == 11)
                kare11.BackgroundImage = Properties.Resources.image__3_1;
            else if (deger2 == 12)
                kare12.BackgroundImage = Properties.Resources.image__3_2;
            else if (deger2 == 13)
                kare13.BackgroundImage = Properties.Resources.image__3_3;
            else if (deger2 == 14)
                kare14.BackgroundImage = Properties.Resources.image__3_4;
            else if (deger2 == 15)
                kare15.BackgroundImage = Properties.Resources.image__3_5;


            else if (deger2 == 16)
                kare16.BackgroundImage = Properties.Resources.image__4_1;
            else if (deger2 == 17)
                kare17.BackgroundImage = Properties.Resources.image__4_2;
            else if (deger2 == 18)
                kare18.BackgroundImage = Properties.Resources.image__4_3;
            else if (deger2 == 19)
                kare19.BackgroundImage = Properties.Resources.image__4_4;
            else if (deger2 == 20)
                kare20.BackgroundImage = Properties.Resources.image__4_5;
            else if (deger2 == 21)
                kare21.BackgroundImage = Properties.Resources.image__5_1;
            else if (deger2 == 22)
                kare22.BackgroundImage = Properties.Resources.image__5_2;
            else if (deger2 == 23)
                kare23.BackgroundImage = Properties.Resources.image__5_3;
            else if (deger2 == 24)
                kare24.BackgroundImage = Properties.Resources.image__5_4;
            else if (deger2 == 25)
                kare25.BackgroundImage = Properties.Resources.image__5_5;
        }










        private void btnA_Click(object sender, EventArgs e)
        {
            cevapKontrol(index);
            if (deger1 == "d_")
            {
               
                btnA.BackColor = Color.Green;
                lblA.Text = "+10";
                lblA.ForeColor = Color.Green;
                araislem();

            }
            else
            {
                yanlissayac+=1;
                btnA.BackColor = Color.Red;
                lblA.Text = "-5";
                toplamPuan -= 5;
                lblpuan.Text = Convert.ToString(toplamPuan);
                lblA.ForeColor = Color.Red;
            }
            deger1 = "";

        }






        private void btnB_Click(object sender, EventArgs e)
        {
            cevapKontrol(index);
            if (deger2 == "d_")
            {
                btnB.BackColor = Color.Green;
                lblB.Text = "+10";
                lblB.ForeColor = Color.Green;
                araislem();

            }
            else
            {
                btnB.BackColor = Color.Red;
                lblB.Text = "-5";
                toplamPuan -= 5;
                lblpuan.Text = Convert.ToString(toplamPuan);
                lblB.ForeColor = Color.Red;
                yanlissayac += 1;
            }
            deger4 = "";

        }
           public void araislem()
        {
            toplamPuan += 10;
            lblpuan.Text = Convert.ToString(toplamPuan);
            dogrusayac += 1;
            if (karegori == "hayvan")
                rastgeleKare2(Convert.ToInt32(label2.Text));
            else if (karegori == "bitki")
                rastgeleKare3(Convert.ToInt32(label2.Text));

        }        
        
         

        private void btnC_Click(object sender, EventArgs e)
        {
            cevapKontrol(index);
            if (deger3 == "d_")
            {
                btnC.BackColor = Color.Green;
                lblC.Text = "+10";
                lblC.ForeColor = Color.Green;
                araislem();
            }
            else
            {
                btnC.BackColor = Color.Red;
                lblC.Text = "-5";
                lblC.ForeColor = Color.Red;
                toplamPuan -= 5;
                lblpuan.Text = Convert.ToString(toplamPuan);
                yanlissayac += 1;
            }
            deger4 = "";
        }






        private void btnD_Click(object sender, EventArgs e)
        {
            cevapKontrol(index);
            if (deger4 == "d_")
            {
                btnD.BackColor = Color.Green;
                lblD.Text = "+10";
                lblD.ForeColor = Color.Green;
                araislem();
            }
            else
            {
                btnD.BackColor = Color.Red;
                lblD.Text = "-5";
                lblD.ForeColor = Color.Red;
                toplamPuan += 5;
                lblpuan.Text = Convert.ToString(toplamPuan);
                yanlissayac += 1;
            }
            deger4 = "";
        }
        

      

        public void butonlarıKapat()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        public void butonlarıAc()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            if (cvpkont == true)
            {
                btnA.Font = new Font(btnA.Font.Name, btnA.Font.Size, FontStyle.Regular);
                btnB.Font = new Font(btnB.Font.Name, btnB.Font.Size, FontStyle.Regular);
                btnC.Font = new Font(btnC.Font.Name, btnC.Font.Size, FontStyle.Regular);
                btnD.Font = new Font(btnD.Font.Name, btnD.Font.Size, FontStyle.Regular);
                cvpkont = false;
            }
        }
       
        public  int cevapKontrol(int indeks)
        {

            if (bag.State == ConnectionState.Closed) bag.Open();
            string srgu = "";
            if (secilen== "Hayvanlar | Animals")
            {
                karegori = "hayvan";
               srgu = "Select Cevap1,Cevap2,Cevap3,Cevap4 From Hayvanlar where soruId=" + indeks + "";
            }
           else if (secilen == "Bitkiler | Plants")
            {
                srgu = "Select Cevap1,Cevap2,Cevap3,Cevap4 From Bitkiler where soruId=" + indeks + "";
                karegori = "bitki";
            }
            OleDbCommand komut = new OleDbCommand(srgu, bag);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                deger1 = dr["Cevap1"].ToString().Substring(0, 2);
                deger2 = dr["Cevap2"].ToString().Substring(0, 2);
                deger3 = dr["Cevap3"].ToString().Substring(0, 2);
                deger4 = dr["Cevap4"].ToString().Substring(0, 2);
            }

            cvpkont = true;
            //  MessageBox.Show("Kayıt Tamamlandı!");
            bag.Close();
            return 0;
        }




        
        private void OyunForm_Load(object sender, EventArgs e)
        {
            btn_sonraki.Enabled = false;
            kategoriForm ktfrm = new kategoriForm();
            ktfrm.Show();
            for (int i = 0; i < 25; i++)
            {
                kareler.Add(i + 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }
     
        int i = 1;
        public int durumGuncelle(int soruSayac,int dsayac,int ysayac, int puan)
        {
            bag.Open();
            string kAdi = GirisForm.isim;
            OleDbCommand komutt = new OleDbCommand("Update Users set SoruSayisi=" + soruSayac + ", DogruSayisi=" + dsayac+",YanlisSayisi="+ysayac+",Puan="+ puan +
                " WHERE KullanıcıAdı='"+kAdi+"'", bag);
            komutt.ExecuteNonQuery();
            komutt.Dispose();
            bag.Close();
            return 0;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            AnalizForm analiz = new AnalizForm();
            analiz.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            rastgeleKare2(Convert.ToInt32(label2.Text));
        }
       
        private void button4_Click_1(object sender, EventArgs e)
        {
            tahmin tform = new tahmin();
            tform.Show();
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            index = 1;
            vericek(index);
        }

        private void kare9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        public void sıfırla()
        {
            btnA.BackColor = Color.WhiteSmoke;
            btnB.BackColor = Color.WhiteSmoke;
            btnC.BackColor = Color.WhiteSmoke;
            btnD.BackColor = Color.WhiteSmoke;
            deger1 = ""; deger2 = ""; deger3 = ""; deger4 = "";
            btnA.Text = ""; btnB.Text = ""; btnC.Text = ""; btnD.Text = "";
            lbl_sıra.Text = "";
            lbl_soru.Text = "";
            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            lblD.Text = "";
        }
       
        GirisForm grs = new GirisForm();
        private void button5_Click(object sender, EventArgs e)
        {
            index++;
            timer1.Enabled = true;
            timer1.Start();
            sıfırla();
            sorusayac++;
            durumGuncelle(sorusayac, dogrusayac, yanlissayac, toplamPuan);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button5_Click(button6, new EventArgs());
            button6.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kategoriForm kt = new kategoriForm();
            kt.Show();
            index = 0;
          
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        string sorgu = "";





        public int vericek(int index)
        {
            if (secilen == "Hayvanlar | Animals")
                sorgu = "Select * from Hayvanlar where soruId = " + Convert.ToString(index) + "";
            if (secilen == "Bitkiler | Plants")
                sorgu = "Select * from Bitkiler where soruId = " + Convert.ToString(index) + "";
            bag.Open();
             OleDbCommand kmtt = new OleDbCommand(sorgu, bag);
             kmtt.ExecuteNonQuery();
            OleDbDataReader dr = kmtt.ExecuteReader();
            if (dr.Read())
            {
                lbl_sıra.Text = dr["SoruId"].ToString();
                lbl_soru.Text = dr["Sorular"].ToString();
                btnA.Text = dr["Cevap1"].ToString();                btnB.Text = dr["Cevap2"].ToString();
                btnC.Text = dr["Cevap3"].ToString();                btnD.Text = dr["Cevap4"].ToString();
                int uzunluk = 0;
                if (btnA.Text.Substring(0, 2) == "d_")
                {
                     uzunluk = btnA.Text.Length;
                    btnA.Text = btnA.Text.Substring(2, uzunluk-2);
                }
                else if (btnB.Text.Substring(0, 2) == "d_")
                {
                    uzunluk = btnB.Text.Length;
                    btnB.Text = btnB.Text.Substring(2, uzunluk-2);
                }
               else if (btnC.Text.Substring(0, 2) == "d_")
                {
                     uzunluk = btnC.Text.Length;
                    btnC.Text = btnC.Text.Substring(2, uzunluk-2);
                }
               else if (btnD.Text.Substring(0, 2) == "d_")
                {
                    uzunluk = btnD.Text.Length;
                    btnD.Text = btnD.Text.Substring(2, uzunluk-2);
                }
            }
            else
                MessageBox.Show("veri çekilmedi");
            bag.Close();
            return 0;
        }
    }
    }
