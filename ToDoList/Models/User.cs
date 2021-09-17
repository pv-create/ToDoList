
namespace ToDoList.Models;
public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronic { get; set; }
    public string Number { get; set; }

    public User()
    {
        this.ID = 1;
        this.Name = "";
        this.Surname = "";
        this.Patronic = "";
        this.Number = "";
    }

    public User(int ID, string Name, string Surname, string Patronic, string Email)
    {

        this.ID = ID;
        this.Name = Name;
        this.Surname = Surname;
        this.Patronic = Patronic;
        this.Number = Email;
    }

    public string UserInfo()
    {
        IDCheck(this.ID);
        return $"ID: {this.ID} Surname: {this.Surname} Name: {this.Name} Patronic: {this.Patronic}";
    }

    public void IDCheck(int ID)
    {
        if(ID<1)
        {
            throw new ArgumentOutOfRangeException("ID");
        }
    }

}
