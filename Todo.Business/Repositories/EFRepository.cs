using System.Collections.Generic;
using System.Linq;
using TodoApp.Business.Interfaces;

namespace TodoApp.Business.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly DataContext dataContext;

        public EFRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void Create(T entity)
        {
            dataContext.Add(entity);
        }

        public void Delete(T entity)
        {
            dataContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Get()
        {
            return dataContext.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return dataContext.Set<T>().Find(id);
        }

        public void Save()
        {
            dataContext.SaveChanges();
        }

        public T Update(T entity)
        {
            dataContext.Update(entity);
            Save();
            return entity;
        }
    }
}
