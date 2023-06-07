namespace Coursework
{
    partial class ShoppingCartPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartPage));
            this.exitButton = new System.Windows.Forms.Button();
            this.returnBatton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.completeButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.shoppingCartListView = new System.Windows.Forms.ListView();
            this.shoppingCartGridView = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartGridView)).BeginInit();
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
            this.exitButton.TabIndex = 6;
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
            this.returnBatton.TabIndex = 14;
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
            this.label1.Location = new System.Drawing.Point(77, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = "The Victoria Boutique";
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.BackColor = System.Drawing.Color.Linen;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shoppingCartLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.shoppingCartLabel.Location = new System.Drawing.Point(203, 134);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(208, 40);
            this.shoppingCartLabel.TabIndex = 63;
            this.shoppingCartLabel.Text = "Shopping Cart:";
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.Color.Linen;
            this.completeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.completeButton.Location = new System.Drawing.Point(159, 668);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(327, 54);
            this.completeButton.TabIndex = 64;
            this.completeButton.Text = "Complete the purchase";
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.BackColor = System.Drawing.Color.Linen;
            this.clearCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCartButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearCartButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.clearCartButton.Location = new System.Drawing.Point(159, 599);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(327, 54);
            this.clearCartButton.TabIndex = 65;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = false;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // shoppingCartListView
            // 
            this.shoppingCartListView.BackColor = System.Drawing.Color.Linen;
            this.shoppingCartListView.Enabled = false;
            this.shoppingCartListView.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.shoppingCartListView.ForeColor = System.Drawing.Color.SaddleBrown;
            this.shoppingCartListView.HideSelection = false;
            this.shoppingCartListView.Location = new System.Drawing.Point(20, 177);
            this.shoppingCartListView.Name = "shoppingCartListView";
            this.shoppingCartListView.Size = new System.Drawing.Size(592, 58);
            this.shoppingCartListView.TabIndex = 66;
            this.shoppingCartListView.UseCompatibleStateImageBehavior = false;
            this.shoppingCartListView.View = System.Windows.Forms.View.List;
            // 
            // shoppingCartGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            this.shoppingCartGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.shoppingCartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shoppingCartGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.shoppingCartGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shoppingCartGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.shoppingCartGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shoppingCartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.shoppingCartGridView.ColumnHeadersHeight = 29;
            this.shoppingCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.size,
            this.quantity,
            this.totalCost,
            this.remove});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shoppingCartGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.shoppingCartGridView.Location = new System.Drawing.Point(20, 177);
            this.shoppingCartGridView.Name = "shoppingCartGridView";
            this.shoppingCartGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shoppingCartGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.shoppingCartGridView.RowHeadersVisible = false;
            this.shoppingCartGridView.RowHeadersWidth = 51;
            this.shoppingCartGridView.RowTemplate.Height = 24;
            this.shoppingCartGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shoppingCartGridView.Size = new System.Drawing.Size(592, 401);
            this.shoppingCartGridView.TabIndex = 150;
            this.shoppingCartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shoppingCartGridView_CellClick);
            // 
            // productName
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            this.productName.DefaultCellStyle = dataGridViewCellStyle3;
            this.productName.FillWeight = 197.8609F;
            this.productName.HeaderText = "Product name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // size
            // 
            this.size.FillWeight = 48.99422F;
            this.size.HeaderText = "Size";
            this.size.MaxInputLength = 5;
            this.size.MinimumWidth = 2;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 89.01262F;
            this.quantity.HeaderText = "Quantity ";
            this.quantity.MinimumWidth = 2;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // totalCost
            // 
            this.totalCost.FillWeight = 127.7913F;
            this.totalCost.HeaderText = "Total Cost";
            this.totalCost.MinimumWidth = 6;
            this.totalCost.Name = "totalCost";
            this.totalCost.ReadOnly = true;
            // 
            // remove
            // 
            this.remove.FillWeight = 36.34082F;
            this.remove.HeaderText = "";
            this.remove.MinimumWidth = 2;
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            // 
            // ShoppingCartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 750);
            this.Controls.Add(this.shoppingCartGridView);
            this.Controls.Add(this.shoppingCartListView);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBatton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoppingCartPage";
            this.Text = "ShoppingCartPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShoppingCartPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShoppingCartPage_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnBatton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.ListView shoppingCartListView;
        private System.Windows.Forms.DataGridView shoppingCartGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.DataGridViewImageColumn remove;
    }
}