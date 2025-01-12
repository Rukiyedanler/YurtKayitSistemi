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

namespace YurtKayitSistemi
{
    public partial class FrmGelirIstatistikleri : Form
    {
        public FrmGelirIstatistikleri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmGelirIstatistikleri_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam tutar
            SqlCommand komut = new SqlCommand("SELECT SUM (OdemeMiktar) FROM Kasa",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasa.Text = oku[0].ToString() + "TL";    
                   }

            bgl.baglanti().Close();

            //Tekrarsız olarak ayları listeleme

            SqlCommand komut2 = new SqlCommand("SELECT DISTINCT (OdemeAY) FROM Kasa ",bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0]).ToString();

            }
            bgl.baglanti().Close();

            //Grafiklere veri tabanından veri çekme

            SqlCommand komut3 = new SqlCommand(" SELECT OdemeAy, SUM(OdemeMiktar) FROM Kasa GROUP BY OdemeAy ",bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();
            

        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT SUM (odememiktar) FROM Kasa WHERE OdemeAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAyKazanc.Text = oku[0].ToString();
            }

            bgl.baglanti().Close();
        }

        private void btnDonme_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Ana Menüye dönmek istediğinizden emin misiniz",
            " Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                FrmAnaFrom fr = new FrmAnaFrom();
                this.Close();
                fr.Show();
            }
            else
            {

                //No ise yapmasını istediğiniz...
            }
        }
    }
}
