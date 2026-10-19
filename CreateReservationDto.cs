using System.ComponentModel.DataAnnotations;

namespace CampusEquipment.DTOs;

public record CreateReservationDto(
    [Required] string BorrowerName,
    int EquipmentId);