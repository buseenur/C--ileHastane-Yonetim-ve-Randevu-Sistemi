using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Yönetim_Randevu_Sistemi
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-70RL3KF\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
            
    }
}
