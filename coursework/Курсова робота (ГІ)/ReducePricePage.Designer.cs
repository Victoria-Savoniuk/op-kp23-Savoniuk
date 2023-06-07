namespace Coursework
{
    partial class ReducePricePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReducePricePage));
            this.exitButton = new System.Windows.Forms.Button();
            this.returnBatton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameProductLeabel = new System.Windows.Forms.Label();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.discountButton = new System.Windows.Forms.Button();
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
            this.exitButton.TabIndex = 3;
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
            this.returnBatton.TabIndex = 11;
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
            this.label1.TabIndex = 12;
            this.label1.Text = "The Victoria Boutique";
            // 
            // nameProductLeabel
            // 
            this.nameProductLeabel.AutoSize = true;
            this.nameProductLeabel.BackColor = System.Drawing.Color.Linen;
            this.nameProductLeabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProductLeabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nameProductLeabel.Location = new System.Drawing.Point(142, 251);
            this.nameProductLeabel.Name = "nameProductLeabel";
            this.nameProductLeabel.Size = new System.Drawing.Size(348, 34);
            this.nameProductLeabel.TabIndex = 21;
            this.nameProductLeabel.Text = "Enter the name of the product:";
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.BackColor = System.Drawing.Color.Linen;
            this.nameProductTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProductTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nameProductTextBox.Location = new System.Drawing.Point(122, 288);
            this.nameProductTextBox.Multiline = true;
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.Size = new System.Drawing.Size(392, 49);
            this.nameProductTextBox.TabIndex = 22;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.BackColor = System.Drawing.Color.Linen;
            this.discountLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.discountLabel.Location = new System.Drawing.Point(190, 379);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(240, 34);
            this.discountLabel.TabIndex = 23;
            this.discountLabel.Text = "Enter discount in %:";
            // 
            // discountTextBox
            // 
            this.discountTextBox.BackColor = System.Drawing.Color.Linen;
            this.discountTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.discountTextBox.Location = new System.Drawing.Point(122, 416);
            this.discountTextBox.Multiline = true;
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(392, 49);
            this.discountTextBox.TabIndex = 24;
            // 
            // discountButton
            // 
            this.discountButton.BackColor = System.Drawing.Color.Linen;
            this.discountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discountButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.discountButton.Location = new System.Drawing.Point(122, 542);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(392, 66);
            this.discountButton.TabIndex = 25;
            this.discountButton.Text = "Make a discount";
            this.discountButton.UseVisualStyleBackColor = false;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // ReducePricePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 750);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.nameProductTextBox);
            this.Controls.Add(this.nameProductLeabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBatton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReducePricePage";
            this.Text = "ReducePricePage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReducePricePage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReducePricePage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnBatton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameProductLeabel;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Button discountButton;
    }
}