using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Research.Domain.Context;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResearchController : ControllerBase
    {
        public ResearchController()
        {
            _context = new ResearchContext();
        }
        private readonly ResearchContext _context;

        // GET: api/<Research>
        [HttpGet]
        public IEnumerable<Domain.Entity.Research> Get()
        => _context.Research
                .Include(p => p.Person)
                .Include(p => p.Language)
                .Include(p => p.Site)
                .ToList();

        // GET api/<Research>/5
        [HttpGet("{id}")]
        public Domain.Entity.Research Get(Guid id)
        => _context.Research
                .Include(p => p.Person)
                .Include(p => p.Language)
                .Include(p => p.Site)
                .FirstOrDefault(p => p.ResearchId == id);

        // POST api/<Research>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.Research value)
        => new GenericService<Domain.Entity.Research, Guid>().Insert(value);
        
    }
}
