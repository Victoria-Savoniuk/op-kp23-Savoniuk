using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class PasswordPage : Form
    {
        private EmployeeFile employeeFile;
        public static Employee employee;
        public PasswordPage()
        {
            employeeFile = EmployeeFile.employeeFile;
            
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
            StartPage startPage = new StartPage();
            startPage.StartPosition = FormStartPosition.Manual;
            startPage.Location = new Point(x, y);
            startPage.Show();
        }
        Point lastPoint;
        private void PasswordPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PasswordPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            string message = employeeFile.ValidateEmployee(firstNameTextBox.Text + " " + lastNameTextBox.Text, passwordTextBox.Text);
            if(message == "True")
            {
                employee = new Employee(firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text);
                int x = this.Location.X;
                int y = this.Location.Y;
                this.Hide();
                EmployeePage employeePage = new EmployeePage();
                employeePage.StartPosition = FormStartPosition.Manual;
                employeePage.Location = new Point(x, y);
                employeePage.Show();
            }
            else
            {
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
