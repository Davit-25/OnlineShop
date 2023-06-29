using Microsoft.EntityFrameworkCore;
using OnlineShop.Entity;
using OnlineShop.Interface;
using OnlineShop.Mapper;
using OnlineShop.Model;

namespace OnlineShop.Service
{
    public class ProductService
    {
        private readonly OnlineShopContext _context;
        private readonly IProductMapper<Product, ProductModel> _productMapper;

        public ProductService(OnlineShopContext context)
        {
            _context = context;
            _productMapper = new ProductMapper();
        }

        public CreateProductResponse CreateProduct(ProductModel product)
        {
            var productAlEx=_context.Products.Any(e=>e.Id==product.Id);
            if (productAlEx)
            {
                throw new DbUpdateException($"this Id{product.Id} is already exist");
            }
            var productEntity = _productMapper.ProductMapFromModleToEntity(product);
            var newProduct=_context.Products.Add(productEntity);

            _context.SaveChanges();
            return new CreateProductResponse { createProduct = product };
        }
         public GetProductResponse GetProduct(GetProductRequest getProductRequest)
        {
            var newProduct = _context.Products.Find(getProductRequest.Id);
            return new GetProductResponse { getProduct=_productMapper.ProductMapFromEntityToModel(newProduct)};
        }

        public UpdateProductResponse UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            var existCategoryToUpdate = _context.Products.Find(updateProductRequest.productToUpdate.Id);
            if (existCategoryToUpdate==null)
            {
                throw new DbUpdateException($"this is no such ID{existCategoryToUpdate.Id}");
            }
            _productMapper.ProductMapFromModleToEntity(existCategoryToUpdate, updateProductRequest.productToUpdate);
            _context.SaveChanges();
            return new UpdateProductResponse { updatedProduct= updateProductRequest.productToUpdate };
        }
        public DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            var deleteProduct= _context.Products.Find(deleteProductRequest.Id);
            if(deleteProduct==null)
            {
                throw new DbUpdateException($"this id{deleteProduct.Id} doesn't exist");
            }
            _context.Products.Remove(deleteProduct);
            _context.SaveChanges();
            return new DeleteProductResponse { };
        }
    }
}
