
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models;
public class NavigationProp
{
    public int NavigationPropID{ get; set; }
    public int TaskID { get; set; }
    public int UserID { get; set; }

    public Task Task { get; set; }
    public User User { get; set; }

    protected void OnModelCreating(ModelBuilder modelBuilder)//создание таблиц
    {
        modelBuilder.Entity<Task>().ToTable("Tasks");
        modelBuilder.Entity<NavigationProp>().ToTable("NPs");
        modelBuilder.Entity<User>().ToTable("Users");
    }
}
