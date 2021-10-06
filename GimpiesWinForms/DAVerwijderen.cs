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
    public partial class DAVerwijderen : Form
    {

        public DAVerwijderen()
        {
            InitializeComponent();
        }
        //Generates the list's strings in Voorraad Class.
        private void DAVGenerate_Click(object sender, EventArgs e)
        {

            string ShoeNumber = tbDAVShoeNumber.Text;
            if (ShoeNumber == "1")
            {
                tbDAVShoeCheck.Text = 
                    Voorraad.shoeList1[1] + "\t\t" + 
                    Voorraad.shoeList1[2] + "\t\t" + 
                    Voorraad.shoeList1[3] + "\t\t" + 
                    Voorraad.shoeList1[4] + "\t\t" + 
                    Voorraad.shoeList1[5] + "\t\t" + 
                    Voorraad.shoeList1[6];
            }
            if (ShoeNumber == "2")
            {
                tbDAVShoeCheck.Text =
                    Voorraad.shoeList2[1] + "\t\t" +
                    Voorraad.shoeList2[2] + "\t\t" +
                    Voorraad.shoeList2[3] + "\t\t" +
                    Voorraad.shoeList2[4] + "\t\t" +
                    Voorraad.shoeList2[5] + "\t\t" +
                    Voorraad.shoeList2[6];
            }
            if (ShoeNumber == "3")
            {
                tbDAVShoeCheck.Text =
                    Voorraad.shoeList3[1] + "\t\t" +
                    Voorraad.shoeList3[2] + "\t\t" +
                    Voorraad.shoeList3[3] + "\t\t" +
                    Voorraad.shoeList3[4] + "\t\t" +
                    Voorraad.shoeList3[5] + "\t\t" +
                    Voorraad.shoeList3[6];
            }
            if (ShoeNumber == "4")
            {
                tbDAVShoeCheck.Text =
                    Voorraad.shoeList4[1] + "\t\t" +
                    Voorraad.shoeList4[2] + "\t\t" +
                    Voorraad.shoeList4[3] + "\t\t" +
                    Voorraad.shoeList4[4] + "\t\t" +
                    Voorraad.shoeList4[5] + "\t\t" +
                    Voorraad.shoeList4[6];
                if (ShoeNumber == "5")
                {
                    tbDAVShoeCheck.Text =
                    Voorraad.shoeList5[1] + "\t\t" +
                    Voorraad.shoeList5[2] + "\t\t" +
                    Voorraad.shoeList5[3] + "\t\t" +
                    Voorraad.shoeList5[4] + "\t\t" +
                    Voorraad.shoeList5[5] + "\t\t" +
                    Voorraad.shoeList5[6];
                }
            }
        }
        //Replaces the strings in its' respective List into a blank string. (from "string" -> "").
        private void button1_Click(object sender, EventArgs e)
        {
            string ShoeNumber = tbDAVShoeNumber.Text;
            string[] empty = { "", "", "", "", "", "", "" };
            if (ShoeNumber == "1")
            {
                Voorraad.shoeList1 = empty;
            }
            if (ShoeNumber == "2")
            {
                Voorraad.shoeList2 = empty;
            }
            if (ShoeNumber == "3")
            {
                Voorraad.shoeList3 = empty;
            }
            if (ShoeNumber == "4")
            {
                Voorraad.shoeList4 = empty;
            }
            if (ShoeNumber == "5")
            {
                Voorraad.shoeList5 = empty;
            }
            MessageBox.Show("You have removed #: " + ShoeNumber + "from the inventory.");
            this.Close();
        }
        //Returns to it's respective dashboard.
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
