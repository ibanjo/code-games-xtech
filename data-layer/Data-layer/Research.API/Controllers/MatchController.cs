using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Research.Domain.Context;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        public MatchController()
        {
            _context = new ResearchContext();
        }
        private readonly ResearchContext _context;

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Domain.Entity.Match> Get()
        => _context.Match
                .Include(p => p.Person)
                .Include(p => p.Research)
                .ToList();

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Domain.Entity.Match Get(Guid id)
        => _context.Match
                .Include(p => p.Person)
                .Include(p => p.ResearchId)
                .FirstOrDefault(p => p.MatchId == id);

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.Match value)
        => new GenericService<Domain.Entity.Match, Guid>().Insert(value);
    }
}
