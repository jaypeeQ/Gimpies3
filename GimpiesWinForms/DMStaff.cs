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
    public partial class DMStaff : Form
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DMStaff()
        {
            InitializeComponent();
            FillDatagridStaff();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillDatagridStaff()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdStaff = new SqlCommand("SELECT Id, Username, Password, AssignedRole FROM Credentials", conn);
            SqlDataReader reader = cmdStaff.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Staff ID");
            dt.Columns.Add("Medewerker");
            dt.Columns.Add("Wachtwoord");
            dt.Columns.Add("Rol");


            while (reader.Read())
            {
                dt.Rows.Add(reader["Id"], reader["Username"], reader["Password"], reader["AssignedRole"]);
            }

            dgvMedewerker.DataSource = dt;
            conn.Close();

        }

        private void btUpdateGrid_Click(object sender, EventArgs e)
        {
            FillDatagridStaff();
        }

        private void btToevoegen_Click(object sender, EventArgs e)
        {
            string StaffID = tbAStaffID.Text;
            string Username = tbTUsername.Text;
            string Password = tbTPassword.Text;
            string Role = tbTAssignedRole.Text;
            if (cbToevoegen.Checked == false)
            {
                MessageBox.Show("Please check the box for confirmation.");
                return;
            }
            else if (cbToevoegen.Checked == true)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmdStaff = new SqlCommand("INSERT INTO Credentials (Username, Password, AssignedRole) " +
                                                      "VALUES ('" + Username + "', '" + Password + "', '" + Role + "')", conn);
                SqlDataReader reader = cmdStaff.ExecuteReader();
                reader.Read();
                conn.Close();
                FillDatagridStaff();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StaffID = tbAStaffID.Text;
            string Username = tbAStaffID.Text;
            string Password = tbAPassword.Text;
            string Role = tbAAssignedRole.Text;
            if (cbAanpassen.Checked == false)
            {
                MessageBox.Show("Please check the box for confirmation.");
                return;
            }
            else if (cbAanpassen.Checked == true)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmdStaff = new SqlCommand("UPDATE Credentials SET Username='" + Username + "', Password= '" + Password + "', AssignedRole= '" + Role + "' WHERE Id='" + StaffID + "'" , conn);
                SqlDataReader reader = cmdStaff.ExecuteReader();
                reader.Read();
                conn.Close();
                FillDatagridStaff();
            }
        }

        private void btVerwijderen_Click(object sender, EventArgs e)
        {
            string StaffID = tbVStaffID.Text;
            if (cbVerwijderen.Checked == false)
            {
                MessageBox.Show("Please check the box for confirmation.");
                return;
            }
            else if (cbVerwijderen.Checked == true)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmdStaff = new SqlCommand("DELETE FROM Credentials where Id= '" + StaffID + "'", conn);
                SqlDataReader reader = cmdStaff.ExecuteReader();
                reader.Read();
                conn.Close();
                FillDatagridStaff();
            }
        }
    }
}
