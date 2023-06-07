namespace Coursework
{
    partial class AddFoodPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFoodPage));
            this.exitButton = new System.Windows.Forms.Button();
            this.returnBatton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameProductLeabel = new System.Windows.Forms.Label();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.pathImageLabel = new System.Windows.Forms.Label();
            this.pathImageTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.lastImportDateDateTimePicke = new System.Windows.Forms.DateTimePicker();
            this.expiryTermDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastImportDateLabel = new System.Windows.Forms.Label();
            this.expiryTermLabel = new System.Windows.Forms.Label();
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
            this.exitButton.TabIndex = 5;
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
            this.returnBatton.TabIndex = 13;
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
            this.label1.TabIndex = 14;
            this.label1.Text = "The Victoria Boutique";
            // 
            // nameProductLeabel
            // 
            this.nameProductLeabel.AutoSize = true;
            this.nameProductLeabel.BackColor = System.Drawing.Color.Linen;
            this.nameProductLeabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProductLeabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nameProductLeabel.Location = new System.Drawing.Point(147, 189);
            this.nameProductLeabel.Name = "nameProductLeabel";
            this.nameProductLeabel.Size = new System.Drawing.Size(348, 34);
            this.nameProductLeabel.TabIndex = 20;
            this.nameProductLeabel.Text = "Enter the name of the product:";
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.BackColor = System.Drawing.Color.Linen;
            this.nameProductTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProductTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nameProductTextBox.Location = new System.Drawing.Point(123, 226);
            this.nameProductTextBox.Multiline = true;
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.Size = new System.Drawing.Size(392, 49);
            this.nameProductTextBox.TabIndex = 21;
            // 
            // pathImageLabel
            // 
            this.pathImageLabel.AutoSize = true;
            this.pathImageLabel.BackColor = System.Drawing.Color.Linen;
            this.pathImageLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathImageLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.pathImageLabel.Location = new System.Drawing.Point(138, 592);
            this.pathImageLabel.Name = "pathImageLabel";
            this.pathImageLabel.Size = new System.Drawing.Size(368, 34);
            this.pathImageLabel.TabIndex = 25;
            this.pathImageLabel.Text = "Enter the full path to the image:";
            // 
            // pathImageTextBox
            // 
            this.pathImageTextBox.BackColor = System.Drawing.Color.Linen;
            this.pathImageTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathImageTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.pathImageTextBox.Location = new System.Drawing.Point(123, 629);
            this.pathImageTextBox.Multiline = true;
            this.pathImageTextBox.Name = "pathImageTextBox";
            this.pathImageTextBox.Size = new System.Drawing.Size(392, 49);
            this.pathImageTextBox.TabIndex = 26;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Linen;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addButton.Location = new System.Drawing.Point(226, 684);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(182, 54);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Linen;
            this.priceLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.priceLabel.Location = new System.Drawing.Point(51, 295);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(185, 34);
            this.priceLabel.TabIndex = 34;
            this.priceLabel.Text = "Enter the price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.Linen;
            this.priceTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.priceTextBox.Location = new System.Drawing.Point(12, 332);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(300, 49);
            this.priceTextBox.TabIndex = 35;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.BackColor = System.Drawing.Color.Linen;
            this.unitLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.unitLabel.Location = new System.Drawing.Point(323, 295);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(301, 34);
            this.unitLabel.TabIndex = 36;
            this.unitLabel.Text = "Enter the unit of measure:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.BackColor = System.Drawing.Color.Linen;
            this.unitTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.unitTextBox.Location = new System.Drawing.Point(318, 332);
            this.unitTextBox.Multiline = true;
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(306, 49);
            this.unitTextBox.TabIndex = 37;
            // 
            // lastImportDateDateTimePicke
            // 
            this.lastImportDateDateTimePicke.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.lastImportDateDateTimePicke.CalendarMonthBackground = System.Drawing.Color.Linen;
            this.lastImportDateDateTimePicke.CalendarTitleBackColor = System.Drawing.Color.Linen;
            this.lastImportDateDateTimePicke.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.lastImportDateDateTimePicke.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.lastImportDateDateTimePicke.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lastImportDateDateTimePicke.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastImportDateDateTimePicke.Location = new System.Drawing.Point(30, 542);
            this.lastImportDateDateTimePicke.Name = "lastImportDateDateTimePicke";
            this.lastImportDateDateTimePicke.Size = new System.Drawing.Size(282, 38);
            this.lastImportDateDateTimePicke.TabIndex = 38;
            this.lastImportDateDateTimePicke.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // expiryTermDateTimePicker
            // 
            this.expiryTermDateTimePicker.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.expiryTermDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Linen;
            this.expiryTermDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Linen;
            this.expiryTermDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.expiryTermDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.expiryTermDateTimePicker.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.expiryTermDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryTermDateTimePicker.Location = new System.Drawing.Point(329, 542);
            this.expiryTermDateTimePicker.Name = "expiryTermDateTimePicker";
            this.expiryTermDateTimePicker.Size = new System.Drawing.Size(282, 38);
            this.expiryTermDateTimePicker.TabIndex = 39;
            this.expiryTermDateTimePicker.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // lastImportDateLabel
            // 
            this.lastImportDateLabel.AutoSize = true;
            this.lastImportDateLabel.BackColor = System.Drawing.Color.Linen;
            this.lastImportDateLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastImportDateLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lastImportDateLabel.Location = new System.Drawing.Point(39, 505);
            this.lastImportDateLabel.Name = "lastImportDateLabel";
            this.lastImportDateLabel.Size = new System.Drawing.Size(251, 34);
            this.lastImportDateLabel.TabIndex = 40;
            this.lastImportDateLabel.Text = "Date of manufacture:";
            // 
            // expiryTermLabel
            // 
            this.expiryTermLabel.AutoSize = true;
            this.expiryTermLabel.BackColor = System.Drawing.Color.Linen;
            this.expiryTermLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryTermLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.expiryTermLabel.Location = new System.Drawing.Point(333, 505);
            this.expiryTermLabel.Name = "expiryTermLabel";
            this.expiryTermLabel.Size = new System.Drawing.Size(195, 34);
            this.expiryTermLabel.TabIndex = 41;
            this.expiryTermLabel.Text = "Expiration date:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Linen;
            this.quantityLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.quantityLabel.Location = new System.Drawing.Point(130, 405);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(385, 34);
            this.quantityLabel.TabIndex = 42;
            this.quantityLabel.Text = "Enter the quantity of the product:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BackColor = System.Drawing.Color.Linen;
            this.quantityTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.quantityTextBox.Location = new System.Drawing.Point(153, 442);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(306, 49);
            this.quantityTextBox.TabIndex = 43;
            // 
            // AddFoodPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 750);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.expiryTermLabel);
            this.Controls.Add(this.lastImportDateLabel);
            this.Controls.Add(this.expiryTermDateTimePicker);
            this.Controls.Add(this.lastImportDateDateTimePicke);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pathImageTextBox);
            this.Controls.Add(this.pathImageLabel);
            this.Controls.Add(this.nameProductTextBox);
            this.Controls.Add(this.nameProductLeabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBatton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFoodPage";
            this.Text = "AddFoodPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddFoodPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddFoodPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnBatton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameProductLeabel;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.Label pathImageLabel;
        private System.Windows.Forms.TextBox pathImageTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.DateTimePicker lastImportDateDateTimePicke;
        private System.Windows.Forms.DateTimePicker expiryTermDateTimePicker;
        private System.Windows.Forms.Label lastImportDateLabel;
        private System.Windows.Forms.Label expiryTermLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}