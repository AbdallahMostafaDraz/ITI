using Lab2.Data;
using Lab2.Models;
using Lab2.Repositries.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class StudentController : Controller
    {
        IUnitOfWork unitOfWork;
        public StudentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var allStuents = unitOfWork.Student.GetAll(null, new[] { "Department" }).ToList();
            return View(allStuents);
        }


        [HttpGet]
        public IActionResult Create()
        {
            
            ViewBag.AllDepartments = unitOfWork.Department.GetAll().ToList();
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
                    unitOfWork.Student.Add(student);
                    unitOfWork.Complete();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.AllDepartments = unitOfWork.Department.GetAll().ToList();
            return View(student);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            var student = unitOfWork.Student.GetOne(e => e.Id == id, new[] { "Derpartmnet" });
  
            if (student == null)
                return NotFound("There No Students!");
            return View(student);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = unitOfWork.Student.GetOne(e => e.Id == id);
            if (student == null)
                return NotFound("There No Students!");
            TempData["id"] = student.Id;
            ViewBag.AllDepartments = unitOfWork.Department.GetAll().ToList();
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.DeptId == 0)
                    ModelState.AddModelError("DeptId", "Please Select a Department!");
                unitOfWork.Student.Edit(student);
                unitOfWork.Complete();
                 return RedirectToAction("Index");
            }
            ViewBag.AllDepartments = unitOfWork.Department.GetAll().ToList();
            return View(student);
        }

        public IActionResult CheckEmailExist(string Email)
        {
            if (TempData.ContainsKey("id"))
            {
                int.TryParse(TempData.Peek("id")!.ToString(), out int id);
                return Json(!unitOfWork.Student.CheckEmail(e => e.Email == Email && e.Id != id));
            }
            return Json(!unitOfWork.Student.CheckEmail(e => e.Email == Email));
            
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = unitOfWork.Student.GetOne(e => e.Id == id);
            if (student == null)
                return NotFound("There No Students!");

            unitOfWork.Student.Remove(student);
            unitOfWork.Complete(); 
            return RedirectToAction("Index");
        }
        
    }
}

