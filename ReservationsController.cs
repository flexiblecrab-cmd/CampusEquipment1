using CampusEquipment.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CampusEquipment.Controllers;

[ApiController]
[Route("api/reservations")]
public class ReservationsController : ControllerBase
{
    private readonly IReservationService _service;

    public ReservationsController(
        IReservationService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var reservation =
            await _service.GetByIdAsync(id);

        if (reservation == null)
            return NotFound();

        return Ok(reservation);
    }

    [HttpPost]
    public async Task<IActionResult>
        Create(CreateReservationDto dto)
    {
        var reservation =
            await _service.CreateAsync(dto);

        return CreatedAtAction(
            nameof(GetById),
            new { id = reservation.Id },
            reservation);
    }

[HttpPut("{id}")]
public async Task<IActionResult> Update(
    int id,
    UpdateReservationDto dto)
{
    bool result =
        await _service.UpdateAsync(id, dto);

    if (!result)
        return NotFound();

    return NoContent();
}

    [HttpDelete("{id}")]
    public async Task<IActionResult> Cancel(int id)
    {
        bool result =
            await _service.CancelAsync(id);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
