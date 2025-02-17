using Lab2.Data;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class DepartmentController : Controller
    {
        AppDBContext context = new AppDBContext();
        public IActionResult Index()
        {
            var allDepartments = context.Departments.ToList();
            return View(allDepartments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
