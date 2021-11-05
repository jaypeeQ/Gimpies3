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
            FillAvgPrijs();
            FillSumAantal();
            FillMaxPrijsShoeGrid();
            FillMaxAantalGrid();
            FillTotalTurnover();
            FillTotalSold();
            FillMaxSoldGrid();
            FillMinSoldGrid();
        }

        public void FillDatagrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdLogin = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory", conn);
            SqlDataReader reader = cmdLogin.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("Maat");
            dt.Columns.Add("Kleur");
            dt.Columns.Add("Aantal");
            dt.Columns.Add("Prijs");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
            }

            dgvAdmin.DataSource = dt;
            conn.Close();
        }

        public void FillMaxPrijsShoeGrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdLogin = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory WHERE ShoePrijs=(SELECT MAX(ShoePrijs) FROM ShoeInventory)", conn);
            SqlDataReader reader = cmdLogin.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("Maat");
            dt.Columns.Add("Kleur");
            dt.Columns.Add("Aantal");
            dt.Columns.Add("Prijs");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
            }

            dgMaxPrijs.DataSource = dt;
            conn.Close();
        }
        public void FillMaxAantalGrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdMaxAantal = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory WHERE ShoeAantal=(SELECT MAX(ShoeAantal) FROM ShoeInventory)", conn);
            SqlDataReader reader = cmdMaxAantal.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("Maat");
            dt.Columns.Add("Kleur");
            dt.Columns.Add("Aantal");
            dt.Columns.Add("Prijs");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
            }

            dgMaxAantal.DataSource = dt;
            conn.Close();
            conn.Close();

        }
        public void FillMaxSoldGrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdMaxAantal = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeAantal, ShoePrijs, ShoeSold, ShoeTurnover FROM ShoeInventory WHERE ShoeSold=(SELECT MAX(ShoeSold) FROM ShoeInventory)", conn);
            SqlDataReader reader = cmdMaxAantal.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("Aantal");
            dt.Columns.Add("Prijs");
            dt.Columns.Add("Sold");
            dt.Columns.Add("Turnover");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeMerk"], reader["ShoeType"], reader["ShoeAantal"], reader["ShoePrijs"], reader["ShoeSold"], reader["ShoeTurnover"]);
            }

            dgvAMostSold.DataSource = dt;
            conn.Close();
            conn.Close();

        }
        public void FillMinSoldGrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdMaxAantal = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeAantal, ShoePrijs, ShoeSold, ShoeTurnover FROM ShoeInventory WHERE ShoeSold=(SELECT MIN(ShoeSold) FROM ShoeInventory)", conn);
            SqlDataReader reader = cmdMaxAantal.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("Aantal");
            dt.Columns.Add("Prijs");
            dt.Columns.Add("Sold");
            dt.Columns.Add("Turnover");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeMerk"], reader["ShoeType"], reader["ShoeAantal"], reader["ShoePrijs"], reader["ShoeSold"], reader["ShoeTurnover"]);
            }

            dgvALeastSold.DataSource = dt;
            conn.Close();
            conn.Close();

        }
        public void FillSumAantal()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdSumPrijs = new SqlCommand("SELECT SUM(ShoeAantal) AS MaxCount FROM ShoeInventory", conn);
            SqlDataReader reader = cmdSumPrijs.ExecuteReader();


            reader.Read();
            tbDAWaarde.Text = Convert.ToString(reader["MaxCount"]);
            conn.Close();
        }

        

        public void FillAvgPrijs()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdAVGPrijs = new SqlCommand("SELECT AVG(ShoePrijs) AS Average FROM ShoeInventory", conn);
            SqlDataReader reader = cmdAVGPrijs.ExecuteReader();

            
            reader.Read();
            tbDAPrijs.Text = Convert.ToString(reader["Average"]);
            conn.Close();

        }

        public void FillTotalSold()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdSumSold = new SqlCommand("SELECT SUM(ShoeSold) AS SumSold FROM ShoeInventory", conn);
            SqlDataReader reader = cmdSumSold.ExecuteReader();


            reader.Read();
            tbTotalSold.Text = Convert.ToString(reader["SumSold"]);
            conn.Close();

        }
        public void FillTotalTurnover()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdSumTurnover = new SqlCommand("SELECT SUM(ShoeTurnover) AS TotalTurnover FROM ShoeInventory", conn);
            SqlDataReader reader = cmdSumTurnover.ExecuteReader();


            reader.Read();
            tbTotalTurnover.Text = Convert.ToString(reader["TotalTurnover"]);
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
            FillDatagrid();
            FillAvgPrijs();
            FillSumAantal();
            FillMaxPrijsShoeGrid();
            FillMaxAantalGrid();
            FillTotalTurnover();
            FillTotalSold();
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DMToevoegen dAToevoegen = new DMToevoegen();
            this.Hide();
            dAToevoegen.ShowDialog();
            FillDatagrid();
            FillAvgPrijs();
            FillSumAantal();
            FillMaxPrijsShoeGrid();
            FillMaxAantalGrid();
            FillTotalTurnover();
            FillTotalSold();
            this.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DMAanpassen Aanpassen = new DMAanpassen();
            this.Hide();
            Aanpassen.ShowDialog();
            FillDatagrid();
            FillAvgPrijs();
            FillSumAantal();
            FillMaxPrijsShoeGrid();
            FillMaxAantalGrid();
            FillTotalTurnover();
            FillTotalSold();
            this.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DMVerwijderen verwijderen = new DMVerwijderen();
            this.Hide();
            verwijderen.ShowDialog();
            FillDatagrid();
            FillAvgPrijs();
            FillSumAantal();
            FillMaxPrijsShoeGrid();
            FillMaxAantalGrid();
            FillTotalTurnover();
            FillTotalSold();
            this.Show();
        }

        private void DashboardManager_Load(object sender, EventArgs e)
        {

        }
    }
}
