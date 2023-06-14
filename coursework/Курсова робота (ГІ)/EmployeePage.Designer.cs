namespace Coursework
{
    partial class EmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.exitButton = new System.Windows.Forms.Button();
            this.returnBatton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.discountProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.returnStartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.exitButton.TabIndex = 2;
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
            this.returnBatton.TabIndex = 10;
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
            this.label1.TabIndex = 11;
            this.label1.Text = "The Victoria Boutique";
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.Linen;
            this.addProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addProductButton.Location = new System.Drawing.Point(95, 166);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(448, 66);
            this.addProductButton.TabIndex = 16;
            this.addProductButton.Text = "Add a new product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // discountProductButton
            // 
            this.discountProductButton.BackColor = System.Drawing.Color.Linen;
            this.discountProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discountProductButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountProductButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.discountProductButton.Location = new System.Drawing.Point(95, 329);
            this.discountProductButton.Name = "discountProductButton";
            this.discountProductButton.Size = new System.Drawing.Size(448, 66);
            this.discountProductButton.TabIndex = 17;
            this.discountProductButton.Text = "Reduce the price of the product";
            this.discountProductButton.UseVisualStyleBackColor = false;
            this.discountProductButton.Click += new System.EventHandler(this.discountProductButton_Click);
            // 
            // removeProductButton
            // 
            this.removeProductButton.BackColor = System.Drawing.Color.Linen;
            this.removeProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeProductButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeProductButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.removeProductButton.Location = new System.Drawing.Point(95, 401);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(448, 66);
            this.removeProductButton.TabIndex = 18;
            this.removeProductButton.Text = "Pick up the product from sale";
            this.removeProductButton.UseVisualStyleBackColor = false;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.Linen;
            this.inventoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.inventoryButton.Location = new System.Drawing.Point(95, 473);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(448, 83);
            this.inventoryButton.TabIndex = 19;
            this.inventoryButton.Text = "Inventory of product balances with calculation of the total value";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // returnStartButton
            // 
            this.returnStartButton.BackColor = System.Drawing.Color.Linen;
            this.returnStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnStartButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnStartButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.returnStartButton.Location = new System.Drawing.Point(95, 562);
            this.returnStartButton.Name = "returnStartButton";
            this.returnStartButton.Size = new System.Drawing.Size(448, 66);
            this.returnStartButton.TabIndex = 20;
            this.returnStartButton.Text = "Return to the start page";
            this.returnStartButton.UseVisualStyleBackColor = false;
            this.returnStartButton.Click += new System.EventHandler(this.returnStartButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(95, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 85);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add quantity of already existing product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnStartButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.discountProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBatton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeePage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeePage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnBatton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button discountProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button returnStartButton;
        private System.Windows.Forms.Button button1;
    }
}