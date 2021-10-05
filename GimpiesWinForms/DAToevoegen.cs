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
    public partial class DAToevoegen : Form
    {
        public DAToevoegen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ShoeNummer = tbNummer.Text;
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
                    MessageBox.Show("You can't add shoes in an occupied inventory");
                    this.Close();
                    Voorraad.shoeList1[1] = ShoeMerk;
                    Voorraad.shoeList1[2] = ShoeType;
                    Voorraad.shoeList1[3] = ShoeMaat;
                    Voorraad.shoeList1[4] = ShoeKleur;
                    Voorraad.shoeList1[5] = ShoeAantal;
                    Voorraad.shoeList1[6] = ShoePrijs;
                    MessageBox.Show("Succesfully added new registry for shoes.");
                    this.Close();
                }
            }
            if (ShoeNummer == "2")
            {
                if (Voorraad.shoeList2[1] != "")
                {
                    MessageBox.Show("You can't add shoes in an occupied inventory");
                    this.Close();
                }
                Voorraad.shoeList2[0] = ShoeNummer;
                Voorraad.shoeList2[1] = ShoeMerk;
                Voorraad.shoeList2[2] = ShoeType;
                Voorraad.shoeList2[3] = ShoeMaat;
                Voorraad.shoeList2[4] = ShoeKleur;
                Voorraad.shoeList2[5] = ShoeAantal;
                Voorraad.shoeList2[6] = ShoePrijs;
                MessageBox.Show("Succesfully added new registry for shoes.");
                this.Close();
            }
            if (ShoeNummer == "3")
            {
                if (Voorraad.shoeList3[1] != "")
                {
                    MessageBox.Show("You can't add shoes in an occupied inventory");
                    this.Close();
                }
                Voorraad.shoeList3[0] = ShoeNummer;
                Voorraad.shoeList3[1] = ShoeMerk;
                Voorraad.shoeList3[2] = ShoeType;
                Voorraad.shoeList3[3] = ShoeMaat;
                Voorraad.shoeList3[4] = ShoeKleur;
                Voorraad.shoeList3[5] = ShoeAantal;
                Voorraad.shoeList3[6] = ShoePrijs;
                MessageBox.Show("Succesfully added new registry for shoes.");
                this.Close();
            }
            if (ShoeNummer == "4")
            {
                if (Voorraad.shoeList4[1] != "")
                {
                    MessageBox.Show("You can't add shoes in an occupied inventory");
                    this.Close();
                }
                Voorraad.shoeList4[0] = ShoeNummer;
                Voorraad.shoeList4[1] = ShoeMerk;
                Voorraad.shoeList4[2] = ShoeType;
                Voorraad.shoeList4[3] = ShoeMaat;
                Voorraad.shoeList4[4] = ShoeKleur;
                Voorraad.shoeList4[5] = ShoeAantal;
                Voorraad.shoeList4[6] = ShoePrijs;
                MessageBox.Show("Succesfully added new registry for shoes.");
                this.Close();
            }
            if (ShoeNummer == "5")
            {
                if (Voorraad.shoeList5[1] != "")
                {
                    MessageBox.Show("You can't add shoes in an occupied inventory");
                    this.Close();
                }
                Voorraad.shoeList5[0] = ShoeNummer;
                Voorraad.shoeList5[1] = ShoeMerk;
                Voorraad.shoeList5[2] = ShoeType;
                Voorraad.shoeList5[3] = ShoeMaat;
                Voorraad.shoeList5[4] = ShoeKleur;
                Voorraad.shoeList5[5] = ShoeAantal;
                Voorraad.shoeList5[6] = ShoePrijs;
                MessageBox.Show("Succesfully added new registry for shoes.");
                this.Close();
            }
           
        }
        
    }
}
