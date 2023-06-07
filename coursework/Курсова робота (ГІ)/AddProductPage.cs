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
    public partial class AddProductPage : Form
    {
        public AddProductPage()
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
            EmployeePage employeePage = new EmployeePage();
            employeePage.StartPosition = FormStartPosition.Manual;
            employeePage.Location = new Point(x, y);
            employeePage.Show();
        }
        Point lastPoint;
        private void AddProductPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddProductPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            AddFoodPage addFoodPage = new AddFoodPage();
            addFoodPage.StartPosition = FormStartPosition.Manual;
            addFoodPage.Location = new Point(x, y);
            addFoodPage.Show();
        }

        private void accessoriesButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            unitPage addAccessoriesPage = new unitPage();
            addAccessoriesPage.StartPosition = FormStartPosition.Manual;
            addAccessoriesPage.Location = new Point(x, y);
            addAccessoriesPage.Show();
        }

        private void clothesButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            AddClothesPage addClothesPage = new AddClothesPage();
            addClothesPage.StartPosition = FormStartPosition.Manual;
            addClothesPage.Location = new Point(x, y);
            addClothesPage.Show();
        }

        private void footwearButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            AddFootwearPage addFootwearPage = new AddFootwearPage();
            addFootwearPage.StartPosition = FormStartPosition.Manual;
            addFootwearPage.Location = new Point(x, y);
            addFootwearPage.Show();
        }
    }
}
