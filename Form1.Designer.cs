namespace Kelime_Ezberleme_Oyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnKelimeEkle = new System.Windows.Forms.Button();
            this.BtnSinav = new System.Windows.Forms.Button();
            this.Btn1Gun = new System.Windows.Forms.Button();
            this.LblBaslik = new System.Windows.Forms.Label();
            this.BtnRapor = new System.Windows.Forms.Button();
            this.imgCikis = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imgAyarlar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAyarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKelimeEkle
            // 
            this.BtnKelimeEkle.Location = new System.Drawing.Point(185, 39);
            this.BtnKelimeEkle.Name = "BtnKelimeEkle";
            this.BtnKelimeEkle.Size = new System.Drawing.Size(173, 57);
            this.BtnKelimeEkle.TabIndex = 0;
            this.BtnKelimeEkle.Text = "Kelime Ekle";
            this.BtnKelimeEkle.UseVisualStyleBackColor = true;
            this.BtnKelimeEkle.Click += new System.EventHandler(this.BtnKelimeEkle_Click);
            // 
            // BtnSinav
            // 
            this.BtnSinav.Location = new System.Drawing.Point(6, 143);
            this.BtnSinav.Name = "BtnSinav";
            this.BtnSinav.Size = new System.Drawing.Size(173, 57);
            this.BtnSinav.TabIndex = 1;
            this.BtnSinav.Text = "Sınava Başla";
            this.BtnSinav.UseVisualStyleBackColor = true;
            this.BtnSinav.Click += new System.EventHandler(this.BtnSinav_Click);
            // 
            // Btn1Gun
            // 
            this.Btn1Gun.Location = new System.Drawing.Point(15, 30);
            this.Btn1Gun.Name = "Btn1Gun";
            this.Btn1Gun.Size = new System.Drawing.Size(173, 57);
            this.Btn1Gun.TabIndex = 2;
            this.Btn1Gun.Text = "1 Gün İlerlet";
            this.Btn1Gun.UseVisualStyleBackColor = true;
            this.Btn1Gun.Click += new System.EventHandler(this.Btn1Gun_Click);
            // 
            // LblBaslik
            // 
            this.LblBaslik.AutoSize = true;
            this.LblBaslik.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaslik.Location = new System.Drawing.Point(111, 30);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(708, 77);
            this.LblBaslik.TabIndex = 3;
            this.LblBaslik.Text = "KELİME EZBERLEME OYUNU";
            // 
            // BtnRapor
            // 
            this.BtnRapor.Location = new System.Drawing.Point(306, 143);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(173, 57);
            this.BtnRapor.TabIndex = 4;
            this.BtnRapor.Text = "Rapor Çıkar";
            this.BtnRapor.UseVisualStyleBackColor = true;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // imgCikis
            // 
            this.imgCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCikis.Image = ((System.Drawing.Image)(resources.GetObject("imgCikis.Image")));
            this.imgCikis.Location = new System.Drawing.Point(1083, 9);
            this.imgCikis.Name = "imgCikis";
            this.imgCikis.Size = new System.Drawing.Size(57, 48);
            this.imgCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCikis.TabIndex = 6;
            this.imgCikis.TabStop = false;
            this.imgCikis.Click += new System.EventHandler(this.pictureBox2_Click);
            this.imgCikis.MouseLeave += new System.EventHandler(this.imgCikis_MouseLeave);
            this.imgCikis.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BtnKelimeEkle);
            this.groupBox1.Controls.Add(this.BtnSinav);
            this.groupBox1.Controls.Add(this.BtnRapor);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(485, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(185, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(788, 190);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(300, 241);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Btn1Gun);
            this.groupBox2.Location = new System.Drawing.Point(12, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 157);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zaman İşlemleri";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "6 Ay İlerlet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "1 Ay İlerlet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "1 Hafta İlerlet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgAyarlar
            // 
            this.imgAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("imgAyarlar.Image")));
            this.imgAyarlar.Location = new System.Drawing.Point(1020, 12);
            this.imgAyarlar.Name = "imgAyarlar";
            this.imgAyarlar.Size = new System.Drawing.Size(57, 48);
            this.imgAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAyarlar.TabIndex = 5;
            this.imgAyarlar.TabStop = false;
            this.imgAyarlar.Click += new System.EventHandler(this.imgAyarlar_Click);
            this.imgAyarlar.MouseLeave += new System.EventHandler(this.imgAyarlar_MouseLeave);
            this.imgAyarlar.MouseHover += new System.EventHandler(this.imgAyarlar_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1152, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgCikis);
            this.Controls.Add(this.imgAyarlar);
            this.Controls.Add(this.LblBaslik);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "AnaEkranFormu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAyarlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKelimeEkle;
        private System.Windows.Forms.Button BtnSinav;
        private System.Windows.Forms.Button Btn1Gun;
        private System.Windows.Forms.Label LblBaslik;
        private System.Windows.Forms.Button BtnRapor;
        private System.Windows.Forms.PictureBox imgCikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgAyarlar;
    }
}

