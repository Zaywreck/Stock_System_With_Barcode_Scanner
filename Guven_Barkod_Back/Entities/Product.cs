namespace Guven_Barkod_BackEnd.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Barcode_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Model { get; set; }
        public string Product_Color { get; set; }
        public string Product_Size { get; set; }
        public int Product_Price { get; set; }
        public int Product_Quantity { get; set; }

        public Product()
        {
            
        }

        public Product(string barcode_ID, string product_Name, string product_Model, string product_Color, string product_Size, int product_Price)
        {
            Barcode_ID = barcode_ID;
            Product_Name = product_Name ?? throw new ArgumentNullException(nameof(product_Name));
            Product_Model = product_Model ?? throw new ArgumentNullException(nameof(product_Model));
            Product_Color = product_Color ?? throw new ArgumentNullException(nameof(product_Color));
            Product_Size = product_Size ?? throw new ArgumentNullException(nameof(product_Size));
            Product_Price = product_Price;
        }

        public override string? ToString()
        {
            return Product_Name;
        }
    }
}
