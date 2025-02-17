using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(25, ErrorMessage = "Max Length Of Name Is 25 Charcters!")]
        [Required]
        public string Name { get; set; }
        public int Grade { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }

    }
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(25, ErrorMessage = "Max Length Of Name Is 25 Charcters!")]
        [Required]
        public string Name { get; set; }

        public int Capacity {  get; set; }

        public List<Student> Students { get; set; } = new();
    }
}
