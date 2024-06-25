using Microsoft.AspNetCore.Mvc;

namespace ExceptionsHandler.NET.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HoustonController : ControllerBase
{
    [HttpGet]
    public IActionResult Error()
    {
        throw new Exception("Oxygen leak in our API ship!");
    }
}