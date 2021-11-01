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

namespace testwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillDatagrid();
        }
        public void FillDatagrid()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdLogin = new SqlCommand("SELECT Username, Password FROM Credentials", conn);
            SqlDataReader reader = cmdLogin.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");

            while (reader.Read())
            {
                dt.Rows.Add(reader["Username"], reader["Password"]);
            }

            dgvUsers.DataSource = dt;

        }
    }
}
