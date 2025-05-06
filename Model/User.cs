public class User 
{
    public int ID {get; set;}
    public Guid guid {get; set;}
    public string Username {get; set;} = "Guest";
    public string Email {get; set;} = "guest@example.com";
    public string Password {get; private set;} = string.Empty;
}