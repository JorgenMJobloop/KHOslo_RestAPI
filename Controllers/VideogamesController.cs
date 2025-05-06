using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/videogames")]
public class VideogamesController : ControllerBase 
{
    private List<Videogames> videoGames = new List<Videogames>() {
        new Videogames {ID = 1, Title = "Persona 4", Genre = ["JRPG"], Multiplayer = false, Platform = ["Playstation 2", "Playstation 3", "PC"], ReleaseYear = 2008}
    };

    [HttpGet]
    public IEnumerable<Videogames> GetVideogames() 
    {
        return videoGames;
    }
}