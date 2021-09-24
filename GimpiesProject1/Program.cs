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

        static void MenuVoorraad()
        {
            Console.Clear();
            int i, j;
            string[,] shoeList = new string[4, 7];
            shoeList[0, 0] = "NUMMER";
            shoeList[0, 1] = "\tMERK";
            shoeList[0, 2] = "\tTYPE";
            shoeList[0, 3] = "\tMAAT";
            shoeList[0, 4] = "\tKLEUR";
            shoeList[0, 5] = "\tAANTAL";
            shoeList[0, 6] = "\tPRIJS";

            shoeList[1, 0] = "1";
            shoeList[1, 1] = "\tNike";
            shoeList[1, 2] = "\tJordan";
            shoeList[1, 3] = "\t43";
            shoeList[1, 4] = "\tRood";
            shoeList[1, 5] = "\t112";
            shoeList[1, 6] = "\t49.99";

            shoeList[2, 0] = "2";
            shoeList[2, 1] = "\tAdidas";
            shoeList[2, 2] = "\tSprint";
            shoeList[2, 3] = "\t39";
            shoeList[2, 4] = "\tZwart";
            shoeList[2, 5] = "\t49";
            shoeList[2, 6] = "\t29.99";

            shoeList[3, 0] = "3";
            shoeList[3, 1] = "\tCompaq";
            shoeList[3, 2] = "\t'89 Q";
            shoeList[3, 3] = "\t41";
            shoeList[3, 4] = "\tGrijs";
            shoeList[3, 5] = "\t86";
            shoeList[3, 6] = "\t39.99";

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(shoeList[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            MainMenu();
        }
        
        //Shoe Inventory, 2-dimensional string array, into console inputting (str to int, calculate, back to string, declare with coords).
        static void MenuInkopen()
        {
            int i, j;
            string shoeNum;
            int InkoopNum;
            
            string[,] shoeList = new string[4, 7];
            shoeList[0, 0] = "NUMMER";
            shoeList[0, 1] = "\tMERK";
            shoeList[0, 2] = "\tTYPE";
            shoeList[0, 3] = "\tMAAT";
            shoeList[0, 4] = "\tKLEUR";
            shoeList[0, 5] = "\tAANTAL";
            shoeList[0, 6] = "\tPRIJS";

            shoeList[1, 0] = "1";
            shoeList[1, 1] = "\tNike";
            shoeList[1, 2] = "\tJordan";
            shoeList[1, 3] = "\t43";
            shoeList[1, 4] = "\tRood";
            shoeList[1, 5] = "\t112";
            shoeList[1, 6] = "\t49.99";

            shoeList[2, 0] = "2";
            shoeList[2, 1] = "\tAdidas";
            shoeList[2, 2] = "\tSprint";
            shoeList[2, 3] = "\t39";
            shoeList[2, 4] = "\tZwart";
            shoeList[2, 5] = "\t49";
            shoeList[2, 6] = "\t29.99";

            shoeList[3, 0] = "3";
            shoeList[3, 1] = "\tCompaq";
            shoeList[3, 2] = "\t'89 Q";
            shoeList[3, 3] = "\t41";
            shoeList[3, 4] = "\tGrijs";
            shoeList[3, 5] = "\t86";
            shoeList[3, 6] = "\t39.99";

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(shoeList[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Write("Enter Shoe Number: ");
            shoeNum = Console.ReadLine();
            Console.Write("Enter amount to add: ");
            InkoopNum = Convert.ToInt32(Console.ReadLine());
            if (InkoopNum <= 0)
            {
                Console.Clear();
                Console.WriteLine("You can't input a negative number!. Try again.");
                Console.ReadLine();
                MenuInkopen();
            }
            
            for (i = 0; i < 4; i++)
            {
                if (shoeNum == shoeList[i, 0])
                {
                    shoeList[i, 5] = Convert.ToString("\t" + (Convert.ToInt32(shoeList[i, 5]) + InkoopNum));
                }
            }
            Console.ReadKey();
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(shoeList[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            MainMenu();
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
            new User("Inkoop","Gimpies_Inkoop",2),
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

                    }
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
