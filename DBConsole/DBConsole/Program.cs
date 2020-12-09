using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBConsole
{
    class Program
    {
        public static void ShowAllUsers() {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id\tName\tEmail\t");
            while (reader.Read())
            {

                string id = reader.GetString(reader.GetOrdinal("Id"));
                string name = reader.GetString(reader.GetOrdinal("Name"));
                string email = reader.GetString(reader.GetOrdinal("Email"));
                double cgpa = reader.GetDouble(reader.GetOrdinal("Cgpa"));
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, name, email, cgpa);
            }
            conn.Close();
        }
        static void InsertCourse(string cCode,string cName) {
            var conn = Database.ConnectDB();
            conn.Open();
            //string query = "INSERT INTO Courses VALUES ('"+ cCode + "','"+ cName + "')";
   
            string query = String.Format("INSERT INTO Courses VALUES ('{0}','{1}')", cCode, cName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {

                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Not Added");
            }
            conn.Close();
        }
        static void Main(string[] args)
        {
            ShowAllUsers();
            InsertCourse("CSC04","IntroDb");
        }
    }
}
