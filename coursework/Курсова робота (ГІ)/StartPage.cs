using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void StartPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StartPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            PasswordPage passwordPage = new PasswordPage();
            passwordPage.StartPosition = FormStartPosition.Manual;
            passwordPage.Location = new Point(x, y);
            passwordPage.Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            PasswordPage passwordPage = new PasswordPage();
            passwordPage.StartPosition = FormStartPosition.Manual;
            passwordPage.Location = new Point(x, y);
            passwordPage.Show();
        }

        private void buyerButton_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Hide();
            StartBuyerPage startBuyerPage = new StartBuyerPage();
            startBuyerPage.StartPosition = FormStartPosition.Manual;
            startBuyerPage.Location = new Point(x, y);
            startBuyerPage.Show();
        }
    }
}
