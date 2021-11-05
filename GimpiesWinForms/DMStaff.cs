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


        private void btToevoegen_Click(object sender, EventArgs e)
        {
            DMSToevoegen toevoegen = new DMSToevoegen();
            toevoegen.ShowDialog();
            FillDatagridStaff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DMSAanpassen aanpassen = new DMSAanpassen();
            aanpassen.ShowDialog();
            FillDatagridStaff();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DMSVerwijderen verwijderen = new DMSVerwijderen();
            verwijderen.ShowDialog();
            FillDatagridStaff();
        }
    }
}

