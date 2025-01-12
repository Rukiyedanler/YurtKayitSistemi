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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // 'Borclar' tablosuna veri yükler.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet27.Borclar);
        }

        private void btnOdemeAL_Click(object sender, EventArgs e)
        {
            // Ödenen tutarı eski tutardan düşme
            int odenen, kalanBorc, yeniBorc;
            odenen = Convert.ToInt16(txtOdenen.Text);
            kalanBorc = Convert.ToInt16(txtKalanBorc.Text);
            yeniBorc = kalanBorc - odenen;
            txtKalanBorc.Text = yeniBorc.ToString();

            // Veritabanına ödeme bilgilerini kaydetme
            SqlCommand komut = new SqlCommand("UPDATE Borclar SET OgrKalanBorc=@p1 WHERE OgrTc= @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrTC.Text);
            komut.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");

            // Kasa tablosuna ödeme kaydetme
            SqlCommand komut2 = new SqlCommand("INSERT INTO Kasa (OdemeAy, OdemeMiktar) VALUES (@k1, @k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            

            // Ödeme yapıldıktan sonra dataGridView'ı güncelleme (seçilen satıra ödeme sonrası kalan borç bilgilerini yansıtma)
            dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value = txtKalanBorc.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView'da bir hücreye tıklanınca, o satırdaki öğrenci bilgilerini alıp ilgili alanlara yazma
            int secilen;
            string TC, kalanBorc, ad, ad2;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad2 = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kalanBorc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            string adSoyad = ad + " " + ad2;  // Ad ve soyad arasına boşluk ekleyerek birleştiriyoruz
            txtAd.Text = adSoyad;
            txtKalanBorc.Text = kalanBorc;
            txtOgrTC.Text = TC;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Eğer ek bir işlem yapılması gerekirse, buraya yazılabilir.
        }

        private void btnDonme_Click(object sender, EventArgs e)
        {
            FrmAnaFrom fr = new FrmAnaFrom();
            this.Close();
            fr.Show();
        }
    }
}
