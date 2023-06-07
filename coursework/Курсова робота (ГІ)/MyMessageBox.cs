using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox(string message)
        {
            InitializeComponent();
            
            this.messageTextBox.Text = message;
            messageTextBox.SelectionStart = messageTextBox.Text.Length;
            vScrollBar.Scroll += (sender, e) =>
            {
                messageTextBox.ScrollToCaret(); 
            };

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
