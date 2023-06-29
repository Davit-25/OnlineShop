
namespace OnlineShop.Interface
{
    public interface ICategoryMapper<TEntity, TModel>
    {
        TModel CategoryMapFromEntitytoModel(TEntity entity);
        TEntity CategoryMapFromModelToEntity(TModel model);
        void CategoryMapFromModelToEntity(TEntity entity, TModel model);
    }
}
