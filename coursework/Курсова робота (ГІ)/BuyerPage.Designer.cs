namespace Coursework
{
    partial class BuyerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerPage));
            this.exitButton = new System.Windows.Forms.Button();
            this.returnBatton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.shoppingCartButton = new System.Windows.Forms.Button();
            this.returnStartButton = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(76, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 63);
            this.label1.TabIndex = 13;
            this.label1.Text = "The Victoria Boutique";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Linen;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.flowLayoutPanel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 174);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(600, 426);
            this.flowLayoutPanel.TabIndex = 14;
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.BackColor = System.Drawing.Color.Linen;
            this.shoppingCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shoppingCartButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shoppingCartButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.shoppingCartButton.Location = new System.Drawing.Point(170, 621);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(297, 54);
            this.shoppingCartButton.TabIndex = 27;
            this.shoppingCartButton.Text = "ShoppingCart";
            this.shoppingCartButton.UseVisualStyleBackColor = false;
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartButton_Click);
            // 
            // returnStartButton
            // 
            this.returnStartButton.BackColor = System.Drawing.Color.Linen;
            this.returnStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnStartButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnStartButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.returnStartButton.Location = new System.Drawing.Point(170, 681);
            this.returnStartButton.Name = "returnStartButton";
            this.returnStartButton.Size = new System.Drawing.Size(297, 57);
            this.returnStartButton.TabIndex = 28;
            this.returnStartButton.Text = "Return to the start page";
            this.returnStartButton.UseVisualStyleBackColor = false;
            this.returnStartButton.Click += new System.EventHandler(this.returnStartButton_Click);
            // 
            // BuyerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 750);
            this.Controls.Add(this.returnStartButton);
            this.Controls.Add(this.shoppingCartButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBatton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyerPage";
            this.Text = "BuyerPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuyerPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuyerPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnBatton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button shoppingCartButton;
        private System.Windows.Forms.Button returnStartButton;
    }
}