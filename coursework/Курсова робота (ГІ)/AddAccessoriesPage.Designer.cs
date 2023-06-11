namespace Coursework
{
    partial class unitPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unitPage));
            this.exitButton = new System.Windows.Forms.Button();
            this.returnBatton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.nameProductLeabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.pathImageLabel = new System.Windows.Forms.Label();
            this.pathImageTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
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
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "x";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // returnBatton
            // 
            this.returnBatton.BackColor = System.Drawing.Color.Linen;
            this.returnBatton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBatton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnBatton.ForeColor = System.Drawing.Color.Brown;
            this.returnBatton.Location = new System.Drawing.Point(-1, -1);
            this.returnBatton.Name = "returnBatton";
            this.returnBatton.Size = new System.Drawing.Size(47, 48);
            this.returnBatton.TabIndex = 12;
            this.returnBatton.Text = "<";
            this.returnBatton.UseVisualStyleBackColor = false;
            this.returnBatton.Click += new System.EventHandler(this.returnBatton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(72, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 63);
            this.label1.TabIndex = 13;
            this.label1.Text = "The Victoria Boutique";
            // 
            // categoryDomainUpDown
            // 
            this.categoryDomainUpDown.BackColor = System.Drawing.Color.Linen;
            this.categoryDomainUpDown.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.categoryDomainUpDown.ForeColor = System.Drawing.Color.SaddleBrown;
            this.categoryDomainUpDown.Items.Add("Home goods");
            this.categoryDomainUpDown.Items.Add("Headwear");
            this.categoryDomainUpDown.Items.Add("Jewelry");
            this.categoryDomainUpDown.Items.Add("Phone accessories");
            this.categoryDomainUpDown.Location = new System.Drawing.Point(131, 164);
            this.categoryDomainUpDown.Name = "categoryDomainUpDown";
            this.categoryDomainUpDown.Size = new System.Drawing.Size(392, 38);
            this.categoryDomainUpDown.TabIndex = 14;
            this.categoryDomainUpDown.Text = "Select a category";
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.BackColor = System.Drawing.Color.Linen;
            this.nameProductTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProductTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nameProductTextBox.Location = new System.Drawing.Point(131, 253);
            this.nameProductTextBox.Multiline = true;
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.Size = new System.Drawing.Size(392, 49);
            this.nameProductTextBox.TabIndex = 18;
            // 
            // nameProductLeabel
            // 
            this.nameProductLeabel.AutoSize = true;
            this.nameProductLeabel.BackColor = System.Drawing.Color.Linen;
            this.nameProductLeabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProductLeabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nameProductLeabel.Location = new System.Drawing.Point(140, 216);
            this.nameProductLeabel.Name = "nameProductLeabel";
            this.nameProductLeabel.Size = new System.Drawing.Size(348, 34);
            this.nameProductLeabel.TabIndex = 19;
            this.nameProductLeabel.Text = "Enter the name of the product:";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.BackColor = System.Drawing.Color.Linen;
            this.unitLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.unitLabel.Location = new System.Drawing.Point(313, 318);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(301, 34);
            this.unitLabel.TabIndex = 20;
            this.unitLabel.Text = "Enter the unit of measure:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.BackColor = System.Drawing.Color.Linen;
            this.unitTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.unitTextBox.Location = new System.Drawing.Point(319, 355);
            this.unitTextBox.Multiline = true;
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(294, 49);
            this.unitTextBox.TabIndex = 21;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Linen;
            this.priceLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.priceLabel.Location = new System.Drawing.Point(26, 318);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(185, 34);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "Enter the price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.Linen;
            this.priceTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.priceTextBox.Location = new System.Drawing.Point(12, 355);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(290, 49);
            this.priceTextBox.TabIndex = 23;
            // 
            // pathImageLabel
            // 
            this.pathImageLabel.AutoSize = true;
            this.pathImageLabel.BackColor = System.Drawing.Color.Linen;
            this.pathImageLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathImageLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.pathImageLabel.Location = new System.Drawing.Point(140, 552);
            this.pathImageLabel.Name = "pathImageLabel";
            this.pathImageLabel.Size = new System.Drawing.Size(368, 34);
            this.pathImageLabel.TabIndex = 24;
            this.pathImageLabel.Text = "Enter the full path to the image:";
            // 
            // pathImageTextBox
            // 
            this.pathImageTextBox.BackColor = System.Drawing.Color.Linen;
            this.pathImageTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathImageTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.pathImageTextBox.Location = new System.Drawing.Point(131, 589);
            this.pathImageTextBox.Multiline = true;
            this.pathImageTextBox.Name = "pathImageTextBox";
            this.pathImageTextBox.Size = new System.Drawing.Size(392, 49);
            this.pathImageTextBox.TabIndex = 25;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Linen;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addButton.Location = new System.Drawing.Point(239, 658);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(182, 54);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Linen;
            this.quantityLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.quantityLabel.Location = new System.Drawing.Point(125, 432);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(385, 34);
            this.quantityLabel.TabIndex = 43;
            this.quantityLabel.Text = "Enter the quantity of the product:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BackColor = System.Drawing.Color.Linen;
            this.quantityTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.quantityTextBox.Location = new System.Drawing.Point(122, 469);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(388, 49);
            this.quantityTextBox.TabIndex = 44;
            // 
            // unitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 750);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pathImageTextBox);
            this.Controls.Add(this.pathImageLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.nameProductLeabel);
            this.Controls.Add(this.nameProductTextBox);
            this.Controls.Add(this.categoryDomainUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBatton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "unitPage";
            this.Text = "AddAccessoriesPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddAccessoriesPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddAccessoriesPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnBatton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown categoryDomainUpDown;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.Label nameProductLeabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label pathImageLabel;
        private System.Windows.Forms.TextBox pathImageTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}