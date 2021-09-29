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
    public partial class DashboardVerkoop : Form
    {
        public DashboardVerkoop()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        //Make a better table for data manipulation for other events.

        public void btVoorraadBekijken_Click(object sender, EventArgs e)
        {
            string[] shoeList1 = { "1", "Nike", "Air Max", "42", "Rood", "12", "49,99" };

            List<string> shoes = new List<string>(shoeList1);
            lvVerkoperScreen.View = View.Details;
            lvVerkoperScreen.Items.Add(new ListViewItem(shoeList1));
            lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "1", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));
            lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "2", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));
            lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "3", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));
            lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "4", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));
        }


    }
}
