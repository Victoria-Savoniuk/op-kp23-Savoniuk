using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Coursework;
using static System.Windows.Forms.AxHost;
using System.Resources;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace Coursework
{
    public partial class unitPage : Form
    {
        private Store store;
        double price = 0;
        int quantity = 0;
        string pathImage;
        public unitPage()
        {
            this.store = Store.store;
            InitializeComponent();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
        private void AddAccessoriesPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddAccessoriesPage_MouseDown(object sender, MouseEventArgs e)
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
                    if (categoryDomainUpDown.Text == "Home goods")
                    {
                        Accessory homeGoods = new HomeGoods()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            Quantity = Convert.ToInt32(quantityTextBox.Text),
                            PathImage = pathImage
                        };
                        string message = store + homeGoods;
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
                            MyMessageBox messageBox = new MyMessageBox("Home goods category.\r\n" + store.DisplayProductDetails(homeGoods.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Headwear")
                    {
                        Accessory headwear = new Headwear()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            Quantity = Convert.ToInt32(quantityTextBox.Text),
                            PathImage = pathImage
                        };

                        string message = store + headwear;
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
                            MyMessageBox messageBox = new MyMessageBox("Headwear category.\r\n" + store.DisplayProductDetails(headwear.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Jewelry")
                    {
                        Accessory jewelry = new Jewelry()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            Quantity = Convert.ToInt32(quantityTextBox.Text),
                            PathImage = pathImage
                        };

                        string message = store + jewelry;
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
                            MyMessageBox messageBox = new MyMessageBox("Jewelry category.\r\n" + store.DisplayProductDetails(jewelry.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Phone accessories")
                    {
                        Accessory phoneAccessories = new PhoneAccessories()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            Quantity = Convert.ToInt32(quantityTextBox.Text),
                            PathImage = pathImage
                        };

                        string message = store + phoneAccessories;
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
                            MyMessageBox messageBox = new MyMessageBox("Phone accessories category.\r\n" + store.DisplayProductDetails(phoneAccessories.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else
                    {
                        int x = this.Location.X + (this.Width - 339) / 2;
                        int y = this.Location.Y + (this.Height - 355) / 2;
                        MyMessageBox messageBox = new MyMessageBox("Select a category");
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
