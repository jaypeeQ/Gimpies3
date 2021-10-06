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
            
            if (ShoeNummer == "1")
            {
                if (Voorraad.shoeList1[1] != "")
                {                    
                    Voorraad.shoeList1[1] = ShoeMerk;
                    Voorraad.shoeList1[2] = ShoeType;
                    Voorraad.shoeList1[3] = ShoeMaat;
                    Voorraad.shoeList1[4] = ShoeKleur;
                    Voorraad.shoeList1[5] = ShoeAantal;
                    Voorraad.shoeList1[6] = ShoePrijs;
                    MessageBox.Show("Succesfully added new registry for shoes.");
                    this.Close();
                }
                if (Voorraad.shoeList1[1] == "")
                {
                    MessageBox.Show("You can't configure non-existent shoes.");
                    this.Close();
                }
            }
            if (ShoeNummer == "2")
            {
                if (Voorraad.shoeList2[1] != "")
                {
                    Voorraad.shoeList2[1] = ShoeMerk;
                    Voorraad.shoeList2[2] = ShoeType;
                    Voorraad.shoeList2[3] = ShoeMaat;
                    Voorraad.shoeList2[4] = ShoeKleur;
                    Voorraad.shoeList2[5] = ShoeAantal;
                    Voorraad.shoeList2[6] = ShoePrijs;
                    MessageBox.Show("Succesfully added new registry for shoes.");
                    this.Close();
                }
                if (Voorraad.shoeList2[1] == "")
                {
                    MessageBox.Show("You can't configure non-existent shoes.");
                    this.Close();
                }
            }
            if (ShoeNummer == "3")
            {
                if (Voorraad.shoeList3[1] != "")
                {
                    Voorraad.shoeList3[1] = ShoeMerk;
                    Voorraad.shoeList3[2] = ShoeType;
                    Voorraad.shoeList3[3] = ShoeMaat;
                    Voorraad.shoeList3[4] = ShoeKleur;
                    Voorraad.shoeList3[5] = ShoeAantal;
                    Voorraad.shoeList3[6] = ShoePrijs;
                    MessageBox.Show("Succesfully added new registry for shoes.");
                    this.Close();
                }
                if (Voorraad.shoeList3[1] == "")
                {
                    MessageBox.Show("You can't configure non-existent shoes.");
                    this.Close();
                }
            }
            if (ShoeNummer == "4")
            {
                if (Voorraad.shoeList4[1] != "")
                {
                    Voorraad.shoeList4[1] = ShoeMerk;
                    Voorraad.shoeList4[2] = ShoeType;
                    Voorraad.shoeList4[3] = ShoeMaat;
                    Voorraad.shoeList4[4] = ShoeKleur;
                    Voorraad.shoeList4[5] = ShoeAantal;
                    Voorraad.shoeList4[6] = ShoePrijs;
                    MessageBox.Show("Succesfully added new registry for shoes.");
                    this.Close();
                }
                if (Voorraad.shoeList4[1] == "")
                {
                    MessageBox.Show("You can't configure non-existent shoes.");
                    this.Close();
                }
            }
            if (ShoeNummer == "5")
            {
                if (Voorraad.shoeList5[1] != "")
                {

                    Voorraad.shoeList5[1] = ShoeMerk;
                    Voorraad.shoeList5[2] = ShoeType;
                    Voorraad.shoeList5[3] = ShoeMaat;
                    Voorraad.shoeList5[4] = ShoeKleur;
                    Voorraad.shoeList5[5] = ShoeAantal;
                    Voorraad.shoeList5[6] = ShoePrijs;
                    MessageBox.Show("Succesfully added new registry for shoes.");
                    this.Close();
                }
                if (Voorraad.shoeList5[1] == "")
                {
                    MessageBox.Show("You can't configure non-existent shoes.");
                    this.Close();
                }
            }
        }
        //Generates a shoe number's respective data inside text fields, for easier editing. After a registry has been found, textboxes become free to edit.
        private void btDAAGenerate_Click(object sender, EventArgs e)
        {
            TextReadOnlyOFF();

            ShoeNummer = tbNummer.Text;
            tbNummer.ReadOnly = true;
            if (DAAanpassen.ShoeNummer == "1")
            {
                tbMerk.Text = Voorraad.shoeList1[1];
                tbType.Text = Voorraad.shoeList1[2];
                tbMaat.Text = Voorraad.shoeList1[3];
                tbKleur.Text = Voorraad.shoeList1[4];
                tbAantal.Text = Voorraad.shoeList1[5];
                tbPrijs.Text = Voorraad.shoeList1[6];
            }
            if (DAAanpassen.ShoeNummer == "2")
            {
                tbMerk.Text = Voorraad.shoeList2[1];
                tbType.Text = Voorraad.shoeList2[2];
                tbMaat.Text = Voorraad.shoeList2[3];
                tbKleur.Text = Voorraad.shoeList2[4];
                tbAantal.Text = Voorraad.shoeList2[5];
                tbPrijs.Text = Voorraad.shoeList2[6];
            }
            if (DAAanpassen.ShoeNummer == "3")
            {
                tbMerk.Text = Voorraad.shoeList3[1];
                tbType.Text = Voorraad.shoeList3[2];
                tbMaat.Text = Voorraad.shoeList3[3];
                tbKleur.Text = Voorraad.shoeList3[4];
                tbAantal.Text = Voorraad.shoeList3[5];
                tbPrijs.Text = Voorraad.shoeList3[6];
            }
            if (DAAanpassen.ShoeNummer == "4")
            {
                tbMerk.Text = Voorraad.shoeList4[1];
                tbType.Text = Voorraad.shoeList4[2];
                tbMaat.Text = Voorraad.shoeList4[3];
                tbKleur.Text = Voorraad.shoeList4[4];
                tbAantal.Text = Voorraad.shoeList4[5];
                tbPrijs.Text = Voorraad.shoeList4[6];
            }
            if (DAAanpassen.ShoeNummer == "5")
            {
                tbMerk.Text = Voorraad.shoeList5[1];
                tbType.Text = Voorraad.shoeList5[2];
                tbMaat.Text = Voorraad.shoeList5[3];
                tbKleur.Text = Voorraad.shoeList5[4];
                tbAantal.Text = Voorraad.shoeList5[5];
                tbPrijs.Text = Voorraad.shoeList5[6];
            }
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
    }
}
