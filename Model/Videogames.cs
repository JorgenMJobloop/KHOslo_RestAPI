public class Videogames 
{
    public int ID {get; set;}
    public string Title {get; set;} = string.Empty;
    public List<string>? Genre {get; set;}
    public bool Multiplayer {get; set;}
    public List<string>? Platform {get; set;}
    public int ReleaseYear {get; set;}

}