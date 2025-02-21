using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2.Models
{
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(25, ErrorMessage = "Max Length Of Name Is 25 Charcters!")]
        [Required]
        public string Name { get; set; }
        public int Grade { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "CheckEmailExist", controller: "Student", ErrorMessage = "This Email Is Already Exist!")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        
        public int DeptId { get; set; }

        public Department? Department { get; set; } 


    }
}
