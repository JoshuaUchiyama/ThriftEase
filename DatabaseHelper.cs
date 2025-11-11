using System.Data.SQLite;               

namespace ThriftEase
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=thriftease.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Inventory (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ItemName TEXT,
                        Price REAL,
                        Quantity TEXT,
                        DateAdded TEXT,
                        Brand TEXT,
                        Condition TEXT,
                        Size TEXT,
                        ImagePath TEXT
                    );";
                using var command = new SQLiteCommand(createTableQuery, connection);
                command.ExecuteNonQuery();
            }
        }

        public static void AddInventoryItem(InventoryItem item)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"
                    INSERT INTO Inventory (ItemName, Price, Quantity, DateAdded, Brand, Condition, Size, ImagePath)
                    VALUES (@ItemName, @Price, @Quantity, @DateAdded, @Brand, @Condition, @Size, @ImagePath);";

                using var command = new SQLiteCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@ItemName", item.Name ?? string.Empty);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Quantity", item.Quantity ?? string.Empty);
                command.Parameters.AddWithValue("@DateAdded", item.DateAdded.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Brand", item.Brand ?? string.Empty);
                command.Parameters.AddWithValue("@Condition", item.Condition ?? string.Empty);
                command.Parameters.AddWithValue("@Size", item.Size ?? string.Empty);
                command.Parameters.AddWithValue("@ImagePath", item.ImagePath ?? string.Empty);
                command.ExecuteNonQuery();
            }
        }

        public static List<InventoryItem> GetAllItems()
        {
            var items = new List<InventoryItem>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Inventory";
                using var command = new SQLiteCommand(query, connection);
                using SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new InventoryItem
                    {
                        Name = reader["ItemName"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Quantity = reader["Quantity"].ToString(),
                        DateAdded = DateTime.Parse(reader["DateAdded"].ToString()),
                        Brand = reader["Brand"].ToString(),
                        Condition = reader["Condition"].ToString(),
                        Size = reader["Size"].ToString(),
                        ImagePath = reader["ImagePath"].ToString()
                    });
                }
            }
            return items;
        }

        public static List<InventoryItem> SearchItems(string keyword)
        {
            var items = new List<InventoryItem>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Inventory WHERE ItemName LIKE @Keyword";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new InventoryItem
                    {
                        Name = reader["ItemName"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Quantity = reader["Quantity"].ToString(),
                        DateAdded = DateTime.Parse(reader["DateAdded"].ToString()),
                        Brand = reader["Brand"].ToString(),
                        Condition = reader["Condition"].ToString(),
                        Size = reader["Size"].ToString(),
                        ImagePath = reader["ImagePath"].ToString()
                    });
                }
            }
            return items;
        }

        public static void UpdateInventoryItem(InventoryItem item)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = @"
                    UPDATE Inventory
                    SET ItemName = @ItemName,
                        Price = @Price,
                        Quantity = @Quantity,
                        DateAdded = @DateAdded,
                        Brand = @Brand,
                        Condition = @Condition,
                        Size = @Size,
                        ImagePath = @ImagePath
                    WHERE Id = @Id;";

                SQLiteCommand command = new SQLiteCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@ItemName", item.Name);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Quantity", item.Quantity);
                command.Parameters.AddWithValue("@DateAdded", item.DateAdded.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Brand", item.Brand);
                command.Parameters.AddWithValue("@Condition", item.Condition);
                command.Parameters.AddWithValue("@Size", item.Size);
                command.Parameters.AddWithValue("@ImagePath", item.ImagePath);
                command.Parameters.AddWithValue("@Id", item.Id);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteInventoryItem(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Inventory WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}

    