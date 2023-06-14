using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Coursework
{
    public partial class ShoppingCartPage : Form
    {
        private Store store;
        private ShoppingCart shoppingCart;
        double _totalCost;
        int footwearSize = 0;
        public ShoppingCartPage()
        {
            this.shoppingCart = ShoppingCart.shoppingCart;
            this.store = Store.store;
            InitializeComponent();
            shoppingCartListView.Visible = false;
            shoppingCartGridView.Visible = false;
            System.Drawing.Image image = System.Drawing.Image.FromFile("C:\\Users\\Віта\\Desktop\\фон\\delete.png");
            if (shoppingCart.ViewCartItems().Count == 0)
            {
                shoppingCartListView.Visible = true;
                shoppingCartListView.Items.Add("Shopping Cart is empty");
            }
            else
            {
                shoppingCartGridView.Visible = true;
                _totalCost = 0;
                foreach (var item in shoppingCart.ViewCartItems())
                {
                    _totalCost += item.TotalPrice;
                    if (item.ClothingSize != null)
                    {
                        shoppingCartGridView.Rows.Add(item.Product.Name, item.ClothingSize, item.Quantity, $"{item.TotalPrice} UAN", image);
                    }
                    else if (item.FootwearSize != 0)
                    {
                        shoppingCartGridView.Rows.Add(item.Product.Name, Convert.ToString(item.FootwearSize), item.Quantity, $"{item.TotalPrice} UAN", image);
                    }
                    else
                    {
                        shoppingCartGridView.Rows.Add(item.Product.Name, "-", item.Quantity, $"{item.TotalPrice} UAN", image);
                    }
                }
                shoppingCartGridView.Rows.Add("Total cost of purchase:", null, null, $"{_totalCost} UAN");
            }
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
            BuyerPage buyerPage = new BuyerPage();
            buyerPage.StartPosition = FormStartPosition.Manual;
            buyerPage.Location = new Point(x, y);
            buyerPage.Show();
        }
        Point lastPoint;
        private void ShoppingCartPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ShoppingCartPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void shoppingCartGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (columnIndex < 4 && rowIndex < shoppingCartGridView.Rows.Count - 2 && rowIndex != -1)
            {
                int x = this.Location.X;
                int y = this.Location.Y;
                this.Hide();
                ProductPage productPage = new ProductPage(shoppingCartGridView.Rows[rowIndex].Cells[0].Value.ToString());
                productPage.StartPosition = FormStartPosition.Manual;
                productPage.Location = new Point(x, y);
                productPage.Show();
                
            }
            else if (columnIndex == 4 && rowIndex < shoppingCartGridView.Rows.Count - 2 && rowIndex != -1)
            {
                string productName = shoppingCartGridView.Rows[rowIndex].Cells[0].Value.ToString();
                string size = shoppingCartGridView.Rows[rowIndex].Cells[1].Value.ToString();
                
                if (int.TryParse(size, out footwearSize))
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                    MyMessageBox messageBox = new MyMessageBox(shoppingCart.RemoveItem(store, productName, "", Convert.ToInt32(size)));
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                }
                else
                {
                    int x = this.Location.X + (this.Width - 339) / 2;
                    int y = this.Location.Y + (this.Height - 355) / 2;
                    MyMessageBox messageBox = new MyMessageBox(shoppingCart.RemoveItem(store, productName, size, 0));
                    messageBox.StartPosition = FormStartPosition.Manual;
                    messageBox.Location = new Point(x, y);
                    messageBox.ShowDialog();
                }
                int x_1 = this.Location.X;
                int y_1 = this.Location.Y;
                this.Hide();
                ShoppingCartPage shoppingCartPage = new ShoppingCartPage();
                shoppingCartPage.StartPosition = FormStartPosition.Manual;
                shoppingCartPage.Location = new Point(x_1, y_1);
                shoppingCartPage.Show();
            }
            else if(rowIndex == -1){}
            else
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox($"Total cost of purchase: {_totalCost} UAN");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
            }
        }
        private void clearCartButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X + (this.Width - 339) / 2;
            int y = this.Location.Y + (this.Height - 355) / 2;
            MyMessageBox messageBox = new MyMessageBox(shoppingCart.ClearCart(store));
            messageBox.StartPosition = FormStartPosition.Manual;
            messageBox.Location = new Point(x, y);
            messageBox.ShowDialog();

            int x_1 = this.Location.X;
            int y_1 = this.Location.Y;
            this.Hide();
            ShoppingCartPage shoppingCartPage = new ShoppingCartPage();
            shoppingCartPage.StartPosition = FormStartPosition.Manual;
            shoppingCartPage.Location = new Point(x_1, y_1);
            shoppingCartPage.Show();

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if(shoppingCartListView.Visible == true)
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Your shopping cart is empty");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
            }
            else
            {
                int x = this.Location.X;
                int y = this.Location.Y;
                this.Hide();
                CheckPage checkPage = new CheckPage();
                checkPage.StartPosition = FormStartPosition.Manual;
                checkPage.Location = new Point(x, y);
                checkPage.Show();
            } 
        }
    }
}
