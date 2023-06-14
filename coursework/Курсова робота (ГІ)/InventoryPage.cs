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
    public partial class InventoryPage : Form
    {
        private Store store;
        public InventoryPage()
        {
            this.store = Store.store;
            InitializeComponent();
            this.inventoryTextBox.Text = store.Inventory();
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
        private void InventoryPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void InventoryPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
