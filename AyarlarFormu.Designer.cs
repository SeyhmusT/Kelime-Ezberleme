namespace Kelime_Ezberleme_Oyunu
{
    partial class AyarlarFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyarlarFormu));
            this.Btn10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgCikis = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn10
            // 
            this.Btn10.Location = new System.Drawing.Point(10, 30);
            this.Btn10.Name = "Btn10";
            this.Btn10.Size = new System.Drawing.Size(134, 52);
            this.Btn10.TabIndex = 0;
            this.Btn10.Text = "10 Soru";
            this.Btn10.UseVisualStyleBackColor = true;
            this.Btn10.Click += new System.EventHandler(this.Btn10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "AYARLAR";
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(191, 30);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(134, 52);
            this.Btn8.TabIndex = 2;
            this.Btn8.Text = "8 Soru";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(10, 98);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(134, 52);
            this.Btn5.TabIndex = 3;
            this.Btn5.Text = "5 Soru";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(191, 98);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(134, 52);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "4 Soru";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn10);
            this.groupBox1.Controls.Add(this.Btn4);
            this.groupBox1.Controls.Add(this.Btn5);
            this.groupBox1.Controls.Add(this.Btn8);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayar İşlemleri";
            // 
            // imgCikis
            // 
            this.imgCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCikis.Image = ((System.Drawing.Image)(resources.GetObject("imgCikis.Image")));
            this.imgCikis.Location = new System.Drawing.Point(331, 7);
            this.imgCikis.Name = "imgCikis";
            this.imgCikis.Size = new System.Drawing.Size(57, 48);
            this.imgCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCikis.TabIndex = 7;
            this.imgCikis.TabStop = false;
            this.imgCikis.Click += new System.EventHandler(this.imgCikis_Click);
            this.imgCikis.MouseLeave += new System.EventHandler(this.imgCikis_MouseLeave);
            this.imgCikis.MouseHover += new System.EventHandler(this.imgCikis_MouseHover);
            // 
            // AyarlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(400, 266);
            this.Controls.Add(this.imgCikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AyarlarFormu";
            this.Text = "AyarlarFormu";
            this.Load += new System.EventHandler(this.AyarlarFormu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgCikis;
    }
}