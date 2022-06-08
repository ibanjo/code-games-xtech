using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Research.Domain.Context;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Person : ControllerBase
    {
        public Person()
        {
            _context = new ResearchContext();
        }
        private readonly ResearchContext _context;

        // GET: api/<Person>
        [HttpGet]
        public IEnumerable<Domain.Entity.Person> Get()
        => _context.Person.Include(p => p.Site).ToList();
        
        // GET api/<Person>/5
        [HttpGet("{id}")]
        public Domain.Entity.Person Get(Guid id)
        => _context.Person.Include(p => p.Site).FirstOrDefault();
        

        // POST api/<Person>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.Person value)
        => new GenericService<Domain.Entity.Person, Guid>().Insert(value);
        
    }
}
