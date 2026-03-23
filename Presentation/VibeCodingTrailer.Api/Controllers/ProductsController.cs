using Microsoft.AspNetCore.Mvc;

namespace VibeCodingTrailer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var items = new[] { new { Id = 1, Name = "Dummy Product", Price = 9.99m } };
        return Ok(items);
    }
}
