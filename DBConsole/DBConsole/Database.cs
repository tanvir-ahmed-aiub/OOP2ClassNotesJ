using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBConsole
{
    public class Database
    {
        public static SqlConnection ConnectDB() {
            //string connString = "Server=DESKTOP-1HKAK02;User Id=sa;Password=1234;Database=aiub_ums_j";
            string connString = "Server=DESKTOP-1HKAK02;Integrated Security=true;Database=aiub_ums_j";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
