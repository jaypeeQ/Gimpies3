using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;


namespace GimpiesWinForms
{
    public partial class Login : Form
    {
        
        public static int loginAttempt;



        public Login()
        {
            InitializeComponent();

        }

       

        private void btLogin_Click(object sender, EventArgs e)
        {
            SQLSELECT.conn = new SqlConnection(SQLSELECT.connectionString);
            SQLSELECT.conn.Open();
            bool IN = false;
            Login.loginAttempt++;
            string loginUsernameInput = tbUsername.Text;
            string loginPassInput = tbPassword.Text;
            string roleValue;
            SqlCommand cmdLogin = new SqlCommand("SELECT Username, Password, AssignedRole FROM Credentials WHERE Username='" + loginUsernameInput + "' AND Password='" + loginPassInput + "'", SQLSELECT.conn);
            SqlDataReader readLogin = cmdLogin.ExecuteReader();
            //Checks the credentials in the database, and tries to get it's assigned role.
            try
            {
            readLogin.Read();    
            roleValue = readLogin.GetValue(2).ToString();     
            }catch (Exception)
            {                
                MessageBox.Show("Incorrect username and/or password.");
                if (Login.loginAttempt >= 3)
                {
                    MessageBox.Show("You've logged in 3 times unsuccessfully. Application will now close.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Login.loginAttempt = 0;

                    this.Close();
                }
                return;
            }
                do
                {
                
                if (loginUsernameInput == Convert.ToString(readLogin["Username"]) && loginPassInput == Convert.ToString(readLogin["Password"]))
                {
                    if (roleValue == "Inkoop")
                    {
                        MessageBox.Show("You do not have enough clearance to log in to this system.", "Not enough clearance.");
                        return;
                    }
                    if (roleValue == "Verkoop")
                    {
                        DashboardVerkoop dashboardverkoop = new DashboardVerkoop();
                        this.Hide();
                        dashboardverkoop.ShowDialog();
                        Login.loginAttempt = 0;
                        IN = true;
                        this.Show();
                    }
                    if (roleValue == "Admin")
                    {
                        DashboardManager dashboardAdmin = new DashboardManager();
                        this.Hide();
                        dashboardAdmin.ShowDialog();
                        Login.loginAttempt = 0;
                        IN = true;
                        this.Show();
                    }
                }
                else if (loginUsernameInput != Convert.ToString(readLogin["Username"]) && loginPassInput != Convert.ToString(readLogin["Password"]))
                {
                    MessageBox.Show("Incorrect username and/or password.");
                    return;
                }
            } while (!IN);                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btLogin.PerformClick();
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btLogin.PerformClick();
        }
    }
}
