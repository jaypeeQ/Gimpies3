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
        public VerkoopPopup()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int newStock;
            inputShoeNum = Convert.ToInt32(tbVerkoperShoeNum.Text);
            inputAantalChange = Convert.ToInt32(tbVerkoperAantalChange.Text);
            if (inputShoeNum == 1)
            {
                int oldStock = Convert.ToInt32(Voorraad.shoeList1[5]);
                newStock = oldStock - inputAantalChange;
                Voorraad.shoeList1[5] = Convert.ToString(newStock);
                MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
            }
            if (inputShoeNum == 2)
            {
                int oldStock = Convert.ToInt32(Voorraad.shoeList2[5]);
                newStock = oldStock - inputAantalChange;
                Voorraad.shoeList2[5] = Convert.ToString(newStock);
                MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
            }
            if (inputShoeNum == 3)
            {
                int oldStock = Convert.ToInt32(Voorraad.shoeList3[5]);
                newStock = oldStock - inputAantalChange;
                Voorraad.shoeList3[5] = Convert.ToString(newStock);
                MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
            }
            if (inputShoeNum == 4)
            {
                int oldStock = Convert.ToInt32(Voorraad.shoeList4[5]);
                newStock = oldStock - inputAantalChange;
                Voorraad.shoeList4[5] = Convert.ToString(newStock);
                MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
            }
            if (inputShoeNum == 5)
            {
                int oldStock = Convert.ToInt32(Voorraad.shoeList5[5]);
                newStock = oldStock - inputAantalChange;
                Voorraad.shoeList5[5] = Convert.ToString(newStock);
                MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
            }
            this.Close();

        }

    }
}
