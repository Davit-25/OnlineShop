using OnlineShop.Entity;
using OnlineShop.Interface;
using OnlineShop.Model;

namespace OnlineShop.Mapper
{
    public class CategoryMapper:ICategoryMapper<Category,CategoryModel>
    {
        CategoryModel ICategoryMapper<Category, CategoryModel>.CategoryMapFromEntitytoModel(Category category) => new CategoryModel
        {
            Name = category.Name,
            Id = category.Id,
            Products = category.Products,
        };

        public Category CategoryMapFromModelToEntity(CategoryModel categoryModel)
        {
            var entity = new Category();
            CategoryMapFromModelToEntity(entity, categoryModel );
            return entity;
        }
        public void CategoryMapFromModelToEntity(Category category, CategoryModel categoryModel)
        {
            category.Name = categoryModel.Name;
            category.Id = categoryModel.Id;
            category.Products = categoryModel.Products;
        } 
      
    }
}
