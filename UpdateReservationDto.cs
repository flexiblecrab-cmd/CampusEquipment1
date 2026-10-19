using System.ComponentModel.DataAnnotations;

namespace CampusEquipment.DTOs;

public record UpdateReservationDto(
    [Required] string BorrowerName,
    int EquipmentId,
    [Required] string Status);