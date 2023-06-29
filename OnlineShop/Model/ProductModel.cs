using OnlineShop.Entity;

namespace OnlineShop.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<ProductCategory> Categories { get; set; }
    
    }
}
