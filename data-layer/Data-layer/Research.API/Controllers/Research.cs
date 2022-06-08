using Microsoft.AspNetCore.Mvc;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Research : ControllerBase
    {
        // GET: api/<Research>
        [HttpGet]
        public IEnumerable<Domain.Entity.Research> Get()
        {
            return new GenericService<Domain.Entity.Research, Guid>().Get();
        }

        // GET api/<Research>/5
        [HttpGet("{id}")]
        public Domain.Entity.Research Get(Guid id)
        {
            return new GenericService<Domain.Entity.Research, Guid>().GetById(id);
        }

        // POST api/<Research>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.Research value)
        {
            new GenericService<Domain.Entity.Research, Guid>().Insert(value);
        }
    }
}
