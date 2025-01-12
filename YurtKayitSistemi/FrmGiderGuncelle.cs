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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }

        public string elektrik, su, dogalgaz, gida, diger, internet, personel,id;

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

        SqlBaglantim bgl = new SqlBaglantim();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("UPDATE Giderler SET Elektrik=@p1,Su=@p2, Doğalgaz=@p3, internet=@p4, Gida=@p5, Personel=@p6,Diger=@p7 WHERE Odemeid=@p8 ",bgl.baglanti());
                komut.Parameters.AddWithValue("@p8",txtGiderid.Text);
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGida.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme yapılmıştır");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Geçerli değer giriniz");
            }
           
        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtinternet.Text = internet;
            txtGida.Text = gida;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
            txtGiderid.Text = id;


        }
    }
}
