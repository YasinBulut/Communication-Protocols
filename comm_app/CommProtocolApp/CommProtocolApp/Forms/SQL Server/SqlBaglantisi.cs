using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommProtocolApp.Forms.SQL_Server
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8N9D;Initial Catalog=DBCONN;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
