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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {

                SqlCommand komut = new SqlCommand(" SELECT * FROM admin WHERE yoneticiad=@p1 AND yoneticisifre=@p2 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    FrmAnaFrom fr = new FrmAnaFrom();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı girişi ya da şifre");
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                    txtKullaniciAdi.Focus();

                }
                bgl.baglanti().Close();
            }

        }
    }

