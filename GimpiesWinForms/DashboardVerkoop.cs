using System;

using System.Collections.Generic;
using System.Collections;
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
            Login form1 = new Login();
            form1.Show();
            this.Close();
        }

        public void btSchoenenVerkopen_Click(object sender, EventArgs e)
        {
            VerkoopPopup verkoopPopup = new VerkoopPopup();
            this.Hide();
            verkoopPopup.ShowDialog();
            
            showVoorraad();
            this.Show();
        }

        public void showVoorraad()
        {
            lvVerkoperScreen.Items.Clear();
            List<string> shoes = new(Voorraad.shoeList1);
            lvVerkoperScreen.View = View.Details;
            lvVerkoperScreen.Items.Add(new ListViewItem(Voorraad.shoeList1));
        }

        private void btVoorraadBekijken_Click(object sender, EventArgs e)
        {
            showVoorraad();
        }
    }
}
