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
    public partial class KullaniciGirisFormu : Form
    {
        public KullaniciGirisFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SeyhmusPC;Initial Catalog=KELİME_EZBERLEME;Integrated Security=True");

        private void KullaniciGirisFormu_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM KULLANICILAR WHERE KullaniciAdi = @p1 AND KullaniciSifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Geçersiz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
            
        }

        private void LnkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullanıcıKayıt frm = new KullanıcıKayıt();
            frm.Show();

        }

        private void imgCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgCikis_MouseHover(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightGreen;
        }

        private void imgCikis_MouseLeave(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightSkyBlue;
        }
    }
}
