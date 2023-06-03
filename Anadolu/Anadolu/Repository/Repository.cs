using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly Context Context;
        public Repository(Context _Context)
        {
            Context = _Context;
        }

        public virtual void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            T element = Context.Set<T>(). Find(id);
            Context.Set<T>().Remove(element);
            Context.SaveChanges();
        }

        public virtual List<T> GetAll(Func<T, bool> predicate)
        {
            return Context.Set<T>().Where(predicate).ToList();
        }

        public virtual T GetById(int id, Func<T, bool> predicate)
        {
            return Context.Find<T>(id);
        }

        public virtual T GetByIdString(string id, Func<T, bool> predicate)
        {
            return Context.Find<T>(id);
        }


        public virtual void Update(int id, T newElement)
        {
            Context.Set<T>().Update(newElement);
            Context.SaveChanges();
        }
    }
}
