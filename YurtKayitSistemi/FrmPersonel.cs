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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet31.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter1.Fill(this.yurtOtomasyonuDataSet31.Personel);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet9.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand(" INSERT INTO Personel (PersonelAdSoyad, PersonelDepartman) VALUES (@p1, @p2) ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2 ", txtPersonelGorev.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Eklendi");
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);
            }
            catch (Exception)
            {

                MessageBox.Show("Hataa!! Personel eklenemedi");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string  ad, gorev;
            
            ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
            gorev = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtPersonelAd.Text = ad;
            txtPersonelGorev.Text = gorev;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" DELETE FROM Personel WHERE Personelid=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi gerçekleştirilmiştir");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE PErsonel SET PersonelAdSoyad=@p1, PersonelDepartman=@p2 WHERE Personelid=@p3 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Guncelleme işlemi gerçekleştirilmiştir");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);
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
