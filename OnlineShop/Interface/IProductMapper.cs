using OnlineShop.Entity;
using OnlineShop.Model;

namespace OnlineShop.Interface
{
    public interface IProductMapper<TEntity, TModel>
    {
        TModel ProductMapFromEntityToModel(TEntity entity);
        TEntity ProductMapFromModleToEntity(TModel model);
        void ProductMapFromModleToEntity(TEntity entity, TModel model);
    }
}
