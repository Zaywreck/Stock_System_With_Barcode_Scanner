using Guven_Barkod_BackEnd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Guven_Barkod_BackEnd.DAL.mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Barcode_ID);
            builder.Property(p => p.Product_Name).IsRequired();
            builder.Property(p => p.Product_Model).IsRequired();
            builder.Property(p => p.Product_Color).IsRequired();
            builder.Property(p => p.Product_Size).IsRequired();
            builder.Property(p => p.Product_Price).IsRequired();
        }
    }
}
