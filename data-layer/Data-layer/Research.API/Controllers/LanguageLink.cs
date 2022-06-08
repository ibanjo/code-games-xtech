using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Research.Domain.Context;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageLink : ControllerBase
    {
        public LanguageLink()
        {
            _context = new ResearchContext();
        }
        private readonly ResearchContext _context;
        
        // GET: api/<LanguageLink>
        [HttpGet]
        public IEnumerable<Domain.Entity.LanguageLink> Get()
        => _context.LanguageLink
                .Include(p => p.Language)
                .Include(p => p.Person)
                .Include(p => p.LanguageLevel)
                .ToList();
            
        // GET api/<LanguageLink>/5
        [HttpGet("{id}")]
        public Domain.Entity.LanguageLink Get(Guid id)
        => _context.LanguageLink
                .Include(p => p.Language)
                .Include(p => p.Person)
                .Include(p => p.LanguageLevel)
                .FirstOrDefault(p => p.LanguageLinkId == id);

        // POST api/<LanguageLink>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.LanguageLink value)
        => new GenericService<Domain.Entity.LanguageLink, Guid>().Insert(value);
        
    }
}
