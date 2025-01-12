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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            

            try
            {
                SqlCommand komut = new SqlCommand(" INSERT INTO Giderler (Elektrik,Su,Doğalgaz, internet, Gida,Personel,Diger) VALUES (@p1,@p2,@p3, @p4, @p5, @p6, @p7 )", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1",txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz .Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGida.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!Lütfen geçerli değerleri girin");
            }

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

