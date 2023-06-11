namespace Coursework
{
    partial class CheckPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPage));
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.returnStartButton = new System.Windows.Forms.Button();
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.saveCheckToFileButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Linen;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Brown;
            this.exitButton.Location = new System.Drawing.Point(590, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 48);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "x";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "The Victoria Boutique";
            // 
            // returnStartButton
            // 
            this.returnStartButton.BackColor = System.Drawing.Color.Linen;
            this.returnStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnStartButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnStartButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.returnStartButton.Location = new System.Drawing.Point(100, 672);
            this.returnStartButton.Name = "returnStartButton";
            this.returnStartButton.Size = new System.Drawing.Size(451, 66);
            this.returnStartButton.TabIndex = 21;
            this.returnStartButton.Text = "Return to the start page";
            this.returnStartButton.UseVisualStyleBackColor = false;
            this.returnStartButton.Click += new System.EventHandler(this.returnStartButton_Click);
            // 
            // checkTextBox
            // 
            this.checkTextBox.BackColor = System.Drawing.Color.Linen;
            this.checkTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.checkTextBox.Location = new System.Drawing.Point(35, 132);
            this.checkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkTextBox.Multiline = true;
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.ReadOnly = true;
            this.checkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.checkTextBox.Size = new System.Drawing.Size(566, 458);
            this.checkTextBox.TabIndex = 22;
            // 
            // saveCheckToFileButton
            // 
            this.saveCheckToFileButton.BackColor = System.Drawing.Color.Linen;
            this.saveCheckToFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCheckToFileButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveCheckToFileButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.saveCheckToFileButton.Location = new System.Drawing.Point(297, 618);
            this.saveCheckToFileButton.Name = "saveCheckToFileButton";
            this.saveCheckToFileButton.Size = new System.Drawing.Size(313, 48);
            this.saveCheckToFileButton.TabIndex = 23;
            this.saveCheckToFileButton.Text = "Save the check to a file";
            this.saveCheckToFileButton.UseVisualStyleBackColor = false;
            this.saveCheckToFileButton.Click += new System.EventHandler(this.saveCheckToFileButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.BackColor = System.Drawing.Color.Linen;
            this.selectFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFileButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFileButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.selectFileButton.Location = new System.Drawing.Point(23, 618);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(268, 48);
            this.selectFileButton.TabIndex = 30;
            this.selectFileButton.Text = "Select a file";
            this.selectFileButton.UseVisualStyleBackColor = false;
            this.selectFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 750);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.saveCheckToFileButton);
            this.Controls.Add(this.checkTextBox);
            this.Controls.Add(this.returnStartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckPage";
            this.Text = "CheckPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnStartButton;
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.Button saveCheckToFileButton;
        private System.Windows.Forms.Button selectFileButton;
    }
}