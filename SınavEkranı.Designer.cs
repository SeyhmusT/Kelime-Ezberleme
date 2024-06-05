namespace Kelime_Ezberleme_Oyunu
{
    partial class SınavEkranı
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
            this.ImgKelimeResim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblKelime = new System.Windows.Forms.Label();
            this.TxtCevap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCevap = new System.Windows.Forms.Button();
            this.LblCevap = new System.Windows.Forms.Label();
            this.BtnSinavBitir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgKelimeResim)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgKelimeResim
            // 
            this.ImgKelimeResim.Location = new System.Drawing.Point(170, 113);
            this.ImgKelimeResim.Name = "ImgKelimeResim";
            this.ImgKelimeResim.Size = new System.Drawing.Size(273, 204);
            this.ImgKelimeResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgKelimeResim.TabIndex = 0;
            this.ImgKelimeResim.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "SINAV EKRANI";
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKelime.Location = new System.Drawing.Point(471, 194);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(93, 33);
            this.LblKelime.TabIndex = 2;
            this.LblKelime.Text = "label2";
            // 
            // TxtCevap
            // 
            this.TxtCevap.Location = new System.Drawing.Point(170, 337);
            this.TxtCevap.Name = "TxtCevap";
            this.TxtCevap.Size = new System.Drawing.Size(273, 31);
            this.TxtCevap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cevap:";
            // 
            // BtnCevap
            // 
            this.BtnCevap.Location = new System.Drawing.Point(170, 383);
            this.BtnCevap.Name = "BtnCevap";
            this.BtnCevap.Size = new System.Drawing.Size(177, 41);
            this.BtnCevap.TabIndex = 5;
            this.BtnCevap.Text = "Cevapla";
            this.BtnCevap.UseVisualStyleBackColor = true;
            this.BtnCevap.Click += new System.EventHandler(this.BtnCevap_Click);
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCevap.Location = new System.Drawing.Point(471, 258);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(93, 33);
            this.LblCevap.TabIndex = 6;
            this.LblCevap.Text = "label2";
            this.LblCevap.Visible = false;
            // 
            // BtnSinavBitir
            // 
            this.BtnSinavBitir.Location = new System.Drawing.Point(606, 113);
            this.BtnSinavBitir.Name = "BtnSinavBitir";
            this.BtnSinavBitir.Size = new System.Drawing.Size(177, 40);
            this.BtnSinavBitir.TabIndex = 9;
            this.BtnSinavBitir.Text = "Sınavı Bitir";
            this.BtnSinavBitir.UseVisualStyleBackColor = true;
            this.BtnSinavBitir.Click += new System.EventHandler(this.BtnSinavBitir_Click);
            // 
            // SınavEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.BtnSinavBitir);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.BtnCevap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCevap);
            this.Controls.Add(this.LblKelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImgKelimeResim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SınavEkranı";
            this.Text = "SınavEkranı";
            this.Load += new System.EventHandler(this.SınavEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgKelimeResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgKelimeResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.TextBox TxtCevap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCevap;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Button BtnSinavBitir;
    }
}