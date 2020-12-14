using DemoProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject.Views
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            gridUsers.DataSource = UserController.GetAllUsers();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dynamic user = UserController.GetUser(tBSearch.Text);
            if (user != null)
            {
                tBName.Text = user.Name;
                tBUsername.Text = user.Username;
            }
            else {
                tBName.Text = "";
                tBUsername.Text = "";
                MessageBox.Show("Can not find user");
            }
            
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var user = new{
                Name = tBName.Text,
                Username = tBUsername.Text,
            };
            var r = UserController.UpdateUser(user);
            if (r)
            {
                MessageBox.Show("Success on Update");
                gridUsers.DataSource = UserController.GetAllUsers();
            }
            else {
                MessageBox.Show("Could not Update");
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var r = UserController.DeleteUser(tBUsername.Text);
            if (r) {
                tBName.Text = "";
                tBUsername.Text = "";
                MessageBox.Show("Success on Update");
                gridUsers.DataSource = UserController.GetAllUsers();

            }
            else
            {
                tBName.Text = "";
                tBUsername.Text = "";
                MessageBox.Show("Can not Delete");
            }
        }
    }
}
