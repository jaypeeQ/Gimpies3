﻿using System;
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

            string ShoeMerk = tbMerk.Text;
            string ShoeType = tbType.Text;
            string ShoeMaat = tbMaat.Text;
            string ShoeKleur = tbKleur.Text;
            string ShoeAantal = tbAantal.Text;
            string ShoePrijs = tbPrijs.Text;

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdToevoegen = new SqlCommand("INSERT INTO ShoeInventory (ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs) " +
                                                     "VALUES ('" + ShoeMerk + "', '" + ShoeType + "', '" + ShoeMaat + "', '" + ShoeKleur + "', '" + ShoeAantal + "', '" + ShoePrijs + "')", conn);
            SqlDataReader reader = cmdToevoegen.ExecuteReader();
            reader.Read();
            conn.Close();
            this.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}