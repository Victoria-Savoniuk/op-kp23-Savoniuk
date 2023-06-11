using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Coursework
{
    public partial class ProductPage : Form
    {
        private Store store;
        private ShoppingCart shoppingCart;
        string nameProduct;
        int quantity = 0;
        public ProductPage(string nameProduct)
        {
            this.store = Store.store;
            this.shoppingCart = ShoppingCart.shoppingCart;
            this.nameProduct = nameProduct;
            InitializeComponent();
            productsTextBox.Text = store.DisplayProductDetails(nameProduct);
            productPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            productPictureBox.Image = Image.FromFile(store.PathImage(nameProduct));
            if (store.isClothing(nameProduct))
            {
                foreach (System.Windows.Forms.RadioButton radioButton in clothingSizeGroupBox.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (!store.ClothingSize(nameProduct).ContainsKey(radioButton.Text))
                    {
                        radioButton.Enabled = false;
                    }
                }
                clothingSizeGroupBox.Visible = true;
            }
            else if(store.isFootwear(nameProduct))
            {
                foreach (System.Windows.Forms.RadioButton radioButton in footwearSizeGroupBox.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (!store.FootwearSize(nameProduct).ContainsKey(Convert.ToInt32(radioButton.Text)))
                    {
                        radioButton.Enabled = false;
                    }
                }
                footwearSizeGroupBox.Visible = true;
            }
            
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
            BuyerPage buyerPage = new BuyerPage();
            buyerPage.StartPosition = FormStartPosition.Manual;
            buyerPage.Location = new Point(x, y);
            buyerPage.Show();
        }
        Point lastPoint;
        private void ProductPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ProductPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void addShoppingCartButton_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
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
            else if (store.isClothing(nameProduct))
            {
                bool radioButtonSelected = false;
                string selectedSize = "";
;
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
                    MyMessageBox messageBox = new MyMessageBox(store.SellProduct(shoppingCart, nameProduct, selectedSize, Convert.ToInt32(quantityTextBox.Text)));
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                    int x_1 = this.Location.X;
                    int y_1 = this.Location.Y;
                    this.Hide();
                    ProductPage productPage = new ProductPage(nameProduct);
                    productPage.StartPosition = FormStartPosition.Manual;
                    productPage.Location = new Point(x_1, y_1);
                    productPage.Show();
                }
            }
            else if (store.isFootwear(nameProduct))
            {
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
                    MyMessageBox messageBox = new MyMessageBox(store.SellProduct(shoppingCart, nameProduct, Convert.ToInt32(selectedSize), Convert.ToInt32(quantityTextBox.Text)));
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                    int x_1 = this.Location.X;
                    int y_1 = this.Location.Y;
                    this.Hide();
                    ProductPage productPage = new ProductPage(nameProduct);
                    productPage.StartPosition = FormStartPosition.Manual;
                    productPage.Location = new Point(x_1, y_1);
                    productPage.Show();
                }
            }
            else
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox(store.SellProduct(shoppingCart, nameProduct, Convert.ToInt32(quantityTextBox.Text)));
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
                int x_1 = this.Location.X;
                int y_1 = this.Location.Y;
                this.Hide();
                ProductPage productPage = new ProductPage(nameProduct);
                productPage.StartPosition = FormStartPosition.Manual;
                productPage.Location = new Point(x_1, y_1);
                productPage.Show();
            }
        }
    }
}
