using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GimpiesWinForms
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            
        }

        public void FillDatagrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdLogin = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory", conn);
            SqlDataReader reader = cmdLogin.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("ShoeMerk");
            dt.Columns.Add("ShoeType");
            dt.Columns.Add("ShoeMaat");
            dt.Columns.Add("ShoeKleur");
            dt.Columns.Add("ShoeAantal");
            dt.Columns.Add("ShoePrijs");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
            }

            dgvUsers.DataSource = dt;
        }
        
        private void btSchoenenToevoegen_Click(object sender, EventArgs e)
        {
            DAToevoegen dAToevoegen = new DAToevoegen();
            this.Hide();
            dAToevoegen.ShowDialog();

            this.Show();
        }

        private void btVoorraadBekijken_Click(object sender, EventArgs e)
        {
            FillDatagrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DAAanpassen Aanpassen = new DAAanpassen();
            this.Hide();
            Aanpassen.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DAVerwijderen verwijderen = new DAVerwijderen();
            this.Hide();
            verwijderen.ShowDialog();
            
            this.Show();
        }
    }
}
