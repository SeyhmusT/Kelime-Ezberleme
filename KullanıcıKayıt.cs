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
    public partial class KullanıcıKayıt : Form
    {
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SeyhmusPC;Initial Catalog=KELİME_EZBERLEME;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan veriler
            string kullaniciAdi = TxtKullaniciAdi.Text;
            string sifre = TxtSifre.Text;

            
                baglanti.Open();

                // Aynı kullanıcı adı var mı kontrolü
                string kontrolQuery = "SELECT COUNT(*) FROM KULLANICILAR WHERE KullaniciAdi = @KullaniciAdi";
                SqlCommand kontrolKomut = new SqlCommand(kontrolQuery, baglanti);
                kontrolKomut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                int count = (int)kontrolKomut.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut, lütfen başka bir kullanıcı adı seçin.");
                }
                else
                {
                    // Kullanıcı adı mevcut değilse yeni kullanıcıyı ekle
                    string insertQuery = "INSERT INTO KULLANICILAR (KullaniciAdi, KullaniciSifre) VALUES (@KullaniciAdi, @Sifre)";
                    SqlCommand insertKomut = new SqlCommand(insertQuery, baglanti);

                    // Parametrelerin eklenmesi
                    insertKomut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    insertKomut.Parameters.AddWithValue("@Sifre", sifre);

                    // Komutun çalıştırılması
                    int result = insertKomut.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt başarılı! Şifreniz: " + sifre);
                    TxtKullaniciAdi.Text = "";
                    TxtSifre.Text = "";
                    
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız!");
                    }
                }
            
           
                baglanti.Close();
            
        }

        private void imgCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgCikis_MouseLeave(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.NavajoWhite;
        }

        private void imgCikis_MouseHover(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightSeaGreen;
        }
    }
}
