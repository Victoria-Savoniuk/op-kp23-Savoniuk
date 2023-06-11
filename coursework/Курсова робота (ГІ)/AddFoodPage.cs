using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Coursework
{
    public partial class AddFoodPage : Form
    {
        private Store store;
        double price = 0;
        int quantity = 0;
        string pathImage;
        public AddFoodPage()
        {
            this.store = Store.store;
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
            AddProductPage addProductPage = new AddProductPage();
            addProductPage.StartPosition = FormStartPosition.Manual;
            addProductPage.Location = new Point(x, y);
            addProductPage.Show();
        }
        Point lastPoint;
        private void AddFoodPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddFoodPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
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
            else if (unitTextBox.Text == "" || unitTextBox.Text == " ")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter the unit of measurement");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                unitTextBox.Focus();
                unitTextBox.SelectAll();
            }
            else if (priceTextBox.Text == "")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter the price of the product");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                priceTextBox.Focus();
                priceTextBox.SelectAll();
            }
            else if (!double.TryParse(priceTextBox.Text, out price))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("The price was entered in the wrong format! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                priceTextBox.Focus();
                priceTextBox.SelectAll();
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
            else if (!int.TryParse(quantityTextBox.Text, out quantity))
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
            else
            {

                pathImage = pathImageTextBox.Text;
                bool isImage = IsImageFile(pathImage);
                
                if (!File.Exists(pathImage) && pathImageTextBox.Text != "")
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                        MyMessageBox messageBox = new MyMessageBox("Invalid or non-existent file path!");
                        messageBox.StartPosition = FormStartPosition.Manual;
                        messageBox.Location = new Point(x, y);
                        messageBox.ShowDialog();

                        pathImageTextBox.Focus();
                        pathImageTextBox.SelectAll();
                }
                else if (isImage || pathImageTextBox.Text == "")
                {
                    if (pathImageTextBox.Text == "")
                    {
                        pathImage = "C:\\Users\\Віта\\Desktop\\фон\\no image.png";
                    }
                    else
                    {
                        pathImage = pathImageTextBox.Text;
                    }
                    FoodProduct foodProduct = new FoodProduct()
                    {
                        Name = nameProductTextBox.Text,
                        Price = Convert.ToDouble(priceTextBox.Text),
                        Unit = unitTextBox.Text,
                        PathImage = pathImage,
                        Quantity = Convert.ToInt32(quantityTextBox.Text),
                        LastImportDate = lastImportDateDateTimePicke.Text,
                        ExpiryTerm = expiryTermDateTimePicker.Text
                    };
                    string message = store + foodProduct;
                    if (message == "A product with this name already exists! Enter a different product name")
                    {
                        int x = this.Location.X + (this.Width - 339) / 2;
                        int y = this.Location.Y + (this.Height - 355) / 2;
                        MyMessageBox messageBox = new MyMessageBox(message);
                        messageBox.StartPosition = FormStartPosition.Manual;
                        messageBox.Location = new Point(x, y);
                        messageBox.ShowDialog();
                    }
                    else
                    {

                        int x = this.Location.X + (this.Width - 339) / 2;
                        int y = this.Location.Y + (this.Height - 355) / 2;
                        MyMessageBox messageBox = new MyMessageBox("Food Product.\r\n" + store.DisplayProductDetails(foodProduct.Name) + "\r\n" + message);
                        messageBox.StartPosition = FormStartPosition.Manual;
                        messageBox.Location = new Point(x, y);
                        messageBox.ShowDialog();
                    }
                }
                else
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                    MyMessageBox messageBox = new MyMessageBox("File is an image.");
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();

                    pathImageTextBox.Focus();
                    pathImageTextBox.SelectAll();
                }

            }

        }
        static bool IsImageFile(string path)
        {
            string extension = Path.GetExtension(path);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif" };

            return Array.IndexOf(imageExtensions, extension.ToLower()) != -1;
        }
    }
}
