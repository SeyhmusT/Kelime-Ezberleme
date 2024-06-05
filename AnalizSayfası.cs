using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kelime_Ezberleme_Oyunu
{
    public partial class AnalizSayfası : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=SeyhmusPC;Initial Catalog=KELİME_EZBERLEME;Integrated Security=True");

        public AnalizSayfası()
        {
            InitializeComponent();
        }

        private void AnalizSayfası_Load(object sender, EventArgs e)
        {
           
            ChartVerileriniYukle();
            lblToplamSoruSayisi.Text = ToplamSoruSayisiniGetir().ToString();

        }


        private int ToplamSoruSayisiniGetir()
        {
            int toplamSoruSayisi = 0;

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM SORULAR", baglanti);
                toplamSoruSayisi = (int)komut.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

            return toplamSoruSayisi;
        }

        private void ChartVerileriniYukle()
        {
            chart1.Series.Clear();
            chart1.Titles.Add("İlerleme Analizi");

            Series series = chart1.Series.Add("Soru Doğru Bilinme");
            series.ChartType = SeriesChartType.Column;

            int count6 = 0;
            int count1to5 = 0;






            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT SoruDogruBilinme FROM SORULAR", baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    byte SoruDogruBilinme = reader.GetByte(0);

                    if (SoruDogruBilinme == 6)
                    {
                        count6++;
                    }
                    else if (SoruDogruBilinme >= 1 && SoruDogruBilinme <= 5)
                    {
                        count1to5++;
                    }
                }
                baglanti.Close();
                
                series.Points.AddXY("Tamamen Bilinenler", count6);
                series.Points.AddXY("Bilinme Aşamasındakiler", count1to5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnSaveChart_Click(object sender, EventArgs e)
        {
            SaveChartAsImage();
        }

        private void SaveChartAsImage()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                    MessageBox.Show("Grafik başarıyla kaydedildi.");
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void imgCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgCikis_MouseHover(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightSeaGreen;
        }

        private void imgCikis_MouseLeave(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.Bisque;
        }
    }
}
