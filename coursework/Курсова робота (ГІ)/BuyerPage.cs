using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;

namespace Coursework
{
    public partial class BuyerPage : Form
    {
        private Store store;
        Dictionary<string, string> products;
        public BuyerPage()
        {
            this.store = Store.store;
            InitializeComponent();
            products = store.DisplayAllProducts();
            
            
            foreach(var product in products)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 105; 
                pictureBox.Height = 105;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = Image.FromFile(product.Value);
                pictureBox.Tag = product.Key;

                pictureBox.Click += PictureBox_Click;

                flowLayoutPanel.Controls.Add(pictureBox);

            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            

            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            ProductPage productPage = new ProductPage(pictureBox.Tag.ToString());
            productPage.StartPosition = FormStartPosition.Manual;
            productPage.Location = new Point(x, y);
            productPage.Show();
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
            StartBuyerPage startBuyerPage = new StartBuyerPage();
            startBuyerPage.StartPosition = FormStartPosition.Manual;
            startBuyerPage.Location = new Point(x, y);
            startBuyerPage.Show();
        }
        Point lastPoint;
        private void BuyerPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BuyerPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void returnStartButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            StartPage startPage = new StartPage();
            startPage.StartPosition = FormStartPosition.Manual;
            startPage.Location = new Point(x, y);
            startPage.Show();
        }

        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            ShoppingCartPage shoppingCartPage = new ShoppingCartPage();
            shoppingCartPage.StartPosition = FormStartPosition.Manual;
            shoppingCartPage.Location = new Point(x, y);
            shoppingCartPage.Show();
        }
    }
}
