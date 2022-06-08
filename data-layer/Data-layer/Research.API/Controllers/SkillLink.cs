using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Research.Domain.Context;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillLink : ControllerBase
    {
        public SkillLink()
        {
            _context = new ResearchContext();
        }
        private readonly ResearchContext _context;
        
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Domain.Entity.SkillLink> Get()
        => _context.SkillLink
                .Include(p => p.Skill)
                .Include(p => p.Person)
                .ToList();

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Domain.Entity.SkillLink Get(Guid id)
        => _context.SkillLink
                .Include(p => p.Skill)
                .Include(p => p.Person)
                .FirstOrDefault(p => p.SkillLinkId == id);

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.SkillLink value)
        => new GenericService<Domain.Entity.SkillLink, Guid>().Insert(value);
    }
}
