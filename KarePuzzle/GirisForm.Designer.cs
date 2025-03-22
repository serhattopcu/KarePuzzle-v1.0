namespace KarePuzzle
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.btn_giris = new System.Windows.Forms.Button();
            this.tx_isim = new System.Windows.Forms.TextBox();
            this.cbx_yas = new System.Windows.Forms.ComboBox();
            this.btn_kız = new System.Windows.Forms.Button();
            this.btn_erkek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Transparent;
            this.btn_giris.BackgroundImage = global::KarePuzzle.Properties.Resources.kgiris1;
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_giris.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Location = new System.Drawing.Point(98, 403);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(165, 49);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            this.btn_giris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_giris_MouseMove);
            // 
            // tx_isim
            // 
            this.tx_isim.BackColor = System.Drawing.Color.SeaShell;
            this.tx_isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_isim.Font = new System.Drawing.Font("Meiryo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_isim.ForeColor = System.Drawing.Color.Firebrick;
            this.tx_isim.Location = new System.Drawing.Point(78, 145);
            this.tx_isim.Multiline = true;
            this.tx_isim.Name = "tx_isim";
            this.tx_isim.Size = new System.Drawing.Size(202, 28);
            this.tx_isim.TabIndex = 1;
            this.tx_isim.Text = "   İsmin | Your Name";
            this.tx_isim.Click += new System.EventHandler(this.tx_isim_Click);
            // 
            // cbx_yas
            // 
            this.cbx_yas.BackColor = System.Drawing.Color.Ivory;
            this.cbx_yas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_yas.Font = new System.Drawing.Font("Meiryo", 9.3F);
            this.cbx_yas.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbx_yas.FormattingEnabled = true;
            this.cbx_yas.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cbx_yas.Location = new System.Drawing.Point(80, 212);
            this.cbx_yas.Name = "cbx_yas";
            this.cbx_yas.Size = new System.Drawing.Size(79, 26);
            this.cbx_yas.TabIndex = 4;
            this.cbx_yas.Text = "Yaş | Age";
            this.cbx_yas.Click += new System.EventHandler(this.cbx_yas_Click);
            // 
            // btn_kız
            // 
            this.btn_kız.BackColor = System.Drawing.Color.Transparent;
            this.btn_kız.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kız.BackgroundImage")));
            this.btn_kız.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kız.FlatAppearance.BorderSize = 0;
            this.btn_kız.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_kız.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_kız.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kız.Location = new System.Drawing.Point(177, 294);
            this.btn_kız.Name = "btn_kız";
            this.btn_kız.Size = new System.Drawing.Size(57, 60);
            this.btn_kız.TabIndex = 9;
            this.btn_kız.UseVisualStyleBackColor = false;
            this.btn_kız.Click += new System.EventHandler(this.btn_kız_Click);
            // 
            // btn_erkek
            // 
            this.btn_erkek.BackColor = System.Drawing.Color.Transparent;
            this.btn_erkek.BackgroundImage = global::KarePuzzle.Properties.Resources.e1;
            this.btn_erkek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_erkek.FlatAppearance.BorderSize = 0;
            this.btn_erkek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_erkek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_erkek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_erkek.Location = new System.Drawing.Point(88, 293);
            this.btn_erkek.Name = "btn_erkek";
            this.btn_erkek.Size = new System.Drawing.Size(57, 60);
            this.btn_erkek.TabIndex = 10;
            this.btn_erkek.UseVisualStyleBackColor = false;
            this.btn_erkek.Click += new System.EventHandler(this.btn_erkek_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(474, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 35);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Location = new System.Drawing.Point(473, -2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(26, 35);
            this.btn_cikis.TabIndex = 12;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // GirisForm
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KarePuzzle.Properties.Resources.turuncu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(498, 497);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_erkek);
            this.Controls.Add(this.btn_kız);
            this.Controls.Add(this.cbx_yas);
            this.Controls.Add(this.tx_isim);
            this.Controls.Add(this.btn_giris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KarePuzzle | Giriş";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GirisForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_yas;
        private System.Windows.Forms.Button btn_kız;
        public System.Windows.Forms.TextBox tx_isim;
        private System.Windows.Forms.Button btn_erkek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cikis;
        public System.Windows.Forms.Button btn_giris;
    }
}

