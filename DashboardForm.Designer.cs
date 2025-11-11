namespace ThriftEase
{
    partial class DashboardForm
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
            btnInventory = new Button();
            btnSales = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            lblTotalItems = new Label();
            lblItemsSold = new Label();
            lblItemsAvailable = new Label();
            SuspendLayout();
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(404, 115);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(75, 23);
            btnInventory.TabIndex = 0;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(485, 115);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(75, 23);
            btnSales.TabIndex = 1;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(566, 115);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 23);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(496, 335);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Location = new Point(404, 192);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(68, 15);
            lblTotalItems.TabIndex = 4;
            lblTotalItems.Text = "Total Items:";
            // 
            // lblItemsSold
            // 
            lblItemsSold.AutoSize = true;
            lblItemsSold.Location = new Point(404, 221);
            lblItemsSold.Name = "lblItemsSold";
            lblItemsSold.Size = new Size(65, 15);
            lblItemsSold.TabIndex = 5;
            lblItemsSold.Text = "Items Sold:";
            // 
            // lblItemsAvailable
            // 
            lblItemsAvailable.AutoSize = true;
            lblItemsAvailable.Location = new Point(404, 252);
            lblItemsAvailable.Name = "lblItemsAvailable";
            lblItemsAvailable.Size = new Size(90, 15);
            lblItemsAvailable.TabIndex = 6;
            lblItemsAvailable.Text = "Items Available:";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblItemsAvailable);
            Controls.Add(lblItemsSold);
            Controls.Add(lblTotalItems);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnSales);
            Controls.Add(btnInventory);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInventory;
        private Button btnSales;
        private Button btnReports;
        private Button btnLogout;
        private Label lblTotalItems;
        private Label lblItemsSold;
        private Label lblItemsAvailable;
    }
}