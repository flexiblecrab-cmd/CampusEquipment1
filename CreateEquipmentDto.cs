using System.ComponentModel.DataAnnotations;

namespace CampusEquipment.DTOs;

public record CreateEquipmentDto(
    [Required] string Name,
    [Required] string Category);