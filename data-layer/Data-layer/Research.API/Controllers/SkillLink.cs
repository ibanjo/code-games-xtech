using Microsoft.AspNetCore.Mvc;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillLink : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Domain.Entity.SkillLink> Get()
        {
            return new GenericService<Domain.Entity.SkillLink, Guid>().Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Domain.Entity.SkillLink Get(Guid id)
        {
            return new GenericService<Domain.Entity.SkillLink, Guid>().GetById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.SkillLink value)
        {
            new GenericService<Domain.Entity.SkillLink, Guid>().Insert(value);
        }
    }
}
