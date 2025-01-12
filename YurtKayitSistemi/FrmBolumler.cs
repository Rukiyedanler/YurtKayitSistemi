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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        // Buarada projemi Sql Server'a bağladım. baglanti adında da bir nesne oluşturdum ki veri çekerken bu nesneyi kullanayım diye 

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet29.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter4.Fill(this.yurtOtomasyonuDataSet29.Bolumler);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet28.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter3.Fill(this.yurtOtomasyonuDataSet28.Bolumler);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet26.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter2.Fill(this.yurtOtomasyonuDataSet26.Bolumler);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet25.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter1.Fill(this.yurtOtomasyonuDataSet25.Bolumler);
            // Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }


        int secilen;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id, bolumad;
                secilen = dataGridView1.SelectedCells[0].RowIndex; // tıklandığında hafızaya aldığı hücre değeri
                if (dataGridView1.Rows[secilen].Cells[0].Value != null)
                {
                    id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seçili hücrede veri yok.");
                    return;
                }
                // seçilen hücresinin satır indeksi
                bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

                txtBolumId.Text = id;
                txtBolumAdi.Text = bolumad;


            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!!!");

            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // SimpleButton'un click eventi boş bırakılmış. 
        }

        private void pcbBolumEkle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBolumAdi.Text))
            {
                MessageBox.Show("Bölüm adı boş bırakılamaz.");
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                
                SqlCommand komut1 = new SqlCommand("INSERT INTO Bolumler (BolumAd) VALUES (@p1)", conn);
                komut1.Parameters.AddWithValue("@p1", txtBolumAdi.Text);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Bölüm eklendi.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
        }

        private void pcbBolumSil_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBolumId.Text))
            {
                MessageBox.Show("Lütfen bir bölüm seçin.");
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {

                SqlCommand komut2 = new SqlCommand("DELETE FROM Bolumler WHERE Bolumid=@p1", conn);
                komut2.Parameters.AddWithValue("@p1", txtBolumId.Text);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarılı.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
        }

        private void pcbBolumDuzenle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBolumId.Text) || string.IsNullOrEmpty(txtBolumAdi.Text))
            {
                MessageBox.Show("Bölüm ID ve Adı boş bırakılamaz.");
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                
                SqlCommand komut3 = new SqlCommand("UPDATE Bolumler SET BolumAd=@p1 WHERE Bolumid=@p2", conn);
                komut3.Parameters.AddWithValue("@p1", txtBolumAdi.Text);
                komut3.Parameters.AddWithValue("@p2", txtBolumId.Text);
                komut3.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
        }

        

        private void btnDonme_Click_1(object sender, EventArgs e)
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
