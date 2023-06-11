﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;

namespace Coursework
{
    public partial class ReducePricePage : Form
    {
        private Store store;
        double discount = 0;
        string pathImage;
        public ReducePricePage()
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
            EmployeePage employeePage = new EmployeePage();
            employeePage.StartPosition = FormStartPosition.Manual;
            employeePage.Location = new Point(x, y);
            employeePage.Show();
        }
        Point lastPoint;
        private void ReducePricePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ReducePricePage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void discountButton_Click(object sender, EventArgs e)
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
            else if (discountTextBox.Text == "" || discountTextBox.Text == " ")
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Enter a discount");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                discountTextBox.Focus();
                discountTextBox.SelectAll();
            }
            else if (!double.TryParse(discountTextBox.Text, out discount))
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("The discount was entered in the wrong format! Try again");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

                discountTextBox.Focus();
                discountTextBox.SelectAll();
            }
            else
            { 

                string message = store.ApplyDiscount(nameProductTextBox.Text, Convert.ToDouble(discountTextBox.Text));
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox(message);
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();

            }
        }
    }
}
