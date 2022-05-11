using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLMARKET_V2
{
    class ConnectionStr
    {
        public SqlConnection con()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DTHSTGG\SQLMARKET; Initial Catalog = MARKET; Integrated Security = True");
            con.Open();
            return con;
        }
    }
}
