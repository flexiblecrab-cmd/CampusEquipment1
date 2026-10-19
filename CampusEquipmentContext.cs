
using Microsoft.EntityFrameworkCore;
using CampusEquipment.Models;

namespace CampusEquipment.Data;

public class CampusEquipmentContext : DbContext
{
    public CampusEquipmentContext(
        DbContextOptions<CampusEquipmentContext> options)
        : base(options)
    {
    }

    public DbSet<Equipment> Equipment => Set<Equipment>();

    public DbSet<Reservation> Reservations => Set<Reservation>();
}