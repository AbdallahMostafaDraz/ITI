
using System.ComponentModel.DataAnnotations;

namespace Lab2.Entities.DTOs.DepartmentDTOs
{
    public abstract class DepartmentDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;    
        public int? ManagerId { get; set; }
        public DateOnly? ManagerHireDate { get; set; }

    }
}
