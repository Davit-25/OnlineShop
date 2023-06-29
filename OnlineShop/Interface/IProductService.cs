using OnlineShop.Model;

namespace OnlineShop.Interface
{
    public interface IProductService
    {
        CreateProductResponse CreateProduct(CreateProductRequest request);
        GetProductResponse GetProduct(GetProductRequest request);
        UpdateProductResponse UpdateProduct(UpdateProductRequest request);
        DeleteProductResponse DeleteProduct(DeleteProductRequest request);    
    }
}
