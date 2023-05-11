using Guven_Barkod_BackEnd.DAL.mapping;
using Guven_Barkod_BackEnd.Entities;
using Microsoft.EntityFrameworkCore;

namespace Guven_Barkod_BackEnd.Repositories
{
    public class ProductRepo : DbContext
    {

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BarkodV2;Integrated Security=True;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}
