using Guven_Barkod_BackEnd.Entities;

namespace Guven_Barkod_BackEnd.Services
{
    public interface IProductService
    {
        public void CreateProduct(Product product);
        public Product UpdateProduct(int id,Product product);
        public Product GetProductById(int id);
        public List<Product> GetAllProducts();
        public void DeleteProduct(Product product);
    }
}
