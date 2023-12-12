using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WarehouseApp.Model.Object;

namespace WarehouseApp.Model.Repository
{
    public class ProductRepository
    {
        MySqlConnection _connection;

        public ProductRepository(Connection connection)
        {
            _connection = connection.Conn;
        }

        public int Add(Product product)
        {
            int result = 0;


            string sql = "INSERT INTO products (productId, productName, productStock, productPrice, createdAt, UpdatedAt) VALUES (@id, @name, @stock, @price, @created, @updated)";


            using (MySqlCommand cmd = new MySqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@id", product.id);
                cmd.Parameters.AddWithValue("@name", product.name);
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(product.stock));
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(product.price));
                cmd.Parameters.AddWithValue("@created", product.createdAt);
                cmd.Parameters.AddWithValue("@updated", product.updatedAt);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    System.Diagnostics.Debug.Print(err.StackTrace);
                    System.Diagnostics.Debug.Print(err.Message);
                }
            }

            return result;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            try
            {
                string sql = "SELECT productId, productName, productStock, productPrice, createdAt, updatedAt FROM products";

                using (MySqlCommand cmd = new MySqlCommand(sql, _connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.id = reader["productId"].ToString();
                            product.name = reader["productName"].ToString();
                            product.stock = reader["productStock"].ToString();
                            product.price = reader["productPrice"].ToString();
                            product.createdAt = reader["createdAt"].ToString();
                            product.updatedAt = reader["updatedAt"].ToString();
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return products;
        }

        public List<Product> GetByName(string name)
        {
            List<Product> products = new List<Product>();

            try
            {
                string sql = "SELECT productId, productName, productStock, productPrice, createdAt, updatedAt FROM products WHERE productName LIKE @name";

                using (MySqlCommand cmd = new MySqlCommand(sql, _connection))
                {

                    cmd.Parameters.AddWithValue("@name", $"%{name}%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.id = reader["productId"].ToString();
                            product.name = reader["productName"].ToString();
                            product.stock = reader["productPrice"].ToString();
                            product.price = reader["productPrice"].ToString();
                            product.createdAt = reader["createdAt"].ToString();
                            product.updatedAt = reader["updatedAt"].ToString();
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.Print(err.Message);
            }

            return products;
        }

        public int Update(Product product)
        {
            int result = 0;

            string sql = "UPDATE products SET productName = @name, productStock = @stock, productPrice = @price, updatedAt = @updated WHERE productId = @id";

            using (MySqlCommand cmd = new MySqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@id", product.id);
                cmd.Parameters.AddWithValue("@name", product.name);
                cmd.Parameters.AddWithValue("@stock", product.stock);
                cmd.Parameters.AddWithValue("@price", product.price);
                cmd.Parameters.AddWithValue("@updated", product.updatedAt);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    System.Diagnostics.Debug.Print(err.Message);
                }
            }

            return result;
        }

        public int Delete(Product product)
        {
            int result = 0;

            string sql = "DELETE FROM products WHERE productId = @id";

            using (MySqlCommand cmd = new MySqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@id", product.id);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    System.Diagnostics.Debug.Print(err.Message);
                }
            }

            return result;
        }
    }
}
