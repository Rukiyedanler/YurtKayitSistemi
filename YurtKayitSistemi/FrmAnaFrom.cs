using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace YurtKayitSistemi
{
    public partial class FrmAnaFrom : Form
    {
        public FrmAnaFrom()
        {
            InitializeComponent();
        }

        private void FrmAnaFrom_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet12.Ogrenci_table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenci_tableTableAdapter2.Fill(this.yurtOtomasyonuDataSet12.Ogrenci_table);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet11.Ogrenci_table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenci_tableTableAdapter1.Fill(this.yurtOtomasyonuDataSet11.Ogrenci_table);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet10.Ogrenci_table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenci_tableTableAdapter.Fill(this.yurtOtomasyonuDataSet10.Ogrenci_table);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet1.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Ogrenci);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        

        

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmOgrKayit fr = new FrmOgrKayit();
            this.Close();
            fr.Show();
        }

        private void ogrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            this.Close();
            fr.Show();
        }

        private void ogrenciDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            this.Close();
            fr.Show();
        }

        

        private void bolumDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            this.Close();
            fr.Show();
        }

        private void odemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            this.Close();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider fr = new FrmGider();
            this.Close();
            fr.Show();
        }

        private void gİderListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi fr = new FrmGiderListesi();
            this.Close();
            fr.Show();
        }

        private void gelirİsrtatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistikleri fr = new FrmGelirIstatistikleri();
            this.Close();
            fr.Show();
        }

        private void sifreİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle fr = new FrmYoneticiDuzenle();
            this.Close();
            fr.Show();
        }

        private void personelDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel fr = new FrmPersonel();
            this.Close();

            fr.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotEkle fr = new FrmNotEkle();
            this.Close();

            fr.Show();
        }

        private void cıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            this.Close();

            fr.Show();
        }

        private void btnMuzik_Click(object sender, EventArgs e)
        {

            string playlistUrl = "https://music.youtube.com/playlist?list=RDCLAK5uy_nkN2Fde5lIJN38ta7Tyvr8Uona03aHnRo&autoplay=1";
            try
            {
                // Eski .NET Framework için doğrudan Process.Start yöntemi
                Process.Start(playlistUrl);
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Çalma listesi açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu otomasyon 2025 yılında Rukiye Nur Danler tarafından yapılmıştır. " , "Öğrenci Yurt Otomasyonu",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.Exe");
        }
    }
    }

