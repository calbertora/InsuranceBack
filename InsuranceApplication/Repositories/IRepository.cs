using System.Collections.Generic;

namespace InsuranceApplication.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }
}
