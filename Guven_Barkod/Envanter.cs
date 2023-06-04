using Guven_Barkod_BackEnd.Services;
using Helpers;

namespace Guven_Barkod
{
    public partial class Envanter : Form
    {
        private ProductService productService;
        private bool passwordHandle = false;
        private Helper helper;
        public Envanter()
        {
            helper = new Helper();
            productService = new ProductService();
            InitializeComponent();
        }
        private void updateData()
        {
            Inventory_dgw.DataSource = null;
            Inventory_dgw.DataSource = productService.GetAllProducts();
            Inventory_dgw.Refresh();

        }

        private void Envanter_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 640);
            CalcTheTotalSellPurchProfit();
            sumOfSell_txt.PasswordChar = '*';
            sumOfPurchase_txt.PasswordChar = '*';
            Aprox_Profit_txt.PasswordChar = '*';
            Inventory_dgw.DataSource = productService.GetAllProducts();
        }

        private void CalcTheTotalSellPurchProfit()
        {
            var sumOfPurch = productService.GetAllProducts().Sum(product => product.Product_Purch_Price * product.Product_Quantity);
            var sumOfSell = productService.GetAllProducts().Sum(product => product.Product_Price * product.Product_Quantity);
            sumOfPurchase_txt.Text = sumOfPurch.ToString();
            sumOfSell_txt.Text = sumOfSell.ToString();
            Aprox_Profit_txt.Text = (sumOfSell - sumOfPurch).ToString();
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

        private void btn_Show_Values_Click(object sender, EventArgs e)
        {
            if (!passwordHandle)
            {
                sumOfPurchase_txt.PasswordChar = '\0';
                sumOfSell_txt.PasswordChar = '\0';
                Aprox_Profit_txt.PasswordChar = '\0';
                passwordHandle = true;
            }
            else
            {
                sumOfSell_txt.PasswordChar = '*';
                sumOfPurchase_txt.PasswordChar = '*';
                Aprox_Profit_txt.PasswordChar = '*';
                passwordHandle = false;
            }
        }

        private void Inventory_Update_wExcel_btn_Click(object sender, EventArgs e)
        {
            helper.ReadFromExcel();
            updateData();
        }
    }
}