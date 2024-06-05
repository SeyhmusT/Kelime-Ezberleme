namespace Kelime_Ezberleme_Oyunu
{
    partial class AnalizSayfası
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSaveChart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalizSayfası));
            this.btnSaveChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblToplamSoruSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveChart
            // 
            this.btnSaveChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChart.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveChart.Location = new System.Drawing.Point(328, 389);
            this.btnSaveChart.Name = "btnSaveChart";
            this.btnSaveChart.Size = new System.Drawing.Size(279, 85);
            this.btnSaveChart.TabIndex = 1;
            this.btnSaveChart.Text = "Kaydet";
            this.btnSaveChart.UseVisualStyleBackColor = true;
            this.btnSaveChart.Click += new System.EventHandler(this.btnSaveChart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(631, 365);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // lblToplamSoruSayisi
            // 
            this.lblToplamSoruSayisi.AutoSize = true;
            this.lblToplamSoruSayisi.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSoruSayisi.Location = new System.Drawing.Point(1029, 52);
            this.lblToplamSoruSayisi.Name = "lblToplamSoruSayisi";
            this.lblToplamSoruSayisi.Size = new System.Drawing.Size(111, 45);
            this.lblToplamSoruSayisi.TabIndex = 3;
            this.lblToplamSoruSayisi.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(646, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOPLAM SORU SAYISI:";
            // 
            // imgCikis
            // 
            this.imgCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCikis.Image = ((System.Drawing.Image)(resources.GetObject("imgCikis.Image")));
            this.imgCikis.Location = new System.Drawing.Point(1061, 2);
            this.imgCikis.Name = "imgCikis";
            this.imgCikis.Size = new System.Drawing.Size(57, 48);
            this.imgCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCikis.TabIndex = 9;
            this.imgCikis.TabStop = false;
            this.imgCikis.Click += new System.EventHandler(this.imgCikis_Click);
            this.imgCikis.MouseLeave += new System.EventHandler(this.imgCikis_MouseLeave);
            this.imgCikis.MouseHover += new System.EventHandler(this.imgCikis_MouseHover);
            // 
            // AnalizSayfası
            // 
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1130, 500);
            this.Controls.Add(this.imgCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplamSoruSayisi);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnSaveChart);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalizSayfası";
            this.Text = "AnalizSayfası";
            this.Load += new System.EventHandler(this.AnalizSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblToplamSoruSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgCikis;
    }
}