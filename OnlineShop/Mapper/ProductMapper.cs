using Microsoft.EntityFrameworkCore.Query.Internal;
using OnlineShop.Entity;
using OnlineShop.Interface;
using OnlineShop.Model;

namespace OnlineShop.Mapper
{
    public class ProductMapper:IProductMapper<Product, ProductModel>
    {
        ProductModel IProductMapper<Product, ProductModel>.ProductMapFromEntityToModel(Product product) => new ProductModel
        {
            Id = product.Id,
            Name = product.Name,
            Categories = product.Categories,
        };
        public Product ProductMapFromModleToEntity(ProductModel productModel)
        {
            var entity = new Product();
            ProductMapFromModleToEntity(entity, productModel);
            return entity;
        }
        public void ProductMapFromModleToEntity( Product product, ProductModel productModel)
        {
          product.Categories = productModel.Categories;
            product.Id = productModel.Id;
            product.Name = productModel.Name;
            product.Price = productModel.Price;
            product.Description = productModel.Description;

        }

    }
}
