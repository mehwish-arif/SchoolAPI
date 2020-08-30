using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private SchoolContext _context;

        public CourseController(SchoolContext context)
        {
            _context = context;
        }
        // GET: api/<CourseController>
        
        
        [HttpGet]
        public IActionResult Get()
        {
          //  var id = _context.Course;
            return Ok(_context.Courses.ToList()) ;
        }
        // GET api/<CourseController>/5
     /*   [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
     */
        // POST api/<CourseController>
        [HttpPost]
        public IActionResult Add([FromBody] Course course)
        {
            //Determine the next ID
            // var newID = _context.CoursesID.Select(x => x.ID).Max() + 1;
            
          //  course.CourseID = newID;

            _context.Add(course);
            _context.SaveChanges();
            return Ok();
        }

       
    }
}
