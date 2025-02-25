using Day1.Data;
using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly AppDBContext _context;
        public CourseController(AppDBContext context) => _context = context;

        
        [HttpGet]
        public IActionResult GetAll()
        {
            var allCourses = _context.Courses.ToList();
            return Ok(allCourses);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var course = _context.Courses.SingleOrDefault(e => e.Id == id);
            if (course != null)
            {
                return Ok(course);
            }
            return NotFound("This Course Is Not Found!");
        }

        [HttpPost]
        public IActionResult Add(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetOne), new { course.Id }, course);
            }
            return BadRequest(course);
        }

        [HttpPut]
        public IActionResult Update(int id, Course course)
        {
            if (course == null || (id != course.Id) || (!ModelState.IsValid))
                return BadRequest(course);

            _context.Update(course);
            _context.SaveChanges(true);
            return CreatedAtAction(nameof(GetOne), new { course.Id }, course);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var course = _context.Courses.FirstOrDefault(e => e.Id == id);
            if (course != null)
            {
                _context.Remove(course);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetOne), new { course.Id }, course);
            }
            return NotFound("This Course Is Not Found!");
        }
    }
}
