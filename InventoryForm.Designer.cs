using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThriftEase
{
    partial class InventoryForm
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
            this.SuspendLayout();

            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(110, 72);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(121, 23);
            txtItemName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(110, 102);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 1;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(35, 76);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(69, 15);
            lblItemName.TabIndex = 2;
            lblItemName.Text = "Item Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 110);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(35, 142);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // cmbQuantity
            // 
            cmbQuantity.FormattingEnabled = true;
            cmbQuantity.Location = new Point(110, 139);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(121, 23);
            cmbQuantity.TabIndex = 5;
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(334, 110);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(121, 23);
            cmbBrand.TabIndex = 7;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(259, 113);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(41, 15);
            lblBrand.TabIndex = 6;
            lblBrand.Text = "Brand:";
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(334, 76);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(121, 23);
            cmbSize.TabIndex = 9;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(259, 79);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(30, 15);
            lblSize.TabIndex = 8;
            lblSize.Text = "Size:";
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.Location = new Point(259, 144);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(34, 15);
            lblDateAdded.TabIndex = 10;
            lblDateAdded.Text = "Date:";
            // 
            // dtpDateAdded
            // 
            dtpDateAdded.Location = new Point(334, 139);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(200, 23);
            dtpDateAdded.TabIndex = 11;
            // 
            // picItemImage
            // 
            picItemImage.Location = new Point(540, 72);
            picItemImage.Name = "picItemImage";
            picItemImage.Size = new Size(129, 133);
            picItemImage.TabIndex = 12;
            picItemImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(536, 225);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(133, 23);
            btnUploadImage.TabIndex = 13;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(35, 272);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(471, 23);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(513, 271);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(594, 272);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(35, 301);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(634, 169);
            dgvInventory.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(431, 476);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(513, 476);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 19;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(594, 476);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(35, 178);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(63, 15);
            lblCondition.TabIndex = 21;
            lblCondition.Text = "Condition:";
            // 
            // cmbCondition
            // 
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(110, 175);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(121, 23);
            cmbCondition.TabIndex = 22;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 631);
            Controls.Add(cmbCondition);
            Controls.Add(lblCondition);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dgvInventory);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUploadImage);
            Controls.Add(picItemImage);
            Controls.Add(dtpDateAdded);
            Controls.Add(lblDateAdded);
            Controls.Add(cmbSize);
            Controls.Add(lblSize);
            Controls.Add(cmbBrand);
            Controls.Add(lblBrand);
            Controls.Add(cmbQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(label1);
            Controls.Add(lblItemName);
            Controls.Add(txtPrice);
            Controls.Add(txtItemName);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)picItemImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtItemName;
        private TextBox txtPrice;
        private Label lblItemName;
        private Label label1;
        private Label lblQuantity;
        private ComboBox cmbQuantity;
        private ComboBox cmbBrand;
        private Label lblBrand;
        private ComboBox cmbSize;
        private Label lblSize;
        private Label lblDateAdded;
        private DateTimePicker dtpDateAdded;
        private PictureBox picItemImage;
        private Button btnUploadImage;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnLoad;
        private DataGridView dgvInventory;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpdate;
        private Label lblCondition;
        private ComboBox cmbCondition;
    }
}