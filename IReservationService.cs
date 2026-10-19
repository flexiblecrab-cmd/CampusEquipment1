using CampusEquipment.DTOs;

public interface IReservationService
{
    Task<IEnumerable<ReservationDto>> GetAllAsync();

    Task<ReservationDto?> GetByIdAsync(int id);

    Task<ReservationDto> CreateAsync(CreateReservationDto dto);

    Task<bool> UpdateAsync(
       int id,
       UpdateReservationDto dto); 
    
    Task<bool> CancelAsync(int id);   
    
}