using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ener_Otomasyon
{
    internal class sqlBaglanti
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-B6049VU;Initial Catalog=Ener;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
