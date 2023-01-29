using LMS.DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicService _service;
        public TopicsController(ITopicService service)
        {
            _service = service;
        }
        // GET: api/<TopicsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync(n => n.Course));
        }

        // GET api/<TopicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TopicsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TopicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TopicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
