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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SeyhmusPC;Initial Catalog=KELİME_EZBERLEME;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.DeepSkyBlue;
        }

        private void imgAyarlar_MouseHover(object sender, EventArgs e)
        {
            imgAyarlar.BackColor = Color.LightBlue;
        }

        private void imgAyarlar_MouseLeave(object sender, EventArgs e)
        {
            imgAyarlar.BackColor = Color.LightGreen;
        }

        private void imgCikis_MouseLeave(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightGreen;
        }

        private void imgAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarFormu frm = new AyarlarFormu();
            frm.Show();

        }

        private void BtnKelimeEkle_Click(object sender, EventArgs e)
        {
            KelimeEklemeFormu frm = new KelimeEklemeFormu();
            frm.Show();
        }

        private void BtnSinav_Click(object sender, EventArgs e)
        {
            AyarlarFormu frm1 = new AyarlarFormu();
            SınavEkranı frm = new SınavEkranı();
            frm.Show();
            
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn1Gun_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE SORULAR SET mevcutTarih = DATEADD(day, 1, mevcutTarih)", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Zaman 1 gün ilerledi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE SORULAR SET mevcutTarih = DATEADD(day, 7, mevcutTarih)", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Zaman 1 hafta ilerledi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE SORULAR SET mevcutTarih = DATEADD(day, 30, mevcutTarih)", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Zaman 1 ay ilerledi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE SORULAR SET mevcutTarih = DATEADD(day, 180, mevcutTarih)", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Zaman 6 ay ilerledi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            AnalizSayfası frm = new AnalizSayfası();
            frm.Show();

        }
    }
}
