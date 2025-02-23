using Lab2.Data;
using Lab2.Models;
using Lab2.Repositries.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    [Authorize(Roles = "Instructor")]
    public class DepartmentController : Controller
    {
        IUnitOfWork unitOfWork; 
        public DepartmentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var allDepartments = unitOfWork.Department.GetAll().ToList();
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
                unitOfWork.Department.Add(department);
                unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var department = unitOfWork.Department.GetOne(e => e.Id == id);
            if (department == null)
                return NotFound("There No Departments!");
            return View(department);            
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = unitOfWork.Department.GetOne(e => e.Id == id);
            if (department == null)
                return NotFound("There No Departments!");
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(int id, Department department)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Department.Edit(department);
                unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = unitOfWork.Department.GetOne(e => e.Id == id);
            if (department == null)
                return NotFound("There No Departments!");
            
            unitOfWork.Department.Remove(department);
            unitOfWork.Complete();
            return RedirectToAction("Index");
        }
    }
}
