using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageLink : ControllerBase
    {
        // GET: api/<LanguageLink>
        [HttpGet]
        public IEnumerable<Domain.Entity.LanguageLink> Get()
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.LanguageLink, Guid>().Get();
        }

        // GET api/<LanguageLink>/5
        [HttpGet("{id}")]
        public Domain.Entity.LanguageLink Get(Guid id)
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.LanguageLink, Guid>().GetById(id);
        }

        // POST api/<LanguageLink>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.LanguageLink value)
        {
            new ServiceLayer.GenericService.GenericService<Domain.Entity.LanguageLink, Guid>().Insert(value);
        }
    }
}
