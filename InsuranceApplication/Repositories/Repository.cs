using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace InsuranceApplication.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(int ID)
        {
            TEntity data = context.Set<TEntity>().Find(ID);
            context.Set<TEntity>().Remove(data);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}