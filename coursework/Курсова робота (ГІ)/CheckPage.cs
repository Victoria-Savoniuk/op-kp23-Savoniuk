using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework
{
    public partial class CheckPage : Form
    {
        private ShoppingCart shoppingCart;
        string filePath;
        public CheckPage()
        {
            this.shoppingCart = ShoppingCart.shoppingCart;
            InitializeComponent();
            checkTextBox.Text = shoppingCart.Checkout();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void CheckPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CheckPage_MouseDown(object sender, MouseEventArgs e)
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

        private void saveCheckToFileButton_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Select a file!\r\n");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
            }
            else
            {
                shoppingCart.WriteCheckoutToFile(checkTextBox.Text, filePath);
                int x = this.Location.X + (this.Width - 339) / 2;
                int y = this.Location.Y + (this.Height - 355) / 2;
                MyMessageBox messageBox = new MyMessageBox("Check saved to file!");
                messageBox.StartPosition = FormStartPosition.Manual;
                messageBox.Location = new Point(x, y);
                messageBox.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = folderDialog.SelectedPath + "\\Чек.txt";
                }
            }
        }
    }
}
