using Guven_Barkod_BackEnd.Services;
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
            Inventory_dgw.DataSource = null;
            Inventory_dgw.DataSource = new ProductService().GetAllProducts();
            Inventory_dgw.Refresh();

        }

        private void Envanter_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 640);
            Inventory_dgw.DataSource = new ProductService().GetAllProducts();
        }

        private void Urun_Ekleme_Click(object sender, EventArgs e)
        {
            var ms_Ekleme = new Ms_Ekleme();
            ms_Ekleme.Show();
            this.Close();
        }

        private void Sepet_Click(object sender, EventArgs e)
        {
            var sepet = new Sepet();
            sepet.Show(); this.Close();
        }

        private void Product_Remove_Click(object sender, EventArgs e)
        {
            // Get the value of selected product's barcode id
            string? selectedProductId = Inventory_dgw.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
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

        private void Product_Quantity_Increase_Click(object sender, EventArgs e)
        {
            string? selectedProductId = Inventory_dgw.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
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

        private void Product_Quantity_Decrease_Click(object sender, EventArgs e)
        {
            string? selectedProductId = Inventory_dgw.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
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

        private void Product_Update_Click(object sender, EventArgs e)
        {
            string? selectedProductId = Inventory_dgw.SelectedRows[0].Cells["Barcode_ID"].Value.ToString();
            var guncelleme = new Guncelleme(selectedProductId);
            guncelleme.Show();
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misiniz?", "Evet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}