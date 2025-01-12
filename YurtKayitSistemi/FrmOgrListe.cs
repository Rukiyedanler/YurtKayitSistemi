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
    public partial class FrmOgrListe : Form
    {
        public FrmOgrListe()
        {
            InitializeComponent();
        }

        private void FrmOgrListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet33.Ogrenci_table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenci_tableTableAdapter3.Fill(this.yurtOtomasyonuDataSet33.Ogrenci_table);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet32.Ogrenci_table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenci_tableTableAdapter2.Fill(this.yurtOtomasyonuDataSet32.Ogrenci_table);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet30.Ogrenci_table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenci_tableTableAdapter1.Fill(this.yurtOtomasyonuDataSet30.Ogrenci_table);
            try
            {
                this.yurtOtomasyonuDataSet4.EnforceConstraints = false; // Kısıtlamaları geçici olarak kapat
                this.ogrenci_tableTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Ogrenci_table);
                this.yurtOtomasyonuDataSet4.EnforceConstraints = true; // Kısıtlamaları tekrar aç
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            
            fr.ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.veliad = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.adres = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            this.Close();
            fr.Show();
           


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();

            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.veliad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.adres = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            this.Close();
            fr.Show();
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
