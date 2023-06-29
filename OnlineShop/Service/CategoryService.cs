using Microsoft.EntityFrameworkCore;
using OnlineShop.Entity;
using OnlineShop.Interface;
using OnlineShop.Mapper;
using OnlineShop.Model;

namespace OnlineShop.Service
{
    public class CategoryService
    {
        private readonly OnlineShopContext _context;
        private readonly ICategoryMapper<Category, CategoryModel> _categoryMapper;

        public CategoryService(OnlineShopContext context)
        {
            _context = context;
            _categoryMapper = new CategoryMapper();
        }

        public CreateCategoryResponse CreateCategory(CategoryModel category)
        {
            var categoryAlrEx = _context.Categories.Any(p => p.Id == category.Id);
            if (categoryAlrEx)
            {
                throw new DbUpdateException($"this ID{category.Id} is already exist");
            }

            var categoryEntity= _categoryMapper.CategoryMapFromModelToEntity(category);
            var newCategory= _context.Categories.Add(categoryEntity);

            _context.SaveChanges();
            return new CreateCategoryResponse { createCategory = category };
        }
        public GetCategoryResponse GetCategory(GetCategoryRequest getCategoryRequest)
        {
            var category = _context.Categories.Find(getCategoryRequest.Id);
            return new GetCategoryResponse { getCategory = _categoryMapper.CategoryMapFromEntitytoModel(category) };
        }

        public UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            var exCategoryToUpdate = _context.Categories.Find(updateCategoryRequest.categoryToUpdate.Id);
            if (exCategoryToUpdate == null)
            {
                throw new DbUpdateException($"this is no such ID{exCategoryToUpdate.Id} ");
            }
            _categoryMapper.CategoryMapFromModelToEntity(exCategoryToUpdate,updateCategoryRequest.categoryToUpdate);
            _context.SaveChanges();
            return new UpdateCategoryResponse { updatedCategory = updateCategoryRequest.categoryToUpdate };

        }
        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deleteCategoryRequest)
        {
            var deleteCategory = _context.Categories.Find(deleteCategoryRequest.Id);
            if (deleteCategory == null)
            {
                throw new DbUpdateException($"this Id{deleteCategory.Id} doesn't  exist");
            }
            _context.Categories.Remove(deleteCategory);
            _context.SaveChanges();
            return new DeleteCategoryResponse { IsDeletedCategory = true };
        }
    }
}
