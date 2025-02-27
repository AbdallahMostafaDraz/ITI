using AutoMapper;
using Lab2.DataAccess;
using Lab2.Entities.DTOs.StudentDTOs;
using Lab2.Entities.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]

    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]
        [EndpointDescription("Get all students from Database ex: /mydatabase")]
        [EndpointSummary("Get all students")]
        [ProducesResponseType<List<GetStudentDTO>>(200)]
        [ProducesResponseType(404)]
        
        public async Task<IActionResult> GetAll()
        {
            var students = await _unitOfWork.Students.GetAll(null, new[] {"Dept"});
            var studentsDTO = _mapper.Map<List<GetStudentDTO>>(students);

            return Ok(studentsDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _unitOfWork.Students.Get(e => e.StId == id, new[] { "Dept", "StSuperNavigation" });
            if (student != null)
            {
                var studentDTO = _mapper.Map<GetStudentDTO>(student);
                return Ok(studentDTO);

            }
            return NotFound("THIS STUDENT IS NOT FOUND!");
        }

        [HttpGet]
        [Route("GetWithPagination")]
        public async Task<IActionResult> GetWithPagination(int pageNo, int pageSize)
        {
            var students = await _unitOfWork.Students.GetWithPagination(pageNo, pageSize, null, new[] {"Dept"});
            var studentsDTO = _mapper.Map<List<GetStudentDTO>>(students);
            return Ok(studentsDTO);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddStudentDTO studentDTO)
        {
            if (ModelState.IsValid)
            {
                var student = _mapper.Map<Student>(studentDTO);
                await _unitOfWork.Students.Add(student);
                await _unitOfWork.Complete();
                return CreatedAtAction("GetById", new { Id = studentDTO.Id }, studentDTO);
            }
            else
                return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, AddStudentDTO studentDTO)
        {
            if (id != studentDTO.Id)
                return BadRequest("THE ID IN THE URL DOES NOT MATCH THE ID IN THE BODY!");
           
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var student = await _unitOfWork.Students.Get(e => e.StId == id);
            if (student != null)
            {
                student = _mapper.Map(studentDTO, student);

                await _unitOfWork.Complete();
                return Ok(studentDTO);
            }
            return NotFound("THIS STUDENT IS NOT FOUND!");
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _unitOfWork.Students.Get(e => e.StId == id);
            if (student != null)
            {
                _unitOfWork.Students.Delete(student);
                await _unitOfWork.Complete();
                return Ok(student);
            }
            return NotFound("THIS STUDENT IS NOT FOUND!");
        }
    }
}
