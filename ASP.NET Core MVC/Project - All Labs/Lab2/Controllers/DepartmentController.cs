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
            if (ModelState.IsValid)
            {
                context.Departments.Add(department);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var department = context.Departments.FirstOrDefault(x => x.Id == id);
            if (department == null)
                return NotFound("There No Departments!");
            return View(department);            
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = context.Departments.FirstOrDefault(e => e.Id == id);
            if (department == null)
                return NotFound("There No Departments!");
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(int id, Department department)
        {
            if (ModelState.IsValid)
            {
                context.Departments.Update(department);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = context.Departments.FirstOrDefault(e => e.Id == id);
            if (department == null)
                return NotFound("There No Departments!");
            
            context.Departments.Remove(department);
            context.SaveChanges(true);
            return RedirectToAction("Index");
        }
    }
}
