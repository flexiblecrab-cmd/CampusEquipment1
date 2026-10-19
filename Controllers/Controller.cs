using Microsoft.AspNetCore.Mvc;

namespace CampusEquipment.Controllers;

[ApiController]
[Route("api/equipment")]
public class EquipmentController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var equipment = new[]
        {
            new
            {
                Id = 1,
                Name = "Dell Laptop 01",
                Category = "Laptop",
                IsAvailable = true
            },
            new
            {
                Id = 2,
                Name = "Projector 01",
                Category = "Projector",
                IsAvailable = false
            }
        };

        return Ok(equipment);
    }
}