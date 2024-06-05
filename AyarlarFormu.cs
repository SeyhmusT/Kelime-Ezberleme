using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ezberleme_Oyunu
{
    
    public partial class AyarlarFormu : Form
    {
        public AyarlarFormu()
        {
            InitializeComponent();
        }
        public int soruSayisi;
       

        private void imgCikis_MouseHover(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.LightBlue;

        }

        private void imgCikis_MouseLeave(object sender, EventArgs e)
        {
            imgCikis.BackColor = Color.DarkSalmon;
        }

        private void imgCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            soruSayisi = 10;
            this.Close();
            MessageBox.Show("Soru Sayısı 10 Olmuştur!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        


        }

        private void Btn8_Click(object sender, EventArgs e)
        {

            soruSayisi = 8;
            this.Close();
            MessageBox.Show("Soru Sayısı 8 Olmuştur!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            soruSayisi = 5;
            this.Close();
            MessageBox.Show("Soru Sayısı 5 Olmuştur!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            soruSayisi = 4;
            this.Close();
           
            MessageBox.Show("Soru Sayısı 4 Olmuştur!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AyarlarFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
