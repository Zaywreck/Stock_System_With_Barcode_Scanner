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


        private void Cart_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 640);
            Barcode_txt_box.Focus();
        }

        private void btn_productAdding_click(object sender, EventArgs e)
        {
            var ms_ekleme = new Ms_Ekleme();
            ms_ekleme.Show();
            this.Close();
        }

        private void Envanter_Sayfası_Click(object sender, EventArgs e)
        {
            var envanter = new Envanter();
            envanter.Show();
            this.Close();
        }

        private void eTextChange_Scanner(object sender, EventArgs e)
        {
            if (isHandlingEvent)
            {
                return;
            }
            isHandlingEvent = true;
            try
            {
                if (Barcode_txt_box.Text.Length >= 6)
                {
                    var product = productService.GetProductById(Barcode_txt_box.Text);
                    if (product != null)
                    {
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
                        RefreshDgw();
                        Barcode_txt_box.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Barkod");
                    }
                }
            }
            finally
            {
                isHandlingEvent = false;
            }


        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFile createFile = new CreateFile(cartItems: products);
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
                    string? selectedProductBarcodeId = Cart_dgw.SelectedRows[0].Cells["Barcode_Id"].Value.ToString();
                    var existingItem = products.FirstOrDefault(item => item.Product.Barcode_ID == selectedProductBarcodeId);
                    if (existingItem.Quantity > 1)
                    {
                        existingItem.Quantity -= 1;
                    }
                    else if (existingItem.Quantity == 1)
                    {
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
                Barcode_txt_box.Focus();
            }
        }

        private void RefreshDgw()
        {
            Cart_dgw.DataSource = null;
            Cart_dgw.DataSource = products;
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
