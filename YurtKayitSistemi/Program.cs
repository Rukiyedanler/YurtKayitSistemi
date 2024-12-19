using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    static class Program
    { 
        /// Uygulamanın ana girdi noktası.
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmAnaFrom anaForm = new FrmAnaFrom();
            FrmOgrKayit ogrKayitFormu = new FrmOgrKayit();
            FrmBolumler bolumlerFormu = new FrmBolumler();


            anaForm.Show();
            ogrKayitFormu.Show(); // İlk formu aç
            bolumlerFormu.Show(); // İkinci formu aç

            Application.Run(); // Mesaj döngüsünü başlat
        }

    }
}