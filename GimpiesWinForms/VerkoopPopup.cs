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
    public partial class VerkoopPopup : Form
    {
        int inputShoeNum;
        int inputAantalChange;
        int newStock;
        int oldStock;
        public VerkoopPopup()
        {
            InitializeComponent();
            FillDatagrid();
        }
        //Allows the verkoper to be able to specify a shoe number to it's stock, and in turn substracts the value given to original stock.
        public void button1_Click(object sender, EventArgs e)
        {
            inputShoeNum = Convert.ToInt32(tbVerkoperShoeNum.Text);
            inputAantalChange = Convert.ToInt32(tbVerkoperAantalChange.Text);
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdShoes = new SqlCommand("SELECT ShoeAantal FROM ShoeInventory WHERE ShoeId='" + inputShoeNum + "'", conn);
            SqlDataReader reader = cmdShoes.ExecuteReader();
            reader.Read();
            
            oldStock = Convert.ToInt32(reader["ShoeAantal"]);
            newStock = oldStock - inputAantalChange;
            conn.Close();
            conn.Open();
            SqlCommand cmdSell = new SqlCommand("UPDATE ShoeInventory SET ShoeAantal = '" + newStock + "' WHERE ShoeID = '" + inputShoeNum + "'", conn);
            SqlDataReader readSell = cmdSell.ExecuteReader();
            readSell.Read();
            conn.Close();
            conn.Open();
            SqlCommand cmdSold = new SqlCommand("UPDATE ShoeInventory SET ShoeSold = " + oldStock + ", ShoeTurnover = ShoePrijs*"+ oldStock + " WHERE ShoeID = '" + inputShoeNum + "'", conn);
            SqlDataReader readSold = cmdSold.ExecuteReader();
            readSold.Read();
            conn.Close();

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
