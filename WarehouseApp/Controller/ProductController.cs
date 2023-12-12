using System.Collections.Generic;
using System.Windows.Forms;
using WarehouseApp.Model;
using WarehouseApp.Model.Object;
using WarehouseApp.Model.Repository;

namespace WarehouseApp.Controller
{
    public class ProductController
    {
        private ProductRepository repository;

        public ProductController(Connection connection) => this.repository = new ProductRepository(connection);

        private bool validationData(Product product)
        {
            if (string.IsNullOrEmpty(product.id) || string.IsNullOrEmpty(product.name)) return false;
            if (string.IsNullOrEmpty(product.stock) || string.IsNullOrEmpty(product.price)) return false;
            return true;
        }

        private bool parseData(Product product)
        {
            if (int.TryParse(product.stock, out int stock) && int.TryParse(product.price, out int price))
            {
                product.stock = stock.ToString();
                product.price = price.ToString();
                return true;
            }

            return false;
        }

        public int Add(Product product)
        {
            int result = 0;

            if (!validationData(product))
            {
                MessageBox.Show("Field Can\'t be Null or Empty!!!", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (!parseData(product))
            {
                MessageBox.Show("Input Fields isn\'t Valid !", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (Connection connect = new Connection())
            {
                this.repository = new ProductRepository(connect);
                result = this.repository.Add(product);
            }

            if (result == 1)
            {
                MessageBox.Show("Product Has Been Saved !", "Information",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Product Failed to Saved ! (Duplicated Data)", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            using (Connection connect = new Connection())
            {
                this.repository = new ProductRepository(connect);
                products = this.repository.GetAll();
            }

            return products;
        }

        public List<Product> GetByName(string name)
        {
            List<Product> products = new List<Product>();

            using (Connection connect = new Connection())
            {
                this.repository = new ProductRepository(connect);
                products = this.repository.GetByName(name);
            }

            return products;
        }

        public int Update(Product product)
        {
            int result = 0;

            if (!validationData(product))
            {
                MessageBox.Show("Field Can\'t be Null or Empty!!!", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (!parseData(product))
            {
                MessageBox.Show("Input Fields isn\'t Valid !", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (Connection connect = new Connection())
            {
                this.repository = new ProductRepository(connect);
                result = this.repository.Update(product);
            }

            if (result == 1)
            {
                MessageBox.Show("Product Has Been Updated !", "Information",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Product Failed to Updated !", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;

        }

        public int Delete(Product product)
        {
            int result = 0;

            using (Connection connect = new Connection())
            {
                this.repository = new ProductRepository(connect);
                result = this.repository.Delete(product);
            }

            if (result == 1)
            {
                MessageBox.Show("Product Has Been Deleted !", "Information",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Product Failed to Deleted !", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
    }
}
