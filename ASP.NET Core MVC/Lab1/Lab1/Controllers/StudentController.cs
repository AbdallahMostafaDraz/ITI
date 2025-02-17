using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 4 
        public ViewResult AddStudent()
        {
            return View();
        }

        public string ShowStudent(Student student)
        {
            return student.ToString();
        }
    }
}
