using HeartHealthAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HeartHealthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly ILogger<ModelController> _logger;

        public ModelController(ILogger<ModelController> logger)
        {
            this._logger = logger;
        }

        // GET: api/<ModelController>
        [HttpGet]
        public MedicalRecords Get()
        {
            MedicalRecords mr = new(75, 0, 582, 20, 26500, 1.9, 130, 4);

            return mr;
        }

        // GET api/<ModelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ModelController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ModelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
