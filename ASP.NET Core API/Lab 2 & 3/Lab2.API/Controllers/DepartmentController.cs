using Lab2.DataAccess;
using Lab2.Entities.DTOs.DepartmentDTOs;
using Lab2.Entities.DTOs.StudentDTOs;
using Lab2.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _unitOfWork.Departments.GetAll(null, new[] {"Students"});
            var departmnetDTO = new List<GetDepartmentDTO>();
            foreach (var department in departments)
            {
                departmnetDTO.Add(new GetDepartmentDTO
                {
                    Id = department.DeptId,
                    Name = department.DeptName,
                    Description = department.DeptDesc,
                    Location = department.DeptLocation,
                    ManagerId = department.DeptManager,
                    ManagerHireDate = department.ManagerHiredate,
                    NoOfStudents = department.Students != null ? department.Students.Count : 0
                });
            }
            
            return Ok(departmnetDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await _unitOfWork.Departments.Get(e => e.DeptId == id, new[] { "Students"});
            if (department != null)
            {
                GetDepartmentDTO departmnetDTO = new GetDepartmentDTO()
                {
                    Id = department.DeptId,
                    Name = department.DeptName,
                    Description = department.DeptDesc,
                    Location = department.DeptLocation,
                    ManagerId = department.DeptManager,
                    ManagerHireDate = department.ManagerHiredate,
                    NoOfStudents = department.Students != null ? department.Students.Count : 0
                };
                return Ok(departmnetDTO);

            }
            return NotFound("THIS DEPARTMENT IS NOT FOUND!");
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddDepartmentDTO departmentDTO)
        {
            if (ModelState.IsValid)
            {
                var department = new Department()
                {
                    DeptId = departmentDTO.Id,
                    DeptName = departmentDTO.Name,
                    DeptDesc = departmentDTO.Description,
                    DeptLocation = departmentDTO.Location,
                    DeptManager = departmentDTO.ManagerId,
                    ManagerHiredate = departmentDTO.ManagerHireDate
                };
                await _unitOfWork.Departments.Add(department);
                await _unitOfWork.Complete();
                return CreatedAtAction("GetById", new { Id = departmentDTO.Id }, departmentDTO);
            }
            else
                return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, AddDepartmentDTO departmentDTO)
        {
            if (id != departmentDTO.Id)
                return BadRequest("THE ID IN THE URL DOES NOT MATCH THE ID IN THE BODY!");
           
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var department = await _unitOfWork.Departments.Get(e => e.DeptId == id);
            if (department != null)
            {
                department.DeptName = departmentDTO.Name;
                department.DeptDesc = departmentDTO.Description;
                department.DeptLocation = departmentDTO.Location;
                department.DeptManager = departmentDTO.ManagerId;
                department.ManagerHiredate = departmentDTO.ManagerHireDate;

                await _unitOfWork.Complete();
                return Ok(departmentDTO);
            }
            return NotFound("THIS Department IS NOT FOUND!");
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _unitOfWork.Departments.Get(e => e.DeptId == id);
            if (department != null)
            {
                _unitOfWork.Departments.Delete(department);
                await _unitOfWork.Complete();
                return Ok(department);
            }
            return NotFound("THIS DEPARTMENT IS NOT FOUND!");
        }
    }
}
