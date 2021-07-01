using Models.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ORM
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _dbSet;

        public Repository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public virtual void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
