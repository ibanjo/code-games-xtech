using Microsoft.AspNetCore.Mvc;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Language : ControllerBase
    {
        // GET: api/<Language>
        [HttpGet]
        public IEnumerable<Domain.Entity.Language> Get()
        {
            return new GenericService<Domain.Entity.Language, Guid>().Get();
        }
        
        // GET api/<Language>/5
        [HttpGet("{id}")]
        public Domain.Entity.Language Get(Guid id)
        {
            return new GenericService<Domain.Entity.Language, Guid>().GetById(id);
        }
    }
}
