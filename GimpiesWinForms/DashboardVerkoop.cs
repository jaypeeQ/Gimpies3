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
        
        string[] shoeList1 = { "1", "Nike", "Air Max", "42", "Rood", "17", "49,99" };
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

            List<string> shoes = new (shoeList1);
            lvVerkoperScreen.View = View.Details;
            lvVerkoperScreen.Items.Add(new ListViewItem(shoeList1));
            /*lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "1", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));
            lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "2", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));
            lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "3", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));
            lvVerkoperScreen.Items.Add(new ListViewItem(new string[] { "4", "Nike", "Air Max", "42", "Rood", "17", "49,99" }));*/
        }

        public void btSchoenenVerkopen_Click(object sender, EventArgs e)
        {
            CreateMyForm();
            /*VerkoopPopup verkoopPopup = new VerkoopPopup();
            verkoopPopup.Show();*/
        }

        public void CreateMyForm()
        {
            // Create a new instance of the form.
            Form form1 = new Form();
            // Create two buttons to use as the accept and cancel buttons.
            Button button1 = new Button();
            Button button2 = new Button();
            //Create two textboxes for input number.
            TextBox tbVerkoopShoeNum = new TextBox();
            TextBox tbVerkoopAantal = new TextBox();

            // Set the text of button1 to "OK".
            button1.Text = "OK";
            // Set the position of the button on the form.
            button1.Location = new Point(100, 100);
            // Set the text of button2 to "Cancel".
            button2.Text = "Cancel";
            // Set the position of the button based on the location of button1.
            button2.Location
               = new Point(button1.Left, button1.Height + button1.Top + 10);
            tbVerkoopShoeNum.Location = new Point(10, 10);
            tbVerkoopAantal.Location = new Point(tbVerkoopShoeNum.Left, tbVerkoopShoeNum.Height + tbVerkoopShoeNum.Top + 10);
            // Set the caption bar text of the form.   
            form1.Text = "Schoenen Verkopen";
            

            // Define the border style of the form to a dialog box.
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            form1.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            form1.MinimizeBox = false;
            // Set the accept button of the form to button1.
            form1.AcceptButton = button1;
            // Set the cancel button of the form to button2.
            form1.CancelButton = button2;
            // Set the start position of the form to the center of the screen.
            form1.StartPosition = FormStartPosition.CenterScreen;

            // Add button1 to the form.
            form1.Controls.Add(button1);
            // Add button2 to the form.
            form1.Controls.Add(button2);
            form1.Controls.Add(tbVerkoopShoeNum);
            form1.Controls.Add(tbVerkoopAantal);


            // Display the form as a modal dialog box.
            form1.ShowDialog();
        }
    }
}
