using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Coursework
{
    public partial class StartBuyerPage : Form
    {
        public static Buyer buyer;
        int number = 0;
        public StartBuyerPage()
        {
            
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnBatton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            StartPage startPage = new StartPage();
            startPage.StartPosition = FormStartPosition.Manual;
            startPage.Location = new Point(x, y);
            startPage.Show();
        }
        Point lastPoint;
        private void StartBuyerPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StartBuyerPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            bool isNumberValid = int.TryParse(numberTextBox.Text, out number);
            if (firstNameTextBox.Text == "")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a name");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                firstNameTextBox.Focus();
                firstNameTextBox.SelectAll();
            }
            else if (lastNameTextBox.Text == "")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter your last name");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                lastNameTextBox.Focus();
                lastNameTextBox.SelectAll();
            }
            else if (addressTextBox.Text == "")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter the address");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                addressTextBox.Focus();
                addressTextBox.SelectAll();
            }
            else if (numberTextBox.Text == "")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter the number");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                numberTextBox.Focus();
                numberTextBox.SelectAll();
            }
            else if (!isNumberValid || numberTextBox.Text.Length != 10 || numberTextBox.Text[0] != '0')
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("The number entered is not in the correct format!" +
                    "\r\nThe number must start with 0! \r\nThe number must have 10 digit!");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                numberTextBox.Focus();
                numberTextBox.SelectAll();
            }
            else
            {
                buyer = new Buyer(firstNameTextBox.Text, lastNameTextBox.Text, addressTextBox.Text, numberTextBox.Text);
                int x = this.Location.X;
                int y = this.Location.Y;
                this.Hide();
                BuyerPage buyerPage = new BuyerPage();
                buyerPage.StartPosition = FormStartPosition.Manual;
                buyerPage.Location = new Point(x, y);
                buyerPage.Show();
            }
        }
    }
}
