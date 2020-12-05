using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Th11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterClick(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string errMsg = "";
            bool hasError = false;

            if (textBoxUsername.Text.Equals(""))
            {
                errMsg += "Username Required";
                hasError = true;
            }
            else
            {
                username = textBoxUsername.Text;
            }
            if(textBoxPassword.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
                hasError = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }
            if (!hasError) {
                if (username.Equals("Tanvir") && password.Equals("12345678"))
                {
                    User u = new User();
                    u.Name = username;
                    u.Password = password;
                    //other values from DB
                    new Dashboard(u).Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
    }
}
