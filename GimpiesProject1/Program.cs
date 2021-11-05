using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GimpiesProject1
{
    class Program
    {
        public static SqlConnection conn;
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GimpiesDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static string passwordValue;
        public static string roleValue;
        public static int loginAttempts;
        public static int aantal;
        static void MainMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Voorraad Schoenen bejiken");
                Console.WriteLine("2. Schoenen Inkopen");
                Console.WriteLine("3. Uitloggen.");
                int MenuOptions = Convert.ToInt32(Console.ReadLine());

                switch (MenuOptions)
                {
                    case 1:
                        {
                            MenuVoorraad();
                            break;
                        }
                    case 2:
                        {
                            MenuInkopen();
                            break;
                        }
                    case 3:
                        {
                            MenuUitloggen();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("That's not an option. ");
                            Console.Read();
                            MainMenu();
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                MainMenu();
            }
        }

        static void MenuVoorraad()
        {
            Console.Clear();
            int i, j;
            
            conn.Open();
            SqlCommand cmdShoes = new SqlCommand("SELECT ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory", conn);
            SqlDataReader reader = cmdShoes.ExecuteReader();
            
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}", "Merk", "Type", "Maat", "Kleur", "Aantal", "Prijs");
            Console.WriteLine();
            while (reader.Read())
            {
                aantal = Convert.ToInt32(Convert.ToString(reader["ShoeAantal"]));
                if (aantal >= 5)
                {
                    
                    Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}", reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
                }
                if (aantal <= 5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}", reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
                    Console.ResetColor();
                }
            }
            conn.Close();
            Console.ReadKey();
            MainMenu();
        }
        
        //Shoe Inventory, 2-dimensional string array, into console inputting (str to int, calculate, back to string, declare with coords).
        static void MenuInkopen()
        {
            conn.Close();
            int i, j;
            string shoeNum;
            int InkoopNum;
            string shoeAantal;
            conn.Open();
            SqlCommand cmdShoes = new SqlCommand("SELECT ShoeId, ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory" , conn);
            SqlDataReader reader = cmdShoes.ExecuteReader();

            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}", "Shoe Number", "Merk", "Type", "Maat", "Kleur", "Aantal", "Prijs");

            while (reader.Read())
            {
                aantal = Convert.ToInt32(Convert.ToString(reader["ShoeAantal"]));
                if (aantal >= 5)
                {

                    Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}", reader["ShoeId"], reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
                }
                if (aantal <= 5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}", reader["ShoeId"], reader["ShoeMerk"], reader["ShoeType"], reader["ShoeMaat"], reader["ShoeKleur"], reader["ShoeAantal"], reader["ShoePrijs"]);
                    Console.ResetColor();
                }
            }
            conn.Close();
            
            
            Console.WriteLine();
            Console.Write("Enter Shoe Number: ");
            shoeNum = Console.ReadLine();
            Console.Clear();
            conn.Open();
            SqlCommand cmdShoes2 = new SqlCommand("SELECT ShoeId, ShoeMerk, ShoeType, ShoeMaat, ShoeKleur, ShoeAantal, ShoePrijs FROM ShoeInventory WHERE ShoeId='" + shoeNum + "'", conn);
            SqlDataReader reader2 = cmdShoes2.ExecuteReader();
            Console.Clear();
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}", "Shoe Number", "Merk", "Type", "Maat", "Kleur", "Aantal", "Prijs");

            reader2.Read();
            try
            {
                Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}", reader2["ShoeId"], reader2["ShoeMerk"], reader2["ShoeType"], reader2["ShoeMaat"], reader2["ShoeKleur"], reader2["ShoeAantal"], reader2["ShoePrijs"]);
            
                if (shoeNum == Convert.ToString(reader2["ShoeId"]))
                {
                    Console.Write("Enter amount to add: ");
                    InkoopNum = Convert.ToInt32(Console.ReadLine());
                    shoeAantal = Convert.ToString(reader2["ShoeAantal"]);
                    int shoeAantal2 = Convert.ToInt32(shoeAantal) + InkoopNum;
                    Console.WriteLine("You have added " + InkoopNum + " Shoes to " + Convert.ToString(reader2["ShoeMerk"]) + " " + Convert.ToString(reader2["ShoeType"]) + ".");
                    if (InkoopNum <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You can't input a negative number!. Try again.");
                        Console.ReadLine();

                        MenuInkopen();
                    }
                    reader2.Close();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmdShoesInkoop = new SqlCommand("UPDATE ShoeInventory SET ShoeAantal='" + shoeAantal2 + "' WHERE ShoeID='" + shoeNum + "'", conn);
                    SqlDataReader ShoeInkoop = cmdShoesInkoop.ExecuteReader();
                    ShoeInkoop.Read();
                }
                conn.Close();
            }catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please choose the right number.");
                Console.ReadLine();
                MenuInkopen();
            }
            Console.ReadLine();
            MainMenu();
        }
        static void MenuUitloggen()
        {
            Console.Clear();
            Login();
        }
        //Login Screen.
        static void Login()
        {            
            Console.Clear();            
                loginAttempts = 0;
                bool succesfull = false;

                while (!succesfull)
                {
                conn.Open();
                if (loginAttempts == 3)
                    {
                        Console.Clear();
                        Console.Write("You've attempted to log in too many times, This application will now close.");
                        Console.ReadLine();
                        EXIT();
                    }
                Console.WriteLine("Login Screen");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = ReadPassword();
                Console.WriteLine();

                SqlCommand cmdLogin = new SqlCommand("SELECT Username, Password, AssignedRole FROM Credentials WHERE Username='" + username + "' AND Password='" + password + "'", conn);
                SqlDataReader readLogin = cmdLogin.ExecuteReader();
                if (readLogin.Read()) 
                {    
                    roleValue = readLogin.GetValue(2).ToString();
                };

                try
                {
                    if (username == Convert.ToString(readLogin["Username"]) && password == Convert.ToString(readLogin["Password"]))
                    {
                        if (roleValue == "Inkoop")
                        {
                            Console.WriteLine("You logged in succesfully");
                            Console.ReadLine();
                            succesfull = true;
                            conn.Close();
                            break;
                        }
                        else if (roleValue == "Admin" || roleValue == "Verkoop")
                        {
                            loginAttempts++;
                            Console.WriteLine("You are not allowed to log in to this system with your clearance level.");
                            Console.WriteLine("login attempts: " + loginAttempts + " of 3");
                            Console.ReadLine();
                            Console.Clear();
                        }                        
                        else
                        {
                            loginAttempts++;                           
                            Console.WriteLine("login attempts: " + loginAttempts + " of 3");
                            Console.ReadLine();
                            Console.Clear();                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                        loginAttempts++;
                        Console.WriteLine("login attempts: " + loginAttempts + " of 3");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                    }
                }catch (InvalidOperationException) {
                    Console.Clear();
                    loginAttempts++;

                    Console.WriteLine("Your username or password is incorect, try again !!!");
                    Console.WriteLine("login attempts: " + loginAttempts + " of 3");
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                conn.Close();                 
                }
                MainMenu();           
        }
        static void Main(string[] args)
        {
             conn = new SqlConnection(Program.connectionString);
                try
                {
                    conn.Open();
                    Console.WriteLine("Connectie is gelukt");
                    Console.ReadLine();
                }
                catch (SqlException)
                {
                    Console.WriteLine("Connectie is niet gelukt.");
                    Console.ReadLine();
                    return;
                }
                conn.Close();
                Login();
        }

        static void EXIT()
        {
            Environment.Exit(0);
        }
        //Password Masking
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }

                //This will create a table.
        static int tableWidth = 85;
        

        static void PrintRow(params string[] columns)
         {
             int width = (tableWidth - columns.Length) / columns.Length;
             string row = "|";

             foreach (string column in columns)
             {
                 row += AlignCentre(column, width) + "|";
             }

             Console.WriteLine(row);
         }

         static string AlignCentre(string text, int width)
         {
             text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

             if (string.IsNullOrEmpty(text))
             {
                 return new string(' ', width);
             }
             else
             {
                 return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
             }
         }

    }
}
public class User
{
    public string username;
    public string password;
    public int id;

    public User(string username, string password)
    {
        this.username = username;
        this.password = password;
        
    }
}
