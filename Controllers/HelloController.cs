using Microsoft.AspNetCore.Mvc;

namespace DockNet.Controllers;

[ApiController]
[Route("api")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        return Ok(new { message = "Welcome to the API!" });
    }
}
