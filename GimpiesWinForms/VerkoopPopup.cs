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
            inputShoeNum = Convert.ToInt32(tbVerkoperShoeNum.Text);
            inputAantalChange = Convert.ToInt32(tbVerkoperAantalChange.Text);

            int oldStock = Convert.ToInt32(Voorraad.shoeList1[5]);
            int newStock = oldStock - inputAantalChange;
            Voorraad.shoeList1[5] = Convert.ToString(newStock);

            MessageBox.Show("You have sold " + inputAantalChange + " shoes. You have " + newStock + " left.");
            this.Close();
            
            
            
        }

    }
}
