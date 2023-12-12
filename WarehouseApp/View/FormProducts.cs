using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using WarehouseApp.Controller;
using WarehouseApp.Model;
using WarehouseApp.Model.Object;

namespace WarehouseApp.View
{
    public partial class FormProducts : Form
    {
        private ProductController controller;
        private List<Product> listProducts = new List<Product>();

        public FormProducts()
        {
            InitializeComponent();

            Connection connection = new Connection();
            this.controller = new ProductController(connection);

            InitListView();
            LoadDataProducts();
        }

        private void InitListView()
        {
            this.ListViewProducts.View = System.Windows.Forms.View.Details;
            this.ListViewProducts.FullRowSelect = true;
            this.ListViewProducts.GridLines = true;

            this.ListViewProducts.Columns.Add("No.", 30, HorizontalAlignment.Left);
            this.ListViewProducts.Columns.Add("Product ID", 100, HorizontalAlignment.Center);
            this.ListViewProducts.Columns.Add("Product Name", 200, HorizontalAlignment.Center);
            this.ListViewProducts.Columns.Add("Stock", 80, HorizontalAlignment.Center);
            this.ListViewProducts.Columns.Add("Price", 100, HorizontalAlignment.Center);
            this.ListViewProducts.Columns.Add("CreatedAt", 100, HorizontalAlignment.Center);
            this.ListViewProducts.Columns.Add("UpdatedAt", 100, HorizontalAlignment.Center);
        }

        private void LoadDataProducts()
        {
            string formatDate = "yyyy-MM-dd";
            this.ListViewProducts.Items.Clear();
            this.listProducts = this.controller.GetAll();

            foreach (Product product in this.listProducts)
            {
                int number = ListViewProducts.Items.Count + 1;
                ListViewItem items = new ListViewItem(number.ToString());
                items.SubItems.Add(product.id);
                items.SubItems.Add(product.name);
                items.SubItems.Add(product.stock.ToString());
                items.SubItems.Add(product.price.ToString());
                items.SubItems.Add(DateTime.Parse(product.createdAt).ToString(formatDate));
                items.SubItems.Add(DateTime.Parse(product.updatedAt).ToString(formatDate));
                this.ListViewProducts.Items.Add(items);
            }
        }

        private void OnCreateHandler(Product product)
        {
            string formatDate = "yyyy-MM-dd";

            this.listProducts.Add(product);

            int number = this.ListViewProducts.Items.Count + 1;
            ListViewItem items = new ListViewItem(number.ToString());
            items.SubItems.Add(product.id);
            items.SubItems.Add(product.name);
            items.SubItems.Add(product.stock.ToString());
            items.SubItems.Add(product.price.ToString());
            items.SubItems.Add(DateTime.Parse(product.createdAt).ToString(formatDate));
            items.SubItems.Add(DateTime.Parse(product.updatedAt).ToString(formatDate));
            this.ListViewProducts.Items.Add(items);
        }

        private void OnUpdateHandler(Product product)
        {
            int index = this.ListViewProducts.SelectedIndices[0];

            ListViewItem rows = this.ListViewProducts.Items[index];

            rows.SubItems[1].Text = product.id;
            rows.SubItems[2].Text = product.name;
            rows.SubItems[3].Text = product.stock.ToString();
            rows.SubItems[4].Text = product.price.ToString();
            rows.SubItems[6].Text = product.updatedAt;
        }

        private void ButtonAdd_Click(object sender, System.EventArgs e)
        {
            FormHandlerProduct FormProduct = new FormHandlerProduct(controller);
            FormProduct.OnCreate += OnCreateHandler;
            FormProduct.ShowDialog();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (ListViewProducts.SelectedItems.Count > 0)
            {
                Product product = this.listProducts[ListViewProducts.SelectedIndices[0]];

                FormHandlerProduct FormProduct = new FormHandlerProduct(product, controller);
                FormProduct.OnUpdate += OnUpdateHandler;
                FormProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Items First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int result = 0;

            if (ListViewProducts.SelectedItems.Count > 0)
            {
                Product product = this.listProducts[ListViewProducts.SelectedIndices[0]];

                DialogResult confirmation = MessageBox.Show($"Are You Sure Want to Delete Product With ID : {product.id}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmation == DialogResult.Yes)
                {
                    result = this.controller.Delete(product);
                    if (result > 0) LoadDataProducts();
                }
            }
            else
            {
                MessageBox.Show("Please Select Items First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string keyword = InputSearch.Text;

            if (keyword != "")
            {
                string formatDate = "yyyy-MM-dd";
                this.ListViewProducts.Items.Clear();
                this.listProducts = this.controller.GetByName(keyword);

                foreach (Product product in this.listProducts)
                {
                    int number = ListViewProducts.Items.Count + 1;
                    ListViewItem items = new ListViewItem(number.ToString());
                    items.SubItems.Add(product.id);
                    items.SubItems.Add(product.name);
                    items.SubItems.Add(product.stock.ToString());
                    items.SubItems.Add(product.price.ToString());
                    items.SubItems.Add(DateTime.Parse(product.createdAt).ToString(formatDate));
                    items.SubItems.Add(DateTime.Parse(product.updatedAt).ToString(formatDate));
                    this.ListViewProducts.Items.Add(items);
                }
            }
            else
            {
                this.LoadDataProducts();
            }
        }

        private void ButtonSignOut_Click(object sender, System.EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(SetOpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void SetOpenForm() => Application.Run(new FormLogin());

        private void ButtonLogout_Click(object sender, System.EventArgs e) => this.Close();
    }
}
