using System.Collections.Generic;

namespace Persistence
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Remove(TEntity entity);
        void SaveChanges();
    }

  
}
