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

namespace Coursework
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
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
            PasswordPage passwordPage = new PasswordPage();
            passwordPage.StartPosition = FormStartPosition.Manual;
            passwordPage.Location = new Point(x, y);
            passwordPage.Show();
        }
        Point lastPoint;
        private void EmployeePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void EmployeePage_MouseDown(object sender, MouseEventArgs e)
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

        private void addProductButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            AddProductPage addProductPage = new AddProductPage();
            addProductPage.StartPosition = FormStartPosition.Manual;
            addProductPage.Location = new Point(x, y);
            addProductPage.Show();
        }

        private void discountProductButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            ReducePricePage reducePricePage = new ReducePricePage();
            reducePricePage.StartPosition = FormStartPosition.Manual;
            reducePricePage.Location = new Point(x, y);
            reducePricePage.Show();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            RemoveProductPage removeProductPage = new RemoveProductPage();
            removeProductPage.StartPosition = FormStartPosition.Manual;
            removeProductPage.Location = new Point(x, y);
            removeProductPage.Show();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            InventoryPage inventoryPage = new InventoryPage();
            inventoryPage.StartPosition = FormStartPosition.Manual;
            inventoryPage.Location = new Point(x, y);
            inventoryPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            AddOldProductPage addOldProductPage = new AddOldProductPage();
            addOldProductPage.StartPosition = FormStartPosition.Manual;
            addOldProductPage.Location = new Point(x, y);
            addOldProductPage.Show();
        }
    }
}
