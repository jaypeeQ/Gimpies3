using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdLogin = new SqlCommand("SELECT Username, Password FROM Credentials", conn);

            //Console.Write("username: ");
            //string username = Console.ReadLine();

            //Console.Write("Password: ");
            //string password = Console.ReadLine();

            SqlDataReader readLogin = cmdLogin.ExecuteReader();
            while (readLogin.Read())
            {
                Console.WriteLine("username = " + readLogin["Username" ] + " and password = " + readLogin["Password"]);
            }

            Console.ReadLine();
          

        }
    }
}
