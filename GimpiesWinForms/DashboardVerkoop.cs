using System;

using System.Collections.Generic;
using System.Collections;
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
    public partial class DashboardVerkoop : Form
    {
        
        public DashboardVerkoop()
        {
            InitializeComponent();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Close();
        }

        public void btSchoenenVerkopen_Click(object sender, EventArgs e)
        {
            VerkoopPopup verkoopPopup = new VerkoopPopup();
            this.Hide();
            verkoopPopup.ShowDialog();

            FillDatagrid();
            this.Show();
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
    }
}
