using Microsoft.AspNetCore.Mvc;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        // GET: api/<Skill>
        [HttpGet]
        public IEnumerable<Domain.Entity.Skill> Get()
        => new GenericService<Domain.Entity.Skill, Guid>().Get();
        

        // GET api/<Skill>/5
        [HttpGet("{id}")]
        public Domain.Entity.Skill Get(Guid id)
        => new GenericService<Domain.Entity.Skill, Guid>().GetById(id);
        
        // POST api/<Skill>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.Skill value)
        => new GenericService<Domain.Entity.Skill, Guid>().Insert(value);
        
    }
}
