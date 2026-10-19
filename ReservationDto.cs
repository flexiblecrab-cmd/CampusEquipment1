namespace CampusEquipment.DTOs;

public record ReservationDto(
    int Id,
    string BorrowerName,
    int EquipmentId,
    DateTime ReservationDate,
    string Status);