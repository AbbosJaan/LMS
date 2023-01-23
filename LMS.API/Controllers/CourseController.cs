using LMS.DataAccess.RequestEntity;
using LMS.DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;
        public CourseController(ICourseService service)
        {
            _service = service;
        }
        // GET: api/<QimatlarController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var course = await _service.GetByIdAsync(id);
            if(course == null)
                return NotFound();  
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CourseRequest value)
        {
            var result = await _service.AddAsync(value);
            if(result == null)
                return BadRequest("Course creadential faild!");
            return Ok(result); 
        }

        // PUT api/<QimatlarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QimatlarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
