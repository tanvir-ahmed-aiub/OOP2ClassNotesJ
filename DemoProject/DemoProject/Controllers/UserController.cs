using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoProject.Models;

namespace DemoProject.Controllers
{
    public class UserController
    {
        static Database db = new Database();
        public static User AuthenticateUser(string username, string password) {
            return db.Users.AuthenticateUser(username, password);
        }
        public static bool AddUser(dynamic u) {
            User user = new User();
            user.Name = u.Name;
            user.Username = u.Username;
            user.Password = u.Password;
           
            return db.Users.AddUser(user);
            
        }
        public static User GetUser(string username) {
            return db.Users.GetUser(username);
        }
        public static bool UpdateUser(dynamic u) {
            User user = new User();
            user.Name = u.Name;
            user.Username = u.Username;
            return db.Users.UpdateUser(user);
        }
        public static bool DeleteUser(string username) {
            return db.Users.DeleteUser(username);
        }
        public static ArrayList GetAllUsers() {
            return db.Users.GetAllUsers();
        }
    }
}
