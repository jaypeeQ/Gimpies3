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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }
        public void showVoorraad()
        {
            lvAdminScreen.Items.Clear();
            List<string> shoes = new(Voorraad.shoeList1);
            List<string> shoes2 = new(Voorraad.shoeList2);
            List<string> shoes3 = new(Voorraad.shoeList3);
            List<string> shoes4 = new(Voorraad.shoeList4);
            List<string> shoes5 = new(Voorraad.shoeList5);
            lvAdminScreen.View = View.Details;
            lvAdminScreen.Items.Add(new ListViewItem(Voorraad.shoeList1));
            lvAdminScreen.Items.Add(new ListViewItem(Voorraad.shoeList2));
            lvAdminScreen.Items.Add(new ListViewItem(Voorraad.shoeList3));
            lvAdminScreen.Items.Add(new ListViewItem(Voorraad.shoeList4));
            lvAdminScreen.Items.Add(new ListViewItem(Voorraad.shoeList5));
        }

        private void btSchoenenToevoegen_Click(object sender, EventArgs e)
        {
            DAToevoegen dAToevoegen = new DAToevoegen();
            this.Hide();
            dAToevoegen.ShowDialog();

            showVoorraad();
            this.Show();
        }

        private void btVoorraadBekijken_Click(object sender, EventArgs e)
        {
            showVoorraad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DAAanpassen Aanpassen = new DAAanpassen();
            this.Hide();
            Aanpassen.ShowDialog();
            showVoorraad();
            this.Show();
        }
    }
}
