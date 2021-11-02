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

            /*try
            {
                inputShoeNum = Convert.ToInt32(tbVerkoperShoeNum.Text);
                inputAantalChange = Convert.ToInt32(tbVerkoperAantalChange.Text);
                if (inputAantalChange <= 0)
                {
                    MessageBox.Show("You can't input a negative number.");
                    return;
                }
                if (inputShoeNum == 1)
                {
                    int oldStock = Convert.ToInt32(Voorraad.shoeList1[5]);
                    newStock = oldStock - inputAantalChange;
                    if (newStock <= 0)
                    {
                        MessageBox.Show("You can't sell more than you have.");
                        return;
                    }
                    Voorraad.shoeList1[5] = Convert.ToString(newStock);
                    MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
                }
                if (inputShoeNum == 2)
                {
                    int oldStock = Convert.ToInt32(Voorraad.shoeList2[5]);
                    newStock = oldStock - inputAantalChange;
                    if (newStock <= 0)
                    {
                        MessageBox.Show("You can't sell more than you have.");
                        return;
                    }
                    Voorraad.shoeList2[5] = Convert.ToString(newStock);
                    MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
                }
                if (inputShoeNum == 3)
                {
                    int oldStock = Convert.ToInt32(Voorraad.shoeList3[5]);
                    newStock = oldStock - inputAantalChange;
                    if (newStock <= 0)
                    {
                        MessageBox.Show("You can't sell more than you have.");
                        return;
                    }
                    Voorraad.shoeList3[5] = Convert.ToString(newStock);
                    MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
                }
                if (inputShoeNum == 4)
                {
                    int oldStock = Convert.ToInt32(Voorraad.shoeList4[5]);
                    newStock = oldStock - inputAantalChange;
                    if (newStock <= 0)
                    {
                        MessageBox.Show("You can't sell more than you have.");
                        return;
                    }
                    Voorraad.shoeList4[5] = Convert.ToString(newStock);
                    MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
                }
                if (inputShoeNum == 5)
                {
                    int oldStock = Convert.ToInt32(Voorraad.shoeList5[5]);
                    newStock = oldStock - inputAantalChange;
                    if (newStock <= 0)
                    {
                        MessageBox.Show("You can't sell more than you have.");
                        return;
                    }
                    Voorraad.shoeList5[5] = Convert.ToString(newStock);
                    MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
                }
            }catch(OverflowException)
            {
                MessageBox.Show("You can't input -2,147,483,648 to +2,147,483,647", "EASTER EGG");
            }*/
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
