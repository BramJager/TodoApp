using System.Collections.Generic;

namespace TodoApp.Business.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> Get();
        void Delete(T entity);
        void Create(T entity);
        T Update(T entity);
        void Save();
    }
}
