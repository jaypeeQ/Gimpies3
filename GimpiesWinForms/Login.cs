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
    public partial class Login : Form
    {
        public Login()
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
            bool IN = false;
            Login.loginAttempt++;
            do
            {
                if (Login.loginAttempt >= 3)
                {
                    MessageBox.Show("You've logged in 3 times unsuccessfully. Application will now close.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Login.loginAttempt = 0;
                    
                    this.Close();
                }
                else if (tbUsername.Text == "Verkoop" && tbPassword.Text == "Gimpies_Verkoop")
                {

                    DashboardVerkoop dashboardverkoop = new DashboardVerkoop();
                    dashboardverkoop.Show();
                    Login.loginAttempt = 0;
                    IN = true;
                    this.Hide();
                }
                else if (tbUsername.Text == "Admin" && tbPassword.Text == "Gimpies_Admin")
                {

                    DashboardAdmin dashboardAdmin = new DashboardAdmin();
                    dashboardAdmin.Show();
                    Login.loginAttempt = 0;
                    IN = true;
                    this.Hide();
                }
                else if (tbUsername.Text == "" && tbPassword.Text == "")
                {

                    MessageBox.Show("You can't leave the fields blank.", "Username and password needs to be provided.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (tbUsername.Text != "Verkoop" && tbPassword.Text != "Gimpies_Verkoop")
                {
                    MessageBox.Show("Wrong credentials given.", "ERROR.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbUsername.Text != "Admin" && tbPassword.Text != "Gimpies_Admin")
                {
                    MessageBox.Show("Wrong credentials given.", "ERROR.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } while (!IN);
        }

        public static int loginAttempt;
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
