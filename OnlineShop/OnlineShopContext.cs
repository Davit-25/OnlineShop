using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Conficuration;
using OnlineShop.Entity;
using System.Security.Cryptography.X509Certificates;

namespace OnlineShop
{
    public class OnlineShopContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public OnlineShopContext()
        {

        }

        public OnlineShopContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new ProductCategoryConfig());
    }
    }
}
