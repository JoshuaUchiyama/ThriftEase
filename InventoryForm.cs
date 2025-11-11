using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThriftEase
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();

            // Setup DataGridView columns to match DisplayItems ordering (no Id column here)
            dgvInventory.Columns.Clear();
            dgvInventory.Columns.Add("ItemName", "Item Name");
            dgvInventory.Columns.Add("Price", "Price");
            dgvInventory.Columns.Add("Quantity", "Quantity");
            dgvInventory.Columns.Add("DateAdded", "Date Added");
            dgvInventory.Columns.Add("Brand", "Brand");
            dgvInventory.Columns.Add("Condition", "Condition");
            dgvInventory.Columns.Add("Size", "Size");
            dgvInventory.Columns.Add("ImagePath", "Image Path");
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picItemImage.ImageLocation = ofd.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InventoryItem item = new InventoryItem
            {
                Name = txtItemName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Quantity = cmbQuantity.Text,
                DateAdded = dtpDateAdded.Value,
                Brand = cmbBrand.Text,
                Condition = cmbCondition.Text,
                Size = cmbSize.Text,
                ImagePath = picItemImage.ImageLocation
            };

            DatabaseHelper.AddInventoryItem(item);
            MessageBox.Show("Item added successfully!");
        }

        private void DisplayItems(List<InventoryItem> items)
        {
            dgvInventory.Rows.Clear();
            foreach (var item in items)
            {
                dgvInventory.Rows.Add(
                    item.Name,
                    item.Price,
                    item.Quantity,
                    item.DateAdded.ToShortDateString(),
                    item.Brand,
                    item.Condition,
                    item.Size,
                    item.ImagePath);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var items = DatabaseHelper.GetAllItems();
            DisplayItems(items);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var items = DatabaseHelper.SearchItems(keyword);
            DisplayItems(items);
        }
    }
}
