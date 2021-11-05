using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GimpiesWinForms
{
    public partial class DMSVerwijderen : Form
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DMSVerwijderen()
        {
            InitializeComponent();
        }

        private void btVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                string StaffID = tbVStaffID.Text;
                if (cbVerwijderen.Checked == false)
                {
                    MessageBox.Show("Please check the box for confirmation.");
                    return;
                }
                else if (cbVerwijderen.Checked == true)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    SqlCommand cmdStaff = new SqlCommand("DELETE FROM Credentials where Id= '" + StaffID + "'", conn);
                    SqlDataReader reader = cmdStaff.ExecuteReader();
                    reader.Read();
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the proper Staff Number.", "Error");
                return;
            }
            this.Close();
            
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
