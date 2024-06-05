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
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace Kelime_Ezberleme_Oyunu
{
    public partial class SınavEkranı : Form
    {
        public SınavEkranı()
        {
            InitializeComponent();
            frm.ShowDialog();
            soruSayisi = frm.soruSayisi;
            kalanSoruSayisi = soruSayisi;
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SeyhmusPC;Initial Catalog=KELİME_EZBERLEME;Integrated Security=True");


        int kalanSoruSayisi;
        string resimYolu;
        AyarlarFormu frm = new AyarlarFormu();
        public int soruSayisi;
        SqlDataReader dr;
        List<string> listeyeEkle = new List<string>();
        
        void yeniSoruGetir0()
        {
            listeyeEkle.Clear();
            Random rastgele = new Random();
            List<int> sınavListesi = new List<int>();
            List<int> sorularListesi = new List<int>();

            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu hazırla
            SqlCommand komut = new SqlCommand("SELECT SoruID FROM SORULAR WHERE SoruDogruBilinme = 0", baglanti);

            // SQL komutunu çalıştır ve sonuçları SqlDataReader nesnesine al
            using (SqlDataReader reader = komut.ExecuteReader())
            {
                // SqlDataReader'dan veri oku
                while (reader.Read())
                {
                    // İlgili sütundaki değeri al ve listeye ekle
                    sorularListesi.Add(reader.GetInt32(0)); // SoruID sütunu
                }
            }

            // Veritabanı bağlantısını kapat
            baglanti.Close();

            // Rastgele 4 soru seç ve sınavListesi'ne ekle
            
            
                int rastgeleIndex = rastgele.Next(0, sorularListesi.Count);
                int secilenSoruID = sorularListesi[rastgeleIndex];
                sınavListesi.Add(secilenSoruID);
            
            

            
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM SORULAR WHERE SoruID = @p1",baglanti);
            komut1.Parameters.AddWithValue("@p1", sınavListesi[0]);
            komut1.ExecuteNonQuery();
            
           dr = komut1.ExecuteReader();
           
            while (dr.Read()) {

                LblKelime.Text = dr[2].ToString();
                LblCevap.Text = dr[1].ToString();
                listeyeEkle.Add(dr[0].ToString());
                listeyeEkle.Add(dr[1].ToString());
                listeyeEkle.Add(dr[2].ToString());
                listeyeEkle.Add(dr[3].ToString());
                listeyeEkle.Add(dr[4].ToString());
                listeyeEkle.Add(dr[5].ToString());
                resimYolu = dr[4].ToString();
               

            }




            ImgKelimeResim.Image = Image.FromFile(@resimYolu);
            



            baglanti.Close();
          

        }
        void bilinmisSoruGetir()
        {
            listeyeEkle.Clear();
            List<int> bilinmisSorularListesi = new List<int>();
            List<int> bilinmisSorularSinavListesi = new List<int>();

            
            baglanti.Open();

           
            SqlCommand komut = new SqlCommand("SELECT SoruID FROM SORULAR WHERE mevcutTarih = cikacakTarih", baglanti);

            // SQL komutunu çalıştır ve sonuçları SqlDataReader nesnesine al
            using (SqlDataReader reader = komut.ExecuteReader())
            {
                // SqlDataReader'dan veri oku
                while (reader.Read())
                {
                    // İlgili sütundaki değeri al ve listeye ekle
                    bilinmisSorularListesi.Add(reader.GetInt32(0)); // SoruID sütunu
                }
            }

            // Veritabanı bağlantısını kapat
            baglanti.Close();

            
                Random rastgele = new Random();
                int rastgeleIndex = rastgele.Next(0, bilinmisSorularListesi.Count);
                int secilenSoruID = bilinmisSorularListesi[rastgeleIndex];
                bilinmisSorularSinavListesi.Add(secilenSoruID);


            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM SORULAR WHERE SoruID = @p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", bilinmisSorularSinavListesi[0]);
            komut1.ExecuteNonQuery();

            dr = komut1.ExecuteReader();

            while (dr.Read())
            {

                LblKelime.Text = dr[2].ToString();
                LblCevap.Text = dr[1].ToString();
                listeyeEkle.Add(dr[0].ToString());
                listeyeEkle.Add(dr[1].ToString());
                listeyeEkle.Add(dr[2].ToString());
                listeyeEkle.Add(dr[3].ToString());
                listeyeEkle.Add(dr[4].ToString());
                listeyeEkle.Add(dr[5].ToString());
                resimYolu = dr[4].ToString();


            }




            ImgKelimeResim.Image = Image.FromFile(@resimYolu);




            baglanti.Close();




        }


        int sayac = 0;
        private void SınavEkranı_Load(object sender, EventArgs e)
        {

            if (kalanSoruSayisi > 0)
            {
                
                yeniSoruGetir0();
                kalanSoruSayisi--; 
            }
            else
            {
                try
                {
                    bilinmisSoruGetir();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sınav Bitti!");
                    baglanti.Open();
                    SqlCommand komut7 = new SqlCommand("UPDATE SORULAR SET mevcutTarih = DATEADD(day,1,mevcutTarih)", baglanti);
                    komut7.ExecuteNonQuery();
                    baglanti.Close();

                    this.Close();
                }
            }



        }


        
        private void BtnCevap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            if (TxtCevap.Text == listeyeEkle[1])
            {
                
                SqlCommand komut = new SqlCommand("UPDATE SORULAR SET SoruDogruBilinme+=1 WHERE SoruID = @p1",baglanti);
                komut.Parameters.AddWithValue("@p1", listeyeEkle[0]);

                komut.ExecuteNonQuery();
                
                
                switch (listeyeEkle[3])
                {
                    
                    case "0": SqlCommand komut1 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,1,mevcutTarih) WHERE SoruID = @p1", baglanti);
                        komut1.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                        komut1.ExecuteNonQuery();
                        break;
                    case "1":
                        SqlCommand komut2 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,7,mevcutTarih) WHERE SoruID = @p1", baglanti);
                        komut2.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                        komut2.ExecuteNonQuery();
                        break;
                    case "2":
                        SqlCommand komut3 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,30,mevcutTarih) WHERE SoruID = @p1", baglanti);
                        komut3.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                        komut3.ExecuteNonQuery();
                        break;
                        case "3":
                        SqlCommand komut4 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,90,mevcutTarih) WHERE SoruID = @p1", baglanti);
                        komut4.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                        komut4.ExecuteNonQuery();
                        break;
                        case "4":
                        SqlCommand komut5 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,180,mevcutTarih) WHERE SoruID = @p1", baglanti);
                        komut5.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                        komut5.ExecuteNonQuery();
                        break;
                    case "5":
                        SqlCommand komut6 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,360,mevcutTarih) WHERE SoruID = @p1", baglanti);
                        komut6.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                        komut6.ExecuteNonQuery();
                        break;
                }
                
            }

            else
            {
                SqlCommand komut6 = new SqlCommand("UPDATE SORULAR SET SoruDogruBilinme = 0,cikacakTarih = NULL WHERE SoruID = @p1", baglanti);
                komut6.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                komut6.ExecuteNonQuery();
            }

            baglanti.Close();
            TxtCevap.Text = "";

            if (kalanSoruSayisi > 0)
            {
                // Hala belirtilen kadar doğru bilinmemiş soru varsa
                yeniSoruGetir0();
                kalanSoruSayisi--; // Bir soru getirildiğinden sayacı azalt
            }
            else
            {
                try
                {
                    bilinmisSoruGetir();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sınav Bitti!");
                    baglanti.Open();
                    SqlCommand komut7 = new SqlCommand("UPDATE SORULAR SET mevcutTarih = DATEADD(day,1,mevcutTarih)", baglanti);
                    komut7.ExecuteNonQuery();
                    baglanti.Close();
                    this.Close();
                }
            }

        }

        private void BtnSinavBitir_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (TxtCevap.Text == listeyeEkle[1])
            {

                SqlCommand komut = new SqlCommand("UPDATE SORULAR SET SoruDogruBilinme+=1 WHERE SoruID = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", listeyeEkle[0]);

                komut.ExecuteNonQuery();

                if (TxtCevap.Text != "")
                {
                    switch (listeyeEkle[3])
                    {

                        case "0":
                            SqlCommand komut1 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,1,mevcutTarih) WHERE SoruID = @p1", baglanti);
                            komut1.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                            komut1.ExecuteNonQuery();
                            break;
                        case "1":
                            SqlCommand komut2 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,7,mevcutTarih) WHERE SoruID = @p1", baglanti);
                            komut2.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                            komut2.ExecuteNonQuery();
                            break;
                        case "2":
                            SqlCommand komut3 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,30,mevcutTarih) WHERE SoruID = @p1", baglanti);
                            komut3.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                            komut3.ExecuteNonQuery();
                            break;
                        case "3":
                            SqlCommand komut4 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,90,mevcutTarih) WHERE SoruID = @p1", baglanti);
                            komut4.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                            komut4.ExecuteNonQuery();
                            break;
                        case "4":
                            SqlCommand komut5 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,180,mevcutTarih) WHERE SoruID = @p1", baglanti);
                            komut5.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                            komut5.ExecuteNonQuery();
                            break;
                        case "5":
                            SqlCommand komut6 = new SqlCommand("UPDATE SORULAR SET cikacakTarih = DATEADD(day,360,mevcutTarih) WHERE SoruID = @p1", baglanti);
                            komut6.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                            komut6.ExecuteNonQuery();
                            break;
                    }
                }

            }

            else
            {
                SqlCommand komut6 = new SqlCommand("UPDATE SORULAR SET SoruDogruBilinme = 0,cikacakTarih = NULL WHERE SoruID = @p1", baglanti);
                komut6.Parameters.AddWithValue("@p1", listeyeEkle[0]);
                komut6.ExecuteNonQuery();
            }

            
            SqlCommand komut7 = new SqlCommand("UPDATE SORULAR SET mevcutTarih = DATEADD(day,1,mevcutTarih)", baglanti);
            komut7.ExecuteNonQuery();
            baglanti.Close();
            this.Close();

        }

       
    }

}