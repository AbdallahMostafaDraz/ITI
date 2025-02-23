using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<User> Users { get; set; } = new();
    }   
}
