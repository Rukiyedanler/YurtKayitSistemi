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
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmYoneticiDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet34.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet34.Admin);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet8.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand(" INSERT INTO Admin (YoneticiAd, YoneticiSifre) VALUES (@p1, @p2) ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2 ", txtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yönetici Eklendi");
                this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
            }
            catch (Exception)
            {

                MessageBox.Show("Hataa!! Yönetici eklenemedi");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre;
            
            ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtKullaniciAdi.Text = ad;
            txtSifre.Text = sifre;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" DELETE FROM Admin WHERE Yoneticiid=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi gerçekleştirilmiştir");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Admin SET YoneticiAd=@p1, YoneticiSifre=@p2 WHERE Yoneticiid=@p3 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", txtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Guncelleme işlemi gerçekleştirilmiştir");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
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

