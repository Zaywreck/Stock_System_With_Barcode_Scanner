using Guven_Barkod_BackEnd.Entities;
using Guven_Barkod_BackEnd.Services;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Guven_Barkod
{
    public partial class Ms_Ekleme : Form
    {
        public Ms_Ekleme()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var envanter = new Envanter();
            envanter.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Barcode_No_txt.Text) ||
            string.IsNullOrEmpty(Product_Name_txt.Text) ||
            string.IsNullOrEmpty(Product_model_txt.Text) ||
            string.IsNullOrEmpty(Product_Color_txt.Text) ||
            string.IsNullOrEmpty(Product_Size_txt.Text) ||
            string.IsNullOrEmpty(Product_Quantity_txt.Text) ||
            string.IsNullOrEmpty(Product_Price_txt.Text))
            {
                MessageBox.Show("Lütfen Boþ parametre býrakmayýnýz!");
            }
            else
            {
                // Add Product
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
                Repo.CreateProduct(product);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sepet = new Sepet();
            sepet.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 640);
        }
    }
}