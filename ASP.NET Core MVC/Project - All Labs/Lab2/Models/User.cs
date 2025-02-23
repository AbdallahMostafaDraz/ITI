using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimum Length Is 3 Characters!")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimum Length is 8 Characters!")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords Are Not Matched!")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public List<Role> Roles { get; set; } = new();
    }
}
