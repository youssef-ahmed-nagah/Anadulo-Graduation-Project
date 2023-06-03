namespace Anadolu.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(Func<T, bool> predicate);

        T GetById(int id, Func<T, bool> predicate);

        T GetByIdString(string id, Func<T, bool> predicate);

        void Delete(int id);

        void Update(int id, T repNmae);

        void Add(T entity);


    }
}
