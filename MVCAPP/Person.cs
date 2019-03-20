using Microsoft.EntityFrameworkCore;

namespace ui.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class MyDataContext : DbContext
    {
        public MyDataContext (DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Person> People { get; set; }
    }
}