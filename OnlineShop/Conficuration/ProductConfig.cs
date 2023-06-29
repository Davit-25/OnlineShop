using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entity;

namespace OnlineShop.Conficuration
{
    public class ProductConfig:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(e => e.Categories);
        }
    }
}
