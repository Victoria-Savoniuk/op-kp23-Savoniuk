using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;

namespace Coursework
{
    public partial class AddClothesPage : Form
    {
        private Store store;
        double price = 0;
        int xsNum = 0;
        int sNum = 0;
        int mNum = 0;
        int xmNum = 0;
        int lNum = 0;
        int xlNum = 0;
        string pathImage;
        public AddClothesPage()
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
        private void AddClothesPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddClothesPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isXsSizeValid = xsCheckBox.Checked && int.TryParse(xsNumTextBox.Text, out xsNum);
            bool isSSizeValid = sCheckBox.Checked && int.TryParse(sNumTextBox.Text, out sNum);
            bool isMSizeValid = mCheckBox.Checked && int.TryParse(mNumTextBox.Text, out mNum);
            bool isXmSizeValid = xmCheckBox.Checked && int.TryParse(xmNumTextBox.Text, out xmNum);
            bool isLSizeValid = lCheckBox.Checked && int.TryParse(lNumTextBox.Text, out lNum);
            bool isXlSizeValid = xlCheckBox.Checked && int.TryParse(xlNumTextBox.Text, out xlNum);
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
            else if(!xsCheckBox.Checked && !sCheckBox.Checked && !mCheckBox.Checked &&
                    !xmCheckBox.Checked && !lCheckBox.Checked && !xlCheckBox.Checked)
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("You need to choose at least one size");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
            }
            else if (xsCheckBox.Checked && string.IsNullOrEmpty(xsNumTextBox.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size XS");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                xsNumTextBox.Focus();
                xsNumTextBox.SelectAll();

            }
            else if (sCheckBox.Checked && string.IsNullOrEmpty(sNumTextBox.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size S");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                sNumTextBox.Focus();
                sNumTextBox.SelectAll();
            }
            else if (mCheckBox.Checked && string.IsNullOrEmpty(mNumTextBox.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size M");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                mNumTextBox.Focus();
                mNumTextBox.SelectAll();
            }
            else if (xmCheckBox.Checked && string.IsNullOrEmpty(xmNumTextBox.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size XM");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                xmNumTextBox.Focus();
                xmNumTextBox.SelectAll();
            }
            else if (lCheckBox.Checked && string.IsNullOrEmpty(lNumTextBox.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size L");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                lNumTextBox.Focus();
                lNumTextBox.SelectAll();
            }
            else if (xlCheckBox.Checked && string.IsNullOrEmpty(xlNumTextBox.Text))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a value for size XL");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                xlNumTextBox.Focus();
                xlNumTextBox.SelectAll();
            }
            else if (xsCheckBox.Checked && (!isXsSizeValid || (isXsSizeValid && Convert.ToInt32(xsNumTextBox.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size XS is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                xsNumTextBox.Focus();
                xsNumTextBox.SelectAll();

            }
            else if (sCheckBox.Checked && (!isSSizeValid || (isSSizeValid && Convert.ToInt32(sNumTextBox.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size S is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                sNumTextBox.Focus();
                sNumTextBox.SelectAll();
            }
            else if (mCheckBox.Checked && (!isMSizeValid || (isMSizeValid && Convert.ToInt32(mNumTextBox.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size M is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                mNumTextBox.Focus();
                mNumTextBox.SelectAll();
            }
            else if (xmCheckBox.Checked && (!isXmSizeValid || (isXmSizeValid && Convert.ToInt32(xmNumTextBox.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size XM is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                xmNumTextBox.Focus();
                xmNumTextBox.SelectAll();
            }
            else if (lCheckBox.Checked && (!isLSizeValid || (isLSizeValid && Convert.ToInt32(lNumTextBox.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size L is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                lNumTextBox.Focus();
                lNumTextBox.SelectAll();
            }
            else if (xlCheckBox.Checked && (!isXlSizeValid || (isXlSizeValid && Convert.ToInt32(xlNumTextBox.Text) <= 0)))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Size XL is entered incorrectly! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                xlNumTextBox.Focus();
                xlNumTextBox.SelectAll();
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
                  
                    Dictionary<string, int> clothingSizes = new Dictionary<string, int>(); ;
                    if (xsCheckBox.Checked)
                    {
                        clothingSizes["XS"] = Convert.ToInt32(xsNumTextBox.Text);
                    }
                    if (sCheckBox.Checked)
                    {
                        clothingSizes["S"] = Convert.ToInt32(sNumTextBox.Text);
                    }
                    if (mCheckBox.Checked)
                    {
                        clothingSizes["M"] = Convert.ToInt32(mNumTextBox.Text);
                    }
                    if (xmCheckBox.Checked)
                    {
                        clothingSizes["XM"] = Convert.ToInt32(xmNumTextBox.Text);
                    }
                    if (lCheckBox.Checked)
                    {
                        clothingSizes["L"] = Convert.ToInt32(lNumTextBox.Text);
                    }
                    if (xlCheckBox.Checked)
                    {
                        clothingSizes["XL"] = Convert.ToInt32(xlNumTextBox.Text);
                    }

                    if (pathImageTextBox.Text == "")
                    {
                        pathImage = "C:\\Users\\Віта\\Desktop\\фон\\no image.png";
                    }
                    else
                    {
                        pathImage = pathImageTextBox.Text;
                    }
                    if (categoryDomainUpDown.Text == "Dress")
                    {
                        Clothing dress = new Dress()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + dress;
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
                            MyMessageBox messageBox = new MyMessageBox("Dress category.\r\n" + store.DisplayProductDetails(dress.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }

                    }
                    else if (categoryDomainUpDown.Text == "Skirt")
                    {
                        Clothing skirt = new Skirt()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + skirt;
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
                            MyMessageBox messageBox = new MyMessageBox("Skirt category\r\n" + store.DisplayProductDetails(skirt.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Outerwear")
                    {
                        Clothing outerwear = new Outerwear()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + outerwear;
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
                            MyMessageBox messageBox = new MyMessageBox("Outerwear category.\r\n" + store.DisplayProductDetails(outerwear.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Sportswear")
                    {
                        Clothing sportswear = new Sportswear()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + sportswear;
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
                            MyMessageBox messageBox = new MyMessageBox("Sportswear category.\r\n" + store.DisplayProductDetails(sportswear.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "TShirt")
                    {
                        Clothing tShirt = new TShirt()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + tShirt;
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
                            MyMessageBox messageBox = new MyMessageBox("TShirt category.\r\n" + store.DisplayProductDetails(tShirt.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Sweater")
                    {
                        Clothing sweater = new Sweater()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + sweater;
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
                            MyMessageBox messageBox = new MyMessageBox("Sweater category.\r\n" + store.DisplayProductDetails(sweater.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Pants")
                    {
                        Clothing pants = new Pants()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + pants;
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
                            MyMessageBox messageBox = new MyMessageBox("Pants category.\r\n" + store.DisplayProductDetails(pants.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Shorts")
                    {
                        Clothing shorts = new Shorts()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + shorts;
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
                            MyMessageBox messageBox = new MyMessageBox("Shorts category.\r\n" + store.DisplayProductDetails(shorts.Name) + "\r\n" + message);
                            messageBox.StartPosition = FormStartPosition.Manual;
                            messageBox.Location = new Point(x, y);
                            messageBox.ShowDialog();
                        }
                    }
                    else if (categoryDomainUpDown.Text == "Pajamas")
                    {
                        Clothing pajamas = new Pajamas()
                        {
                            Name = nameProductTextBox.Text,
                            Price = Convert.ToDouble(priceTextBox.Text),
                            Unit = unitTextBox.Text,
                            PathImage = pathImage,
                            Sizes = clothingSizes
                        };
                        string message = store + pajamas;
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
                            MyMessageBox messageBox = new MyMessageBox("Pajamas category.\r\n" + store.DisplayProductDetails(pajamas.Name) + "\r\n" + message);
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
