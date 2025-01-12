using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-K6TF7C1\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
