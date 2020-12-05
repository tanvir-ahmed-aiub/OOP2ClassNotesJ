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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = textBoxName.Text;
            u.Email = textBoxEmail.Text;
            u.Profession = comboBoxProf.SelectedItem.ToString();

            RadioButton rb = groupBoxGn.Controls.OfType<RadioButton>().FirstOrDefault(n=>n.Checked);
            u.Gender = rb.Text;

            /*string output = String.Format("Name: {0}" +
                "\nEmail: {1}" +
                "\nProfession: {2}" +
                "\nGender: {3}", name, email,profession,gender);
            
            rTOutput.Text = output;*/

            new Dashboard(u).Show();
        }
    }
}
