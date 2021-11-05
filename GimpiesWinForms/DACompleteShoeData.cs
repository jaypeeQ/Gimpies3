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
    public partial class DACompleteShoeData : Form
    {
        public DACompleteShoeData()
        {
            InitializeComponent();
            FillDatagrid();
        }

        public void FillDatagrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdLogin = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs, ShoeSold, ShoeTurnover FROM ShoeInventory", conn);
            SqlDataReader reader = cmdLogin.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("Maat");
            dt.Columns.Add("Kleur");
            dt.Columns.Add("Aantal");
            dt.Columns.Add("Prijs");
            dt.Columns.Add("Sold");
            dt.Columns.Add("Turnover");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"], reader["ShoeSold"], reader["ShoeTurnover"]);
            }

            dgvShoeData.DataSource = dt;
            conn.Close();
        }
    }
}
