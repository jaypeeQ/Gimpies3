using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimpiesWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            int loginAttempts = 0;
            if (loginAttempts == 3)
            {
                MessageBox.Show("You have attempted to log in too many times. This application will now close.", "ERROR.",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            int loginAttempts = 0;
            loginAttempts++;
                if (tbUsername.Text == "Verkoop" || tbPassword.Text == "Gimpies_Verkoop")
                {
                    
                    DashboardVerkoop dashboardverkoop = new DashboardVerkoop();
                    dashboardverkoop.Show();
                    this.Hide();
                }
                if (tbUsername.Text == "Admin" || tbPassword.Text == "Gimpies_Admin")
                {
                    
                    DashboardAdmin dashboardAdmin = new DashboardAdmin();
                    dashboardAdmin.Show();
                    this.Hide();
                }
                if (tbUsername.Text == "" || tbPassword.Text == "")
                {
                    loginAttempts++;
                    MessageBox.Show("You can't leave the fields blank.", "Username and password needs to be provided.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                if (tbUsername.Text != "Verkoop" || tbPassword.Text != "Gimpies_Verkoop" && tbUsername.Text != "Verkoop" || tbPassword.Text != "Gimpies_Verkoop")
                {
                    MessageBox.Show("Wrong credentials given.", "ERROR.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginAttempts++;
                }
                
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
