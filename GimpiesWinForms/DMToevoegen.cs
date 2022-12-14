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
    public partial class DMToevoegen : Form
    {
        public DMToevoegen()
        {
            InitializeComponent();            
        }
        //Updates the Shoe Inventory data table.
        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                SqlCommand cmdCheck = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory", conn);
                SqlDataReader readCheck = cmdCheck.ExecuteReader();
                while (readCheck.Read())
                {
                    if (ShoeMerk == readCheck["ShoeMerk"].ToString() && ShoeType == readCheck["ShoeType"].ToString())
                    {
                        if (ShoeMerk == readCheck["ShoeMerk"].ToString() && ShoeType == readCheck["ShoeType"].ToString() && ShoeMaat == readCheck["ShoeMaat"].ToString())
                        {
                            if (ShoeMerk == readCheck["ShoeMerk"].ToString() && ShoeType == readCheck["ShoeType"].ToString() && ShoeKleur == readCheck["ShoeKleur"].ToString() && ShoeMaat == readCheck["ShoeMaat"].ToString())
                            {
                                if (ShoeMerk == readCheck["ShoeMerk"].ToString() && ShoeType == readCheck["ShoeType"].ToString() && ShoeKleur == readCheck["ShoeKleur"].ToString() && ShoeMaat == readCheck["ShoeMaat"].ToString() && ShoeAantal == readCheck["ShoeAantal"].ToString())
                                {
                                    if (ShoeMerk == readCheck["ShoeMerk"].ToString() && ShoeType == readCheck["ShoeType"].ToString() && ShoeKleur == readCheck["ShoeKleur"].ToString() && ShoeMaat == readCheck["ShoeMaat"].ToString() && ShoeAantal == readCheck["ShoeAantal"].ToString() && ShoePrijs == readCheck["ShoePrijs"].ToString())
                                    {
                                        MessageBox.Show("This stock already exists in the inventory.");
                                        return;
                                    }
                                    MessageBox.Show("Did you mean to stock up on/sell this shoe? If so, please inform >>Inkoop_Medewerker<</>>Verkoop_Medewerker<<.");
                                    return;
                                }
                                MessageBox.Show("This shoe brand, type, size and color already exists.");
                                return;
                            }
                            MessageBox.Show("This shoe brand, type, and size already exists.");
                            return;
                        }
                        MessageBox.Show("This shoe brand and type already exists.");
                        return;
                    }                   
                }
                conn.Close();
                conn.Open();
                SqlCommand cmdToevoegen = new SqlCommand("INSERT INTO ShoeInventory (ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs, ShoeSold, ShoeTurnover) " +
                                                         "VALUES ('" + ShoeMerk + "', '" + ShoeType + "', '" + ShoeMaat + "', '" + ShoeKleur + "', '" + ShoeAantal + "','" + ShoePrijs + "', 0, 0)", conn);
                SqlDataReader reader = cmdToevoegen.ExecuteReader();
                reader.Read();
                conn.Close();
                this.Close();
            }catch(SqlException)
            {
                MessageBox.Show("Input was not correct. Please enter the proper data." +
                    "\n In Maat, Aantal, and Prijs: Must be given a number.", "Wrong input given.");
                return;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
