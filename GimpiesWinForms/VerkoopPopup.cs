using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimpiesWinForms
{
    public partial class VerkoopPopup : Form
    {
        int inputShoeNum;
        int inputAantalChange;
        int newStock;
        public VerkoopPopup()
        {
            InitializeComponent();
        }
        //Allows the verkoper to be able to specify a shoe number to it's stock, and in turn substracts the value given to original stock.
        public void button1_Click(object sender, EventArgs e)
        {
            try
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
            }
            this.Close();

        }

        private void btVerkoopGenerate_Click(object sender, EventArgs e)
        {
            string ShoeNumber = tbVerkoperShoeNum.Text;
            if (ShoeNumber == "1")
            {
                tbVerkoopDisplay.Text =
                    Voorraad.shoeList1[1] + "\t\t" +
                    Voorraad.shoeList1[2] + "\t\t" +
                    Voorraad.shoeList1[3] + "\t\t" +
                    Voorraad.shoeList1[4] + "\t\t" +
                    Voorraad.shoeList1[5] + "\t\t" +
                    Voorraad.shoeList1[6];
            }
            if (ShoeNumber == "2")
            {
                tbVerkoopDisplay.Text =
                    Voorraad.shoeList2[1] + "\t\t" +
                    Voorraad.shoeList2[2] + "\t\t" +
                    Voorraad.shoeList2[3] + "\t\t" +
                    Voorraad.shoeList2[4] + "\t\t" +
                    Voorraad.shoeList2[5] + "\t\t" +
                    Voorraad.shoeList2[6];
            }
            if (ShoeNumber == "3")
            {
                tbVerkoopDisplay.Text =
                    Voorraad.shoeList3[1] + "\t\t" +
                    Voorraad.shoeList3[2] + "\t\t" +
                    Voorraad.shoeList3[3] + "\t\t" +
                    Voorraad.shoeList3[4] + "\t\t" +
                    Voorraad.shoeList3[5] + "\t\t" +
                    Voorraad.shoeList3[6];
            }
            if (ShoeNumber == "4")
            {
                tbVerkoopDisplay.Text =
                    Voorraad.shoeList4[1] + "\t\t" +
                    Voorraad.shoeList4[2] + "\t\t" +
                    Voorraad.shoeList4[3] + "\t\t" +
                    Voorraad.shoeList4[4] + "\t\t" +
                    Voorraad.shoeList4[5] + "\t\t" +
                    Voorraad.shoeList4[6];
            }
            if (ShoeNumber == "5")
            {
                tbVerkoopDisplay.Text =
                Voorraad.shoeList5[1] + "\t\t" +
                Voorraad.shoeList5[2] + "\t\t" +
                Voorraad.shoeList5[3] + "\t\t" +
                Voorraad.shoeList5[4] + "\t\t" +
                Voorraad.shoeList5[5] + "\t\t" +
                Voorraad.shoeList5[6];
            }

        }
       

    }
    

}
