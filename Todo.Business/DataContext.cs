using Microsoft.EntityFrameworkCore;
using TodoApp.Domain;

namespace TodoApp.Business
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }

    }
}
