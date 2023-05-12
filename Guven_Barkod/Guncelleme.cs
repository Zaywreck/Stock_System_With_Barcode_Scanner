using Guven_Barkod_BackEnd.Entities;
using Guven_Barkod_BackEnd.Services;

namespace Guven_Barkod
{
    public partial class Guncelleme : Form
    {
        private string _selectedProductId;
        public Guncelleme(string? selectedProductId)
        {
            _selectedProductId = selectedProductId;
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Update Product
            var Repo = new ProductService();
            Product product = new Product()
            {
                Barcode_ID = Barcode_No_txt.Text,
                Product_Name = Product_Name_txt.Text,
                Product_Model = Product_model_txt.Text,
                Product_Color = Product_Color_txt.Text,
                Product_Size = Product_Size_txt.Text,
                Product_Quantity = int.Parse(Product_Quantity_txt.Text),
                Product_Price = int.Parse(Product_Price_txt.Text),
            };
            Repo.UpdateProduct(Barcode_No_txt.Text, product);
        }

        private void Envanter_Click(object sender, EventArgs e)
        {
            var envanter = new Envanter();
            envanter.Show();
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            var service = new ProductService();
            var product = service.GetProductById(_selectedProductId);
            Barcode_No_txt.Text = _selectedProductId;
            Product_Name_txt.Text = product.Product_Name;
            Product_model_txt.Text = product.Product_Model;
            Product_Color_txt.Text = product.Product_Color;
            Product_Size_txt.Text = product.Product_Size;
            Product_Quantity_txt.Text = product.Product_Quantity.ToString();
            Product_Price_txt.Text = product.Product_Price.ToString();


            this.MinimumSize = new Size(1200, 640);
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
