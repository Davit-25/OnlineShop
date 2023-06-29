using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entity;

namespace OnlineShop.Conficuration
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasOne(e => e.Product).WithMany(e => e.Categories).HasForeignKey(e => e.ProductId);
        }
    }
}
