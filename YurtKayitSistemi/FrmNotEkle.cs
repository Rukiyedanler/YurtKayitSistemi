using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YurtKayitSistemi
{
    public partial class FrmNotEkle : Form
    {
        public FrmNotEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
             DialogResult result1 = MessageBox.Show(" Kaydetmek istediğinize emin misiniz? ",
            " Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                saveFileDialog1.Title = "Kayıt Yeri Seçin";
                saveFileDialog1.Filter = "Metin Dosyası | *.txt";
                saveFileDialog1.InitialDirectory = " E:\\ Notlar ";
                saveFileDialog1.ShowDialog();
                StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
                kaydet.WriteLine(richTextBox1.Text);
                kaydet.Close();
            }
            else
            {

                //No ise yapmasını istediğiniz...
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
