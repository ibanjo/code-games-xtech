using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Person : ControllerBase
    {
        // GET: api/<Person>
        [HttpGet]
        public IEnumerable<Domain.Entity.Person> Get()
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.Person, Guid>().Get();
        }

        // GET api/<Person>/5
        [HttpGet("{id}")]
        public Domain.Entity.Person Get(Guid id)
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.Person, Guid>().GetById(id);
        }

        // POST api/<Person>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.Person value)
        {
            new ServiceLayer.GenericService.GenericService<Domain.Entity.Person, Guid>().Insert(value);
        }
    }
}
