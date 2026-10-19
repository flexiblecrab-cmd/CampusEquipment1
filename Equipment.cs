using System.ComponentModel.DataAnnotations;

namespace CampusEquipment.Models;

public class Equipment
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = "";

    [Required]
    public string Category { get; set; } = "";

    public bool IsAvailable { get; set; } = true;
}