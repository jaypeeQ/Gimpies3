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
    public partial class DAAanpassen : Form
    {
        static string ShoeNummer;
        public DAAanpassen()
        {
            InitializeComponent();
            TextReadOnlyON();
        }
        //Checks to see if data is already present relating to a registry's shoenumber.
        //Allows the Admin to add another registry for shoes in the system. (MAX 5)
        private void button1_Click(object sender, EventArgs e)
        {            
            string ShoeMerk = tbMerk.Text;
            string ShoeType = tbType.Text;
            string ShoeMaat = tbMaat.Text;
            string ShoeKleur = tbKleur.Text;
            string ShoeAantal = tbAantal.Text;
            string ShoePrijs = tbPrijs.Text;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdSell = new SqlCommand("UPDATE ShoeInventory SET ShoeMerk= '" + ShoeMerk + "', SET ShoeType= '" + ShoeType + "',SET ShoeMaat='" + ShoeMaat + "', SET ShoeKleur= '" + ShoeKleur + "', SET ShoeAantal= '" + ShoeAantal + "', SET ShoePrijs='" + ShoePrijs + "' WHERE ShoeID = '" + tbNummer.Text + "'", conn);
            SqlDataReader readSell = cmdSell.ExecuteReader();
            readSell.Read();
            conn.Close();

        }
        //Generates a shoe number's respective data inside text fields, for easier editing. After a registry has been found, textboxes become free to edit.
        private void btDAAGenerate_Click(object sender, EventArgs e)
        {
            FillDatagrid();
            TextReadOnlyOFF();
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdShoes = new SqlCommand("SELECT ShoeAantal FROM ShoeInventory WHERE ShoeId='" + tbNummer.Text + "'", conn);
            SqlDataReader reader = cmdShoes.ExecuteReader();
            reader.Read();


            ShoeNummer = tbNummer.Text;
            tbNummer.ReadOnly = true;
            conn.Close();
            
        }
        //Exits the form back to it's respective dashboard.
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Resets the fields back into its original state.
        private void button2_Click(object sender, EventArgs e)
        {
            tbNummer.Text = "";
            tbNummer.ReadOnly = false;
            dgvPopup.Rows.Clear();
            TextReadOnlyON();
        }
        //Makes the readonly value of the form's textboxes on or off.
        public void TextReadOnlyON()
        {
            tbMerk.ReadOnly = true;
            tbType.ReadOnly = true;
            tbMaat.ReadOnly = true;
            tbKleur.ReadOnly = true;
            tbAantal.ReadOnly = true;
            tbPrijs.ReadOnly = true;
        }
        public void TextReadOnlyOFF()
        {
            tbMerk.ReadOnly = false;
            tbType.ReadOnly = false;
            tbMaat.ReadOnly = false;
            tbKleur.ReadOnly = false;
            tbAantal.ReadOnly = false;
            tbPrijs.ReadOnly = false;
        }
        public void FillDatagrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdShoes = new SqlCommand("SELECT ShoeId, ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory WHERE ShoeId='" + tbNummer.Text + "'", conn);
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
