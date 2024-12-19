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
            // Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }

        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut1 = new SqlCommand("INSERT INTO Bolumler VALUES @p1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAdi.Text);

                //Değişiklikleri kaydetme
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bolum eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin");
            }
        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand(" DELETE FROM Bolumler WHERE Bolumid=@p1 ", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silem işlemi gerçekleşti");

                // DataGridView'i güncelle
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! İşlem Gerçekleştirilemedi\n");
            }
        }




        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); // 

                txtBolumId.Text = id;
                txtBolumAdi.Text = bolumad;


            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!!!");
                throw;
            }

        }
        private void pcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("UPDATE Bolumler SET BolumAd=@p1 WHERE Bolumid = @p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", txtBolumId.Text);
                komut2.Parameters.AddWithValue("@p1", txtBolumAdi.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Gerçekleştirildi");

                // Veriyi yeniden yükleyerek DataGridView'i güncelliyorum
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // SimpleButton'un click eventi boş bırakılmış. 
        }
    }
}
