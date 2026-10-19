using CampusEquipment.Data;
using CampusEquipment.DTOs;
using CampusEquipment.Models;
using Microsoft.EntityFrameworkCore;

public class ReservationService : IReservationService
{
    private readonly CampusEquipmentContext _context;

    public ReservationService(
        CampusEquipmentContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ReservationDto>>
        GetAllAsync()
    {
        return await _context.Reservations
            .Select(r => new ReservationDto(
                r.Id,
                r.BorrowerName,
                r.EquipmentId,
                r.ReservationDate,
                r.Status))
            .ToListAsync();
    }

    public async Task<ReservationDto?> GetByIdAsync(int id)
    {
        return await _context.Reservations
            .Where(r => r.Id == id)
            .Select(r => new ReservationDto(
                r.Id,
                r.BorrowerName,
                r.EquipmentId,
                r.ReservationDate,
                r.Status))
            .FirstOrDefaultAsync();
    }

    public async Task<ReservationDto>
        CreateAsync(CreateReservationDto dto)
    {
        var reservation = new Reservation
        {
            BorrowerName = dto.BorrowerName,
            EquipmentId = dto.EquipmentId,
            ReservationDate = DateTime.Now,
            Status = "Active"
        };

        _context.Reservations.Add(reservation);

        await _context.SaveChangesAsync();

        return new ReservationDto(
            reservation.Id,
            reservation.BorrowerName,
            reservation.EquipmentId,
            reservation.ReservationDate,
            reservation.Status);
    }

    public async Task<bool> CancelAsync(int id)
    {
        var reservation =
            await _context.Reservations.FindAsync(id);

        if (reservation == null)
            return false;

        reservation.Status = "Cancelled";

        await _context.SaveChangesAsync();

        return true;
    }

public async Task<bool> UpdateAsync(
    int id,
    UpdateReservationDto dto)
{
    var reservation =
        await _context.Reservations.FindAsync(id);

    if (reservation == null)
        return false;

    reservation.BorrowerName = dto.BorrowerName;
    reservation.EquipmentId = dto.EquipmentId;
    reservation.Status = dto.Status;

    await _context.SaveChangesAsync();

    return true;
}

}


