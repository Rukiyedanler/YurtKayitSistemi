using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        public string id, ad, soyad, TC, telefon, dogum, bolum, mail, odano, veliad, velitel, adres;
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            
            // Form yüklenirken öğrenci bilgilerini doldurma
            txtid.Text = id;
            txtEdtOgrAd.Text = ad;
            txtEdtOgrSoyad.Text = soyad;
            txtEdtTC.Text = TC;
            txtEdtOgrTelefon.Text = telefon;
            txtEdtDogum.Text = dogum;
            cmbBolum.Text = bolum;
            txtEdtMail.Text = mail;
            cmbOdaNo.Text = odano;
            txtEdtVeliAdSoyad.Text = veliad;
            rchAdres.Text = adres;

            // Bölümleri yükleme
            try
            {
                SqlCommand komutBolum = new SqlCommand("SELECT BolumAd FROM Bolumler", bgl.baglanti());
                SqlDataReader dr = komutBolum.ExecuteReader();

                while (dr.Read())
                {
                    cmbBolum.Items.Add(dr["BolumAd"].ToString());
                }

                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bölümler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnDonme_Click(object sender, EventArgs e)
        {
            // Ana menüye dönme işlemi
            DialogResult result = MessageBox.Show("Ana Menüye dönmek istediğinizden emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FrmAnaFrom fr = new FrmAnaFrom();
                this.Close();
                fr.Show();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Öğrenci silme işlemi
            try
            {
                DialogResult result = MessageBox.Show("Kişiyi silmek istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand komutSil = new SqlCommand("DELETE FROM Ogrenci_table WHERE OgrTC=@k1", bgl.baglanti());
                    komutSil.Parameters.AddWithValue("@k1", txtEdtTC.Text);
                    komutSil.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    SqlCommand komutOda = new SqlCommand("UPDATE odalar SET OdaAktif = OdaAktif - 1 WHERE OdaNo = @oda", bgl.baglanti());
                    komutOda.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
                    komutOda.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Kayıt silindi.");

                    FrmOgrListe fr = new FrmOgrListe();
                    this.Close();
                    fr.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! İşlem gerçekleştirilemedi: " + ex.Message);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kişiyi güncellemek istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // ID kontrolü
                    if (string.IsNullOrEmpty(txtid.Text) || !int.TryParse(txtid.Text, out int id))
                    {
                        MessageBox.Show("Geçerli bir öğrenci ID'si giriniz.");
                        return;
                    }

                    // Tarih kontrolü
                    DateTime dogumTarihi;
                    if (!DateTime.TryParse(txtEdtDogum.Text, out dogumTarihi))
                    {
                        MessageBox.Show("Geçerli bir doğum tarihi giriniz.");
                        return;
                    }

                    using (SqlConnection conn = bgl.baglanti())
                    {
                       
                            SqlCommand komut = new SqlCommand("UPDATE Ogrenci_table SET OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5, OgrDogum=@p6, OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliAdres=@p11 WHERE Ogrid=@p1", conn);

                            komut.Parameters.AddWithValue("@p1", txtid.Text);
                            komut.Parameters.AddWithValue("@p2", txtEdtOgrAd.Text);
                            komut.Parameters.AddWithValue("@p3", txtEdtOgrSoyad.Text);
                            komut.Parameters.AddWithValue("@p4", txtEdtTC.Text);
                            komut.Parameters.AddWithValue("@p5", txtEdtOgrTelefon.Text);
                            komut.Parameters.AddWithValue("@p6", dogumTarihi);
                            komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
                            komut.Parameters.AddWithValue("@p8", txtEdtMail.Text);
                            komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                            komut.Parameters.AddWithValue("@p10", txtEdtVeliAdSoyad.Text);
                            komut.Parameters.AddWithValue("@p11", rchAdres.Text);

                            int rowsAffected = komut.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Güncelleme işlemi başarılı.");
                            }
                            else
                            {
                                MessageBox.Show("Güncellenen herhangi bir kayıt bulunamadı.");
                            }
                        
                     
                    }

                    FrmOgrListe fr = new FrmOgrListe();
                    this.Close();
                    fr.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! İşlem gerçekleştirilemedi: " + ex.Message);
            }
        }


    }
}
