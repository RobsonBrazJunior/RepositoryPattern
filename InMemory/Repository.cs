using Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace InMemory
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected List<T> _lista = new();

        public virtual void Add(T entity)
        {
            _lista.Add(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _lista.AsEnumerable();
        }

        public virtual void Remove(T entity)
        {
            _lista.Remove(entity);
        }
    }
}
