using ToDoList.Models;
using Microsoft.EntityFrameworkCore;


namespace ToDoList.Data;
public class DMDContext: DbContext    
{
    public DMDContext(DbContextOptions<DMDContext> options) : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }

    public DbSet<Task> Tasks { get; set; }
    public DbSet<NavigationProp> Enrollments { get; set; }
    public DbSet<User> Users { get; set; }

}
