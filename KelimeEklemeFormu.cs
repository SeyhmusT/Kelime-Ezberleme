using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kelime_Ezberleme_Oyunu
{
    public partial class KelimeEklemeFormu : Form
    {
        public KelimeEklemeFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SeyhmusPC;Initial Catalog=KELİME_EZBERLEME;Integrated Security=True");

        private void imgCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void imgCikis_MouseHover(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightBlue;
        }

        private void imgCikis_MouseLeave(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightSeaGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;


        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SORULAR (SoruTurkce,Soruİngilizce,SoruResmi,SoruDogruBilinme,MevcutTarih)" +
                " values (@p1,@p2,@p3,@p4,(SELECT MevcutTarih FROM SORULAR WHERE Soruİngilizce = 'School'))", baglanti);

            komut.Parameters.AddWithValue("@p1",txtTurkce.Text);
            komut.Parameters.AddWithValue("@p2", txtİngilizce.Text);
            komut.Parameters.AddWithValue("@p3", TxtResim.Text);
            komut.Parameters.AddWithValue("@p4",0);
            komut.ExecuteNonQuery();

            


            baglanti.Close();

            txtTurkce.Text = "";
            txtİngilizce.Text = "";
            TxtResim.Text = "";
            txtİngilizce.Focus();
            pictureBox1.Image = null;
            MessageBox.Show("Resim Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KelimeEklemeFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
