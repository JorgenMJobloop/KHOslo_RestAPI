using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase 
{
    [HttpPost]
    public IActionResult CreateUser([FromForm] User user) 
    {
        return CreatedAtAction(nameof(CreateUser), new {id = user.ID, user.guid, user.Username,user.Email, user.Password });
    }
}