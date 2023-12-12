using System;
using System.Drawing;
using System.Windows.Forms;
using WarehouseApp.Controller;
using WarehouseApp.Model.Object;

namespace WarehouseApp.View
{
    public partial class FormHandlerProduct : Form
    {
        public delegate void EventHandlerCreateUpdate(Product product);

        public event EventHandlerCreateUpdate OnCreate;

        public event EventHandlerCreateUpdate OnUpdate;

        private ProductController controller;

        private Product product;

        private bool newData = true;

        public FormHandlerProduct()
        {
            InitializeComponent();
        }

        public FormHandlerProduct(ProductController _controller) : this()
        {
            this.Text = "Add Product";
            this.ButtonHandler.Text = "Add";
            this.controller = _controller;
        }

        public FormHandlerProduct(Product _product, ProductController _controller) : this()
        {
            this.Text = "Update Product";
            this.ButtonHandler.Text = "Update";
            this.controller = _controller;
            this.product = _product;
            this.newData = false;

            this.TextProductID.ReadOnly = true;
            this.TextProductID.BackColor = Color.FromArgb(192, 192, 192);

            this.TextProductID.Text = this.product.id;
            this.TextProductName.Text = this.product.name;
            this.TextProductStock.Text = this.product.stock.ToString();
            this.TextProductPrice.Text = this.product.price.ToString();
        }

        private void ButtonHandler_Click(object sender, System.EventArgs e)
        {
            int result = 0;

            this.product = new Product();
            this.product.id = this.TextProductID.Text.ToUpper();
            this.product.name = this.TextProductName.Text;
            this.product.stock = this.TextProductStock.Text;
            this.product.price = this.TextProductPrice.Text;

            if (this.newData)
            {
                DateTime dateNow = DateTime.Now;

                this.product.createdAt = dateNow.ToString("yyyy-MM-dd");
                this.product.updatedAt = this.product.createdAt;

                result = this.controller.Add(this.product);

                if (result > 0)
                {
                    this.OnCreate(this.product);

                    this.TextProductID.Clear();
                    this.TextProductName.Clear();
                    this.TextProductStock.Clear();
                    this.TextProductPrice.Clear();
                }
            }
            else
            {
                DateTime dateNow = DateTime.Now;
                this.product.updatedAt = dateNow.ToString("yyyy-MM-dd");

                result = this.controller.Update(this.product);

                if (result > 0)
                {
                    this.OnUpdate(this.product);
                    this.Close();
                }
            }

        }

        private void ButtonClose_Click(object sender, EventArgs e) => this.Close();
    }
}
