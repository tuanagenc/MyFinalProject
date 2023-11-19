using Core.Entities;

namespace Core.DataAccess.EntityFramework
{
    public class DbContext
    {
        internal object Entry<TEntity>(TEntity entity) where TEntity : class, IEntity, new()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<IEntity> Set<T>()
        {
            throw new NotImplementedException();
        }
    }
}