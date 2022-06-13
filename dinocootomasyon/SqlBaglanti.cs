using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dinocootomasyon
{
    public class SqlBaglanti
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6A84IV3\\SQLEXPRESS;Initial Catalog=otobus;Integrated Security=True");
    }
}
