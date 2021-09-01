
namespace ToDoList.Models;
public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronic { get; set; }
    public string Email { get; set; }

    public User()
    {
        this.ID = 0;
        this.Name = "";
        this.Surname = "";
        this.Patronic = "";
        this.Email = "";
    }

    public string UserInfo()
    {
        return $"ID: {this.ID} Surname: {this.Surname} Name: {this.Name} Patronic: {this.Patronic}";
    }



}
