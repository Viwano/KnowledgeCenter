using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KnowledgeCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnowledgeController : ControllerBase
    {
        // GET: api/<KnowledgeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<KnowledgeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KnowledgeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<KnowledgeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KnowledgeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
