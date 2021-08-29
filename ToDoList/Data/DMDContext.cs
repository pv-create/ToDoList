using ToDoList.Models;
using Microsoft.EntityFrameworkCore;


namespace ToDoList.Data;
public class DMDContext: DbContext    
{
    public DMDContext(DbContextOptions<DMDContext> options) : base(options)
    {
    }

    public DbSet<Task> Courses { get; set; }
    public DbSet<NavigationProp> Enrollments { get; set; }
    public DbSet<User> Students { get; set; }

}
