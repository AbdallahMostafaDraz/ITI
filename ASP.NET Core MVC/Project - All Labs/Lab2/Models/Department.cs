using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(25, ErrorMessage = "Max Length Of Name Is 25 Charcters!")]
        [MinLength(2, ErrorMessage ="Minimum Length Is 2 Characters")]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Capacity {  get; set; }

        public List<Student> Students { get; set; } = new();
    }
}
