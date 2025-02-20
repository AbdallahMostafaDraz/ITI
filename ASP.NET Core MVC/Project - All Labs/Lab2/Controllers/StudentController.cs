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
            if (ModelState.IsValid)
            {
                if (student.DeptId == 0)
                    ModelState.AddModelError("DeptId", "Please Select a Department!");
                else
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.AllDepartments = context.Departments.ToList();
            return View(student);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = context.Students.Include(e => e.Department).FirstOrDefault(x => x.Id == id);
            if (student == null)
                return NotFound("There No Students!");
            return View(student);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = context.Students.FirstOrDefault(e => e.Id == id);
            if (student == null)
                return NotFound("There No Students!");
            TempData["id"] = student.Id;
            ViewBag.AllDepartments = context.Departments.ToList();
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.DeptId == 0)
                    ModelState.AddModelError("DeptId", "Please Select a Department!");
                context.Students.Update(student);
                context.SaveChanges();
                 return RedirectToAction("Index");
            }
            ViewBag.AllDepartments = context.Departments.ToList();
            return View(student);
        }

        public IActionResult CheckEmailExist(string Email)
        {
            var emailExist = context.Students.Any(e => e.Email == Email && e.Id != int.Parse(TempData.Peek("id")!.ToString()!));
            return Json(!emailExist);
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = context.Students.FirstOrDefault(e => e.Id == id);
            if (student == null)
                return NotFound("There No Students!");

            context.Students.Remove(student);
            context.SaveChanges(true); 
            return RedirectToAction("Index");
        }
        
    }
}

