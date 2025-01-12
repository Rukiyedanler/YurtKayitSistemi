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



            FrmAdminGiris  adminGirisFormu = new FrmAdminGiris();
            adminGirisFormu.Show();

            Application.Run(); // Mesaj döngüsünü başlat
        }

    }
}