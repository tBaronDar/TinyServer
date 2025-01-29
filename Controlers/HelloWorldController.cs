using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{

    //WineDbContext db = new WineDbContext(options)

    [HttpGet]
    public IActionResult Get()
    {
        // using (var db = new WineDbContext())
        // {
        //     return await db.Teachers.FindAsync(id);
        // }
        return Ok("Hello, World!");
    }
}