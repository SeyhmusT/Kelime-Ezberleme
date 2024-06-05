namespace Kelime_Ezberleme_Oyunu
{
    partial class KullaniciGirisFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LnkKayit = new System.Windows.Forms.LinkLabel();
            this.imgCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI GİRİŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(315, 262);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(116, 42);
            this.BtnGiris.TabIndex = 3;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(222, 177);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(209, 35);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(222, 218);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(209, 35);
            this.TxtSifre.TabIndex = 7;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // LnkKayit
            // 
            this.LnkKayit.AutoSize = true;
            this.LnkKayit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LnkKayit.Location = new System.Drawing.Point(213, 269);
            this.LnkKayit.Name = "LnkKayit";
            this.LnkKayit.Size = new System.Drawing.Size(96, 29);
            this.LnkKayit.TabIndex = 8;
            this.LnkKayit.TabStop = true;
            this.LnkKayit.Text = "Kayıt Ol";
            this.LnkKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkKayit_LinkClicked);
            // 
            // imgCikis
            // 
            this.imgCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCikis.Image = ((System.Drawing.Image)(resources.GetObject("imgCikis.Image")));
            this.imgCikis.Location = new System.Drawing.Point(616, 12);
            this.imgCikis.Name = "imgCikis";
            this.imgCikis.Size = new System.Drawing.Size(57, 48);
            this.imgCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCikis.TabIndex = 9;
            this.imgCikis.TabStop = false;
            this.imgCikis.Click += new System.EventHandler(this.imgCikis_Click);
            this.imgCikis.MouseLeave += new System.EventHandler(this.imgCikis_MouseLeave);
            this.imgCikis.MouseHover += new System.EventHandler(this.imgCikis_MouseHover);
            // 
            // KullaniciGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(685, 421);
            this.Controls.Add(this.imgCikis);
            this.Controls.Add(this.LnkKayit);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "KullaniciGirisFormu";
            this.Text = "KullaniciGirisFormu";
            this.Load += new System.EventHandler(this.KullaniciGirisFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.LinkLabel LnkKayit;
        private System.Windows.Forms.PictureBox imgCikis;
    }
}