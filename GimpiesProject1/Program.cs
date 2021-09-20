using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimpiesProject1
{
    class Program
    {
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
        //Voorraad voor Schoenen bekijken.
        static void MenuVoorraad()
        {
            try
            {
                DataTable dt = new DataTable("Shoes");
                dt.Columns.Add("Merk: ", typeof(string));
                dt.Columns.Add("Type: ", typeof(string));
                dt.Columns.Add("Size: ", typeof(int));
                dt.Columns.Add("Kleur: ", typeof(string));
                dt.Columns.Add("Aantal: ", typeof(int));
                dt.Columns.Add("Prijs: ", typeof(double));

                dt.Rows.Add("Nike", "Air Max", 42, "Rood", 12, 49.99);
                dt.Rows.Add("Nike", "Air Max", 42, "Rood", 12, 49.99);
                dt.Rows.Add("Nike", "Air Max", 42, "Rood", 12, 49.99);
                dt.Rows.Add("Nike", "Air Max", 42, "Rood", 12, 49.99);
                dt.Rows.Add("Nike", "Air Max", 42, "Rood", 12, 49.99);


                List<Shoes> listShoes = new List<Shoes>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Shoes shoe = new Shoes();
                    shoe.merk = dt.Rows[i]["Merk: "].ToString();
                    shoe.type = dt.Rows[i]["Type: "].ToString();
                    shoe.size = Convert.ToInt32(dt.Rows[i]["Size: "]);
                    shoe.kleur = dt.Rows[i]["Kleur: "].ToString();
                    shoe.aantal = Convert.ToInt32(dt.Rows[i]["Aantal: "]);
                    shoe.prijs = Convert.ToDouble(dt.Rows[i]["Prijs: "]);
                    listShoes.Add(shoe);
                }
                Console.Read();
                Console.WriteLine("Om terug te gaan, druk x");
                string Goback = Console.ReadLine();
                if (Goback == "x")
                {
                    MainMenu();
                }
            }
            catch (FormatException)
            {
                MainMenu();
            }
        }

        static void MenuInkopen()
        {
            string input7;
            List<Shoes> shoesList = new List<Shoes>();
            Console.WriteLine(shoesList);
            do
            {
                //Make a list for shoe inventory. not arrays, not a datatable. a list.
                Console.Clear();
                Console.WriteLine(".");
                string inputCheck = Console.ReadLine();

                Console.Write("Wat voor Merk: ");
                string input1 = Console.ReadLine();
                Console.Write("Wat voor type: ");
                string input2 = Console.ReadLine();
                Console.Write("Wat voor size: ");
                int input3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Wat voor kleur: ");
                string input4 = Console.ReadLine();
                Console.Write("Hoeveel: ");
                int input5 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Wat is de prijs: ");
                double input6 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(input1 + input2 + input3 + input4 + input5 + input6);

                input7 = Console.ReadLine();

                if (input7 != "Y")
                {
                    break;
                }
            } while (input7 == "Y");
            MenuInkopen();
        }

        static void MenuUitloggen()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
        //For Admin privelege at a later date.
        static void MenuAdmin()
        {
            Console.WriteLine();
            Console.ReadLine();

        }
        //Login Screen.
        static void Main(string[] args)
        {
            var arrUsers = new User[] {
            new User("user1","valid1",1),
            new User("user2","valid2",2),
            new User("user3","valid3",3)
                };
            int loginAttempts = 0;
            bool succesfull = false;
            while (!succesfull)
            {
                if (loginAttempts == 3)
                {
                    Console.Clear();
                    Console.Write("You've attempted to log in too many times, This application will now close.");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }

                Console.WriteLine("Login Screen");
                Console.Write("Username: ");
                var username = Console.ReadLine();
                Console.Write("Password: ");
                var password = ReadPassword();
                Console.WriteLine();

                foreach (User user in arrUsers)
                {
                    if (username == user.username && password == user.password)
                    {
                        Console.WriteLine("You logged in succesfully!!!");
                        Console.ReadLine();
                        succesfull = true;
                        break;
                    }
                }
                if (!succesfull)
                {
                    Console.WriteLine("Your username or password is incorect, try again !!!");

                    loginAttempts++;
                    Console.WriteLine("login attempts: " + loginAttempts + " of 3");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            MainMenu();
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
         static void PrintLine()
         {
             Console.WriteLine(new string('-', tableWidth));
         }

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

    public User(string username, string password, int id)
    {
        this.username = username;
        this.password = password;
        this.id = id;
    }
}

public class Shoes
{
    public string merk { get; set; }
    public string type { get; set; }
    public int size { get; set; }
    public string kleur { get; set; }
    public int aantal { get; set; }
    public double prijs { get; set; }

    /*public void SetShoes(string merk, string type, int size, string kleur, int aantal, double prijs)
    {
        this.merk = merk;
        this.type = type;
        this.size = size;
        this.kleur = kleur;
        this.aantal = aantal;
        this.prijs = prijs;
    }
    public void printShoes()
    {
        Console.WriteLine("Inventory 1  : ");
        Console.WriteLine("\tMerk       : " + merk);
        Console.WriteLine("\tType       : " + type);
        Console.WriteLine("\tSize       : " + size);
        Console.WriteLine("\tKleur      : " + kleur);
        Console.WriteLine("\tAantal     : " + aantal);
        Console.WriteLine("\tPrijs      : " + prijs);
    }*/

}
