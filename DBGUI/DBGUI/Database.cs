using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DBGUI
{
    public class Database
    {
        public static SqlConnection ConnectDB() {
            string connString = "Server=DESKTOP-1HKAK02;Database=aiub_ums_j;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
