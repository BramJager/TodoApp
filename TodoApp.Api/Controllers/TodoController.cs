using Microsoft.AspNetCore.Mvc;
using TodoApp.Business.Interfaces;
using TodoApp.Domain;

namespace TodoApp.Api.Controllers
{
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        [HttpGet]
        [Route("/api/todos")]
        public IActionResult GetAll()
        {
            return Ok(todoService.GetAll());
        }

        [HttpGet]
        [Route("/api/todo/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(todoService.GetById(id));
        }

        [HttpPost]
        [Route("/api/todo/create")]
        public IActionResult Create(Todo todo)
        {
            todoService.Create(todo);
            return Ok(todo);
        }

        [HttpPost]
        [Route("/api/todo/{id}/check")]
        public IActionResult Check(int id)
        {
            var todo = todoService.GetById(id);
            todo.IsDone = !todo.IsDone;
            todo = todoService.Update(todo);
            return Ok(todo);
        }

        [HttpPost]
        [Route("/api/todo/{id}/delete")]
        public IActionResult Delete(int id)
        {
            var todo = todoService.GetById(id);
            todoService.Delete(todo);
            return Ok();
        }
    }
}
