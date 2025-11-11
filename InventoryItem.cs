using System;

namespace ThriftEase
{
    public class InventoryItem
    {
        public int Id { get; set; } // Added: required for Update/Delete operations
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public string Brand { get; set; }
        public string Condition { get; set; }
        public string Size { get; set; }
        public string ImagePath { get; set; }
    }
}
