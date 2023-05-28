using Guven_Barkod_BackEnd.Entities;
using Guven_Barkod_BackEnd.Repositories;


namespace Guven_Barkod_BackEnd.Services
{
    public class ProductService
    {
        private readonly ProductRepo _context;
        public ProductService()
        {
            _context = new ProductRepo();
        }
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(string id)
        {
            return _context.Products.FirstOrDefault(p => p.Barcode_ID == id);
        }

        public Product UpdateProduct(string id, Product product)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.Barcode_ID == id);
            if (existingProduct != null)
            {
                existingProduct.Product_Name = product.Product_Name;
                existingProduct.Product_Model = product.Product_Model;
                existingProduct.Product_Color = product.Product_Color;
                existingProduct.Product_Size = product.Product_Size;
                existingProduct.Product_Price = product.Product_Price;
                existingProduct.Product_Quantity = product.Product_Quantity;
                existingProduct.Product_Purch_Price = product.Product_Purch_Price;
                _context.SaveChanges();
            }
            return existingProduct;
        }
    }
}
