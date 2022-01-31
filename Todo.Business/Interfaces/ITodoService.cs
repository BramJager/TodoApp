using System.Collections.Generic;
using TodoApp.Domain;

namespace TodoApp.Business.Interfaces
{
    public interface ITodoService
    {
        public Todo GetById(int id);
        public void Delete(Todo todo);
        public Todo Update(Todo todo);
        public IEnumerable<Todo> GetAll();
        public void Create(Todo todo);
    }
}
