using OnlineShop.Model;

namespace OnlineShop.Interface
{
    public interface ICategoryService
    {
        CreateCategoryResponse CreateCategory(CreateCategoryRequest request);
        GetCategoryResponse GetCategory(GetCategoryRequest request);
        UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request);
        DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest request);
    }
}
