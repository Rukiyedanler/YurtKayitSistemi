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
            cmbBolum.Items.Add(oku[0].ToString());
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
            //Öğrenci kayıt işlemi gerçekleşmektedir.

            try
            {
                
                // Ogrenci tablosuna yeni bir kayıt eklemek için SQL komutunu oluşturuyoruz.
                SqlCommand komutkaydet = new SqlCommand("INSERT INTO Ogrenci (OgrAd, OgrSoyad, OgrTC, OgrTelefon, OgrDogum, OgrBolum, OgrMail, OgrOdaNo, OgrVeliAdSoyad, OgrVeliTelefon, OgrVeliAdres) " +
                    "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)", bgl.baglanti());

                // Parametre olarak gelen öğrenci adı,soyadı adres gibi bilgileri SQL komutuna ekliyoruz.
                komutkaydet.Parameters.AddWithValue("@p1", txtEdtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtEdtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txtEdtTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", txtEdtOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", txtEdtDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtEdtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtEdtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", txtEdtVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchAdres.Text);

                // Komutu çalıştırarak veritabanına yeni kaydı ekliyoruz.
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarılı bir şekilde oluşturulmuştur");

                // Öğrenci id Yi labele çekme
                SqlCommand komut = new SqlCommand("SELECT Ogrid FROM Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();

                }
                bgl.baglanti().Close();


                //Öğrenci Borç ALanı oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("INSERT INTO Borclar (Ogrid,OgrAd, OgrSoyad) VALUES (@b1, @b2, @b3 )", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1",label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtEdtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3",txtEdtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!! Lütfen bir kere daha deneyiniz");
                throw;
            }
        }
    }
}
//Data Source=DESKTOP-K6TF7C1\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True