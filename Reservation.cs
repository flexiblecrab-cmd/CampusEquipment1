using System.ComponentModel.DataAnnotations;

namespace CampusEquipment.Models;

public class Reservation
{
    public int Id { get; set; }

    [Required]
    public string BorrowerName { get; set; } = "";

    public int EquipmentId { get; set; }

    public DateTime ReservationDate { get; set; }

    public string Status { get; set; } = "Active";

    public Equipment? Equipment { get; set; }
}