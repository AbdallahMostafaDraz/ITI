using Lab2.Data;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class StudentController : Controller
    {
        AppDBContext context = new AppDBContext();
        public IActionResult Index()
        {
            var allStuents = context.Students.Include(e => e.Department).ToList();
            return View(allStuents);
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllDepartments = context.Departments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
