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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        // Burada projemi Sql Server'a bağladım. baglanti adında da bir nesne oluşturdum ki veri çekerken bu nesneyi kullanayım diye 



        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            


            // Bölümleri Listeleme Komutları
            
            // Bölümleri listelemek için SQl komutu oluşturdum
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) // Sadece veri varsa çalışır
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }

            bgl.baglanti().Close();

            // Boş Odaları Listeleme Komutları


            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite > OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // TC kimlik numarasını kontrol etmek için SQL sorgusu
            SqlCommand tcKontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM Ogrenci_table WHERE OgrTC = @tc", bgl.baglanti());
            tcKontrolKomutu.Parameters.AddWithValue("@tc", txtEdtTC.Text);
            int kayitSayisi = Convert.ToInt32(tcKontrolKomutu.ExecuteScalar());
            bgl.baglanti().Close();

            if (kayitSayisi > 0)
            {
                // Eğer aynı TC kimlik numarası varsa kullanıcıya mesaj göster
                MessageBox.Show("Bu TC kimlik numarasına sahip bir öğrenci zaten kayıtlıdır. Lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemi sonlandır
            }

            // Öğrenci kayıt işlemi gerçekleşmektedir.
            SqlCommand komutkaydet = new SqlCommand("INSERT INTO Ogrenci_table (OgrAd, OgrSoyad, OgrTC, OgrTelefon, OgrDogum, OgrBolum, OgrMail, OgrOdaNo, OgrVeliAdSoyad, OgrVeliAdres) " +
                "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", bgl.baglanti());

            komutkaydet.Parameters.AddWithValue("@p1", txtEdtOgrAd.Text);
            komutkaydet.Parameters.AddWithValue("@p2", txtEdtOgrSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", txtEdtTC.Text);
            komutkaydet.Parameters.AddWithValue("@p4", txtEdtOgrTelefon.Text);
            DateTime now = DateTime.Now;
            komutkaydet.Parameters.AddWithValue("@p5", now);
            komutkaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
            komutkaydet.Parameters.AddWithValue("@p7", txtEdtMail.Text);
            komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
            komutkaydet.Parameters.AddWithValue("@p9", txtEdtVeliAdSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p10", rchAdres.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Öğrenci ID'yi labele çekme
            SqlCommand komut = new SqlCommand("SELECT Ogrid FROM Ogrenci_table WHERE OgrTC = @tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", txtEdtTC.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                label12.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();

            // Öğrenci borç alanı oluşturma
            SqlCommand komutkaydet2 = new SqlCommand("INSERT INTO Borclar (Ogrid, OgrAd, OgrSoyad) VALUES (@b1, @b2, @b3)", bgl.baglanti());
            komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
            komutkaydet2.Parameters.AddWithValue("@b2", txtEdtOgrAd.Text);
            komutkaydet2.Parameters.AddWithValue("@b3", txtEdtOgrSoyad.Text);
            komutkaydet2.ExecuteNonQuery();
            bgl.baglanti().Close();

            // Öğrenci oda aktif sayısını arttırma
            SqlCommand komutoda = new SqlCommand("UPDATE Odalar SET OdaAktif = OdaAktif + 1 WHERE OdaNo = @k1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@k1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
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
//Data Source=DESKTOP-K6TF7C1\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True