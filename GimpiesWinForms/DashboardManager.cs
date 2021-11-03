using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GimpiesWinForms
{
    public partial class DashboardManager : Form
    {
        public DashboardManager()
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

            dgvAdmin.DataSource = dt;
            conn.Close();

        }

        private void btVoorraadBekijken_Click(object sender, EventArgs e)
        {
            FillDatagrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DMStaff staff = new DMStaff();
            this.Hide();
            staff.ShowDialog();

            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DMToevoegen dAToevoegen = new DMToevoegen();
            this.Hide();
            dAToevoegen.ShowDialog();
            FillDatagrid();
            this.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DMAanpassen Aanpassen = new DMAanpassen();
            this.Hide();
            Aanpassen.ShowDialog();
            FillDatagrid();
            this.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DMVerwijderen verwijderen = new DMVerwijderen();
            this.Hide();
            verwijderen.ShowDialog();
            FillDatagrid();
            this.Show();
        }
    }
}
