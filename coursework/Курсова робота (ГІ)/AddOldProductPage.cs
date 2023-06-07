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
    public partial class AddOldProductPage : Form
    {
        private Store store;
        int quantity = 0;
        public AddOldProductPage()
        {
            this.store = Store.store;
            InitializeComponent();
            clothingSizeGroupBox.Visible = false;
            footwearSizeGroupBox.Visible = false;
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
            EmployeePage employeePage = new EmployeePage();
            employeePage.StartPosition = FormStartPosition.Manual;
            employeePage.Location = new Point(x, y);
            employeePage.Show();
        }
        Point lastPoint;
        private void AddOldProductPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddOldProductPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isQuantityValid = int.TryParse(quantityTextBox.Text, out quantity);
            if (nameProductTextBox.Text == "" || nameProductTextBox.Text == " ")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter the name of the product");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                nameProductTextBox.Focus();
                nameProductTextBox.SelectAll();
            }
            else if (quantityTextBox.Text == "")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter the quantity of the product");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }
            else if (!isQuantityValid)
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("The quantity of the product is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }
            else if(isQuantityValid && Convert.ToInt32(quantity) <= 0)
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("The quantity of the product must be greater than 0!");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }
            else if (store.isClothing(nameProductTextBox.Text))
            {
                footwearSizeGroupBox.Visible = false;
                clothingSizeGroupBox.Visible = true;
                
                bool radioButtonSelected = false;

                string selectedSize = "";
                foreach (System.Windows.Forms.RadioButton radioButton in clothingSizeGroupBox.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (radioButton.Checked)
                    {
                        radioButtonSelected = true;
                        selectedSize = radioButton.Text;
                        break;
                    }
                }

                if (!radioButtonSelected)
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                    MyMessageBox messageBox = new MyMessageBox("Choose a size!");
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                }
                else
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                    MyMessageBox messageBox = new MyMessageBox(store.AddOldProduct(nameProductTextBox.Text, Convert.ToInt32(quantityTextBox.Text), selectedSize, 0));
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                }
            }
            else if (store.isFootwear(nameProductTextBox.Text))
            {
                clothingSizeGroupBox.Visible = false;
                footwearSizeGroupBox.Visible = true;
                bool radioButtonSelected = false;
                string selectedSize = "";

                foreach (System.Windows.Forms.RadioButton radioButton in footwearSizeGroupBox.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (radioButton.Checked)
                    {
                        radioButtonSelected = true;
                        selectedSize = radioButton.Text;
                        break;
                    }
                }

                if (!radioButtonSelected)
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                    MyMessageBox messageBox = new MyMessageBox("Choose a size!");
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                }
                else
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                    MyMessageBox messageBox = new MyMessageBox(store.AddOldProduct(nameProductTextBox.Text, Convert.ToInt32(quantityTextBox.Text), null, Convert.ToInt32(selectedSize)));
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                }
            }
            else
            {
                clothingSizeGroupBox.Visible = false;
                footwearSizeGroupBox.Visible = false;
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox(store.AddOldProduct(nameProductTextBox.Text, Convert.ToInt32(quantityTextBox.Text), null, 0));
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
            }
        }
    }
}
