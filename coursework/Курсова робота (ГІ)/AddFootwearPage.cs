using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Coursework
{
    public partial class AddFootwearPage : Form
    {
        private Store store;
        double price = 0;
        int num_37 = 0;
        int num_38 = 0;
        int num_39 = 0;
        int num_40 = 0;
        int num_41 = 0;
        int num_42 = 0;
        int num_43 = 0;
        int num_44 = 0;
        string pathImage;
        public AddFootwearPage()
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
        private void AddFootwearPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddFootwearPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool is37SizeValid = CheckBox37.Checked && int.TryParse(TextBoxNum37.Text, out num_37);
            bool is38SizeValid = CheckBox38.Checked && int.TryParse(TextBoxNum38.Text, out num_38);
            bool is39SizeValid = CheckBox39.Checked && int.TryParse(TextBoxNum39.Text, out num_39);
            bool is40SizeValid = CheckBox40.Checked && int.TryParse(TextBoxNum40.Text, out num_40);
            bool is41SizeValid = CheckBox41.Checked && int.TryParse(TextBoxNum41.Text, out num_41);
            bool is42SizeValid = CheckBox42.Checked && int.TryParse(TextBoxNum42.Text, out num_42);
            bool is43SizeValid = CheckBox43.Checked && int.TryParse(TextBoxNum43.Text, out num_43);
            bool is44SizeValid = CheckBox44.Checked && int.TryParse(TextBoxNum44.Text, out num_44);
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
            else if (materialTextBox.Text == "" || materialTextBox.Text == " ")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter the name of the material:\r\n");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                materialTextBox.Focus();
                materialTextBox.SelectAll();
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
            else if (!CheckBox37.Checked && !CheckBox38.Checked && !CheckBox39.Checked &&
                    !CheckBox40.Checked && !CheckBox41.Checked && !CheckBox42.Checked && !CheckBox43.Checked && !CheckBox44.Checked)
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("You need to choose at least one size");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
            }
            else if (CheckBox37.Checked && string.IsNullOrEmpty(TextBoxNum37.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 37");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum37.Focus();
                TextBoxNum37.SelectAll();

            }
            else if (CheckBox38.Checked && string.IsNullOrEmpty(TextBoxNum38.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 38");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum38.Focus();
                TextBoxNum38.SelectAll();

            }
            else if (CheckBox39.Checked && string.IsNullOrEmpty(TextBoxNum39.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 39");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum39.Focus();
                TextBoxNum39.SelectAll();

            }
            else if (CheckBox40.Checked && string.IsNullOrEmpty(TextBoxNum40.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 40");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum40.Focus();
                TextBoxNum40.SelectAll();

            }
            else if (CheckBox41.Checked && string.IsNullOrEmpty(TextBoxNum41.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 41");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum41.Focus();
                TextBoxNum41.SelectAll();

            }
            else if (CheckBox42.Checked && string.IsNullOrEmpty(TextBoxNum42.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 42");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum42.Focus();
                TextBoxNum42.SelectAll();

            }
            else if (CheckBox43.Checked && string.IsNullOrEmpty(TextBoxNum43.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 43");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum43.Focus();
                TextBoxNum43.SelectAll();

            }
            else if (CheckBox44.Checked && string.IsNullOrEmpty(TextBoxNum44.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size 44");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum44.Focus();
                TextBoxNum44.SelectAll();

            }
            else if (CheckBox37.Checked && (!is37SizeValid || (is37SizeValid && Convert.ToInt32(TextBoxNum37.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 37 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum37.Focus();
                TextBoxNum37.SelectAll();

            }
            else if (CheckBox38.Checked && (!is38SizeValid || (is38SizeValid && Convert.ToInt32(TextBoxNum38.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 38 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum38.Focus();
                TextBoxNum38.SelectAll();

            }
            else if (CheckBox39.Checked && (!is39SizeValid || (is39SizeValid && Convert.ToInt32(TextBoxNum39.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 39 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum39.Focus();
                TextBoxNum39.SelectAll();

            }
            else if (CheckBox40.Checked && (!is40SizeValid || (is40SizeValid && Convert.ToInt32(TextBoxNum40.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 40 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum40.Focus();
                TextBoxNum40.SelectAll();

            }
            else if (CheckBox41.Checked && (!is41SizeValid || (is41SizeValid && Convert.ToInt32(TextBoxNum41.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 41 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum41.Focus();
                TextBoxNum41.SelectAll();

            }
            else if (CheckBox42.Checked && (!is42SizeValid || (is42SizeValid && Convert.ToInt32(TextBoxNum42.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 42 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum42.Focus();
                TextBoxNum42.SelectAll();

            }
            else if (CheckBox43.Checked && (!is43SizeValid || (is43SizeValid && Convert.ToInt32(TextBoxNum43.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 43 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum43.Focus();
                TextBoxNum43.SelectAll();

            }
            else if (CheckBox44.Checked && (!is44SizeValid || (is44SizeValid && Convert.ToInt32(TextBoxNum44.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size 44 is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                TextBoxNum44.Focus();
                TextBoxNum44.SelectAll();

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
                    Dictionary<int, int> footwearSizes = new Dictionary<int, int>(); ;
                    if (CheckBox37.Checked)
                    {
                        footwearSizes[37] = Convert.ToInt32(TextBoxNum37.Text);
                    }
                    if (CheckBox38.Checked)
                    {
                        footwearSizes[38] = Convert.ToInt32(TextBoxNum38.Text);
                    }
                    if (CheckBox39.Checked)
                    {
                        footwearSizes[39] = Convert.ToInt32(TextBoxNum39.Text);
                    }
                    if (CheckBox40.Checked)
                    {
                        footwearSizes[40] = Convert.ToInt32(TextBoxNum40.Text);
                    }
                    if (CheckBox41.Checked)
                    {
                        footwearSizes[41] = Convert.ToInt32(TextBoxNum41.Text);
                    }
                    if (CheckBox42.Checked)
                    {
                        footwearSizes[42] = Convert.ToInt32(TextBoxNum42.Text);
                    }
                    if (CheckBox43.Checked)
                    {
                        footwearSizes[43] = Convert.ToInt32(TextBoxNum43.Text);
                    }
                    if (CheckBox44.Checked)
                    {
                        footwearSizes[44] = Convert.ToInt32(TextBoxNum44.Text);
                    }

                    if (pathImageTextBox.Text == "")
                    {
                        pathImage = "C:\\Users\\Віта\\Desktop\\фон\\no image.png";
                    }
                    else
                    {
                        pathImage = pathImageTextBox.Text;
                    }
                    if (categoryDomainUpDown.Text == "Shoes")
                    {
                        Footwear shoes = new Shoes()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Material = materialTextBox.Text,
                            Sizes = footwearSizes
                        };
                        string message = store + shoes;
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
                            MyMessageBox messageBox = new MyMessageBox("Shoes category.\r\n" + store.DisplayProductDetails(shoes.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Sneakers")
                    {
                        Footwear sneakers = new Sneakers()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Material = materialTextBox.Text,
                            Sizes = footwearSizes
                        };
                        string message = store + sneakers;
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
                            MyMessageBox messageBox = new MyMessageBox("Sneakers category\r\n" + store.DisplayProductDetails(sneakers.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }

                    }
                    else if (categoryDomainUpDown.Text == "Slippers")
                    {
                        Footwear slippers = new Slippers()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Material = materialTextBox.Text,
                            Sizes = footwearSizes
                        };
                        string message = store + slippers;
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
                            MyMessageBox messageBox = new MyMessageBox("Slippers category.\r\n" + store.DisplayProductDetails(slippers.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Sandals")
                    {
                        Footwear sandals = new Sandals()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Material = materialTextBox.Text,
                            Sizes = footwearSizes
                        };
                        string message = store + sandals;
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
                            MyMessageBox messageBox = new MyMessageBox("Sandals category.\r\n" + store.DisplayProductDetails(sandals.Name) + "\r\n" + message);
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
