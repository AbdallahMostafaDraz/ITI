
using System.ComponentModel.DataAnnotations;

namespace Lab2.Entities.DTOs.StudentDTOs
{
    public class AddStudentDTO : StudentDTO
    {
        [Required]
        public int? DeptId { get; set; }

        public int? StSuper { get; set; }
    }
}
