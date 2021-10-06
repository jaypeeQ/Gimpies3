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
            List<string> shoes2 = new(Voorraad.shoeList2);
            List<string> shoes3 = new(Voorraad.shoeList3);
            List<string> shoes4 = new(Voorraad.shoeList4);
            List<string> shoes5 = new(Voorraad.shoeList5);
            lvVerkoperScreen.View = View.Details;
            lvVerkoperScreen.Items.Add(new ListViewItem(Voorraad.shoeList1));
            lvVerkoperScreen.Items.Add(new ListViewItem(Voorraad.shoeList2));
            lvVerkoperScreen.Items.Add(new ListViewItem(Voorraad.shoeList3));
            lvVerkoperScreen.Items.Add(new ListViewItem(Voorraad.shoeList4));
            lvVerkoperScreen.Items.Add(new ListViewItem(Voorraad.shoeList5));
        }

        private void btVoorraadBekijken_Click(object sender, EventArgs e)
        {
            showVoorraad();
        }
    }
}
