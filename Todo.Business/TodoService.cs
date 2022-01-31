using System.Collections.Generic;
using TodoApp.Business.Interfaces;
using TodoApp.Domain;

namespace TodoApp.Business
{
    public class TodoService : ITodoService
    {
        private readonly IRepository<Todo> repository;

        public TodoService(IRepository<Todo> repository)
        {
            this.repository = repository;
        }
        public void Create(Todo todo)
        {
            repository.Create(todo);
            repository.Save();
        }

        public void Delete(Todo todo)
        {
            repository.Delete(todo);
            repository.Save();
        }

        public IEnumerable<Todo> GetAll()
        {
            return repository.Get();
        }

        public Todo GetById(int id)
        {
            return repository.Get(id);
        }

        public Todo Update(Todo todo)
        {
            return repository.Update(todo);
        }
    }
}
