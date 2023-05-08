using Guven_Barkod_BackEnd.Services;
using System.IO.Ports;
namespace Guven_Barkod
{
    public partial class Envanter : Form
    {
        public Envanter()
        {
            InitializeComponent();
        }
        private void updateData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new ProductService().GetAllProducts();
            dataGridView1.Refresh();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 640);
            dataGridView1.DataSource = new ProductService().GetAllProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ms_Ekleme = new Ms_Ekleme();
            ms_Ekleme.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sepet = new Sepet();
            sepet.Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the value of selected product's barcode id
            string? selectedProductId = dataGridView1.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
            // Calling the service and finding the product with designed methods
            var productService = new ProductService();
            var tproduct = productService.GetProductById(selectedProductId);
            // Null check and delete
            if (tproduct != null)
            {
                productService.DeleteProduct(tproduct);
                updateData();
            }
            else
            {
                MessageBox.Show("Error deleting product!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string? selectedProductId = dataGridView1.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
            var productService = new ProductService();
            var selectedProduct = productService.GetProductById(selectedProductId);
            if (selectedProduct != null)
            {
                selectedProduct.Product_Quantity += 1;
                productService.UpdateProduct(selectedProductId, selectedProduct);
                updateData();
            }
            else
            {
                MessageBox.Show("Error Updating Quantity!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string? selectedProductId = dataGridView1.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
            var productService = new ProductService();
            var selectedProduct = productService.GetProductById(selectedProductId);
            if (selectedProduct != null)
            {
                selectedProduct.Product_Quantity -= 1;
                productService.UpdateProduct(selectedProductId, selectedProduct);
                updateData();
            }
            else
            {
                MessageBox.Show("Error Updating Quantity!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string? selectedProductId = dataGridView1.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
            var form4 = new Guncelleme(selectedProductId);
            form4.Show();
            this.Close();
        }
    }
}