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
    public partial class DAVerwijderen : Form
    {

        public DAVerwijderen()
        {
            InitializeComponent();
            FillDatagrid();
        }
        
        //Replaces the strings in its' respective List into a blank string. (from "string" -> "").
        private void button1_Click(object sender, EventArgs e)
        {
            string Shoenum = tbDAVShoeNumber.Text;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdShoes = new SqlCommand("DELETE FROM ShoeInventory WHERE ShoeId='" + Shoenum + "'", conn);
            SqlDataReader reader = cmdShoes.ExecuteReader();
            reader.Read();
            conn.Close();
            this.Close();
        }
        //Returns to it's respective dashboard.
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FillDatagrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdShoes = new SqlCommand("SELECT ShoeId, ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory", conn);
            SqlDataReader reader = cmdShoes.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Shoe Number");
            dt.Columns.Add("ShoeMerk");
            dt.Columns.Add("ShoeType");
            dt.Columns.Add("ShoeMaat");
            dt.Columns.Add("ShoeKleur");
            dt.Columns.Add("ShoeAantal");
            dt.Columns.Add("ShoePrijs");

            while (reader.Read())
            {
                dt.Rows.Add(reader["ShoeId"], reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
            }

            dgvPopup.DataSource = dt;
            reader.Close();
            conn.Close();
        }
    }
}
