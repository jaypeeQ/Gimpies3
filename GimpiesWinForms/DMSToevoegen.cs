using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GimpiesWinForms
{
    public partial class DMSToevoegen : Form
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



        public DMSToevoegen()
        {
            InitializeComponent();
            comboBox1.Items.Add("Inkoop");
            comboBox1.Items.Add("Verkoop");
            comboBox1.Items.Add("Admin");
        }

        private void btToevoegen_Click(object sender, EventArgs e)
        {
            string Username = tbTUsername.Text;
            

            SqlConnection conn = new SqlConnection(connectionString);

            if (cbToevoegen.Checked == false)
            {
                MessageBox.Show("Please check the box for confirmation.");
                return;
            }
            else if (cbToevoegen.Checked == true)
            {
                conn.Open();
                SqlCommand cmdCheck = new SqlCommand("SELECT Username FROM Credentials", conn);
                SqlDataReader reader = cmdCheck.ExecuteReader();
                while (reader.Read())
                {
                    if (Username == reader["Username"].ToString())
                    {
                        MessageBox.Show("Account already exists.");
                        return;
                    }
                }
                insertAccount();

                conn.Close();
                this.Close();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertAccount()
        {

            string Username = tbTUsername.Text;
            string Password = tbTPassword.Text;
            string Role = Convert.ToString(comboBox1.Text);

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdStaff = new SqlCommand("INSERT INTO Credentials (Username, Password, AssignedRole) " +
                                                              "VALUES ('" + Username + "', '" + Password + "', '" + Role + "')", conn);
            SqlDataReader reader2 = cmdStaff.ExecuteReader();
            reader2.Read();

        }
        private void tbtTUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btToevoegen.PerformClick();
        }
        private void tbVPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btToevoegen.PerformClick();
        }

        private void combobox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btToevoegen.PerformClick();
        }
    }
}
