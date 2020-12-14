using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoProject.Models
{
    class Database
    {
        public Users Users { get; set; }
        public Products Products { get; set; }
        public Categories Categories { get; set; }
        public Database() {
            string connString = "Server=DESKTOP-1HKAK02;Integrated Security=true;Database=inventory_j";
            SqlConnection conn = new SqlConnection(connString);
            Users = new Users(conn);
            Products = new Products();
            Categories = new Categories();

        }
    }
}
