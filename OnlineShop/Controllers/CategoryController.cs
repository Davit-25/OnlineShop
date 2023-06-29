using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interface;
using OnlineShop.Model;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly OnlineShopContext _context;
        private readonly ICategoryService _categoryService;

        public CategoryController( OnlineShopContext context, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _context = context;
        }

        [HttpPost("createCategory")]
        public CreateCategoryResponse CreateCategory(CreateCategoryRequest request)=>_categoryService.CreateCategory(request);

        [HttpGet("getCategory")]
        public GetCategoryResponse GetCategory(GetCategoryRequest request)=>_categoryService.GetCategory(request);

        [HttpPut("updateCategory")]
        public UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request)=>_categoryService.UpdateCategory(request);

        [HttpDelete("deleteCategory")]
        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest request)=>_categoryService.DeleteCategory(request);
    }
}
