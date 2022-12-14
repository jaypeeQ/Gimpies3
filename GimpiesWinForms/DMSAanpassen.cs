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
    public partial class DMSAanpassen : Form
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DMSAanpassen()
        {
            InitializeComponent();
            comboBox1.Items.Add("Inkoop");
            comboBox1.Items.Add("Verkoop");
            comboBox1.Items.Add("Admin");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string StaffID = tbAStaffID.Text;
            string Username = tbAUsername.Text;
            string Password = tbAPassword.Text;
            string Role = Convert.ToString(comboBox1.Text);
            if (cbAanpassen.Checked == false)
            {
                MessageBox.Show("Please check the box for confirmation.");
                return;
            }
            else if (cbAanpassen.Checked == true)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmdStaff = new SqlCommand("UPDATE Credentials SET Username='" + Username + "', Password= '" + Password + "', AssignedRole= '" + Role + "' WHERE Id='" + StaffID + "'", conn);
                try
                {
                    SqlDataReader reader = cmdStaff.ExecuteReader();
                    reader.Read();
                    conn.Close();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid input. Please fill all required fields.");
                    return;
                }
                
                
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbAUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
        private void tbAPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void combobox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
        private void tbAStaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }

}
