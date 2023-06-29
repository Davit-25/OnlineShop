using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using OnlineShop.Interface;
using OnlineShop.Model;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly OnlineShopContext _context;
        private readonly IProductService _productService;

        public ProductController(OnlineShopContext context, IProductService productService )
        {
            _context = context;
            _productService = productService;
        }


        [HttpPost("createProduct")]
        public CreateProductResponse CreateProduct(CreateProductRequest request)=>_productService.CreateProduct(request);


        [HttpGet("getProduct")]
        public GetProductResponse GetProduct(GetProductRequest request)=>_productService.GetProduct(request);

        [HttpPut("updateProduct")]
        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)=>_productService.UpdateProduct(request);

        [HttpDelete("deleteProduct")]
        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)=>_productService.DeleteProduct(request);

        
    }
    
}
