using OnlineShop.Entity;

namespace OnlineShop.Model
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> Products { get; set; }
    }
}
