using Guven_Barkod_BackEnd.Entities;
using Guven_Barkod_BackEnd.Services;
using Helpers;
using System.Windows.Forms;

namespace Guven_Barkod
{
    public partial class Sepet : Form
    {
        ProductService productService;
        private List<CartItem> products;
        private bool isHandlingEvent = false;
        public Sepet()
        {
            products = new List<CartItem>();
            productService = new ProductService();
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 640);
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new Ms_Ekleme();
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form3 = new Envanter();
            form3.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (isHandlingEvent)
            {
                return;
            }
            isHandlingEvent = true;
            try
            {
                if (textBox2.Text.Length >= 6)
                {
                    var product = productService.GetProductById(textBox2.Text);
                    var existingItem = products.FirstOrDefault(item => item.Product.Id == product.Id);
                    if (existingItem != null)
                    {
                        existingItem.Quantity++;
                    }
                    else
                    {
                        var cartItem = new CartItem
                        {
                            Product = product,
                            Quantity = 1,
                            Barcode_Id = product.Barcode_ID,

                        };
                        products.Add(cartItem);
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = products;
                    textBox2.Text = string.Empty;
                }
            }
            finally
            {
                isHandlingEvent = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFile createFile = new CreateFile(cartItems:products);
                createFile.createLog();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı!");
            }
            finally 
            {

                products.Clear();
                RefreshDgw();
            
            }
        }

        private void btn_Remove_Product_Click(object sender, EventArgs e)
        {

            try
            {
                if (products.Count > 0)
                {
                    string? selectedProductBarcodeId = dataGridView1.SelectedRows[0].Cells["Barcode_Id"].Value.ToString();
                    var existingItem = products.FirstOrDefault(item => item.Product.Barcode_ID == selectedProductBarcodeId);
                    if (existingItem.Quantity>1)
                    {
                        existingItem.Quantity -= 1;
                    }
                    else if (existingItem.Quantity ==1) {
                        products.Remove(existingItem);
                        MessageBox.Show($"{existingItem.Barcode_Id} ürün çıkarıldı.");
                        
                    }
                    else
                    {
                        MessageBox.Show("Bir hatayla karşılaşıldı");
                    }

                  
                }
                else
                {
                    MessageBox.Show("Şu an herhangi bir silinecek ürün bulunmamakta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler ters gitti!");
            }
            finally
            {
                RefreshDgw();
                textBox2.Focus();
            }





        }

        private void RefreshDgw()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }
    }
}
