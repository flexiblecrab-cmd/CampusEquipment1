namespace CampusEquipment.DTOs;

public record EquipmentDto(
    int Id,
    string Name,
    string Category,
    bool IsAvailable);