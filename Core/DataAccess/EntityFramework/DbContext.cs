using Core.Entities;

namespace Core.DataAccess.EntityFramework
{
    public class DbContext
    {
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