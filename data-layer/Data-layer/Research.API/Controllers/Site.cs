using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Site : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Domain.Entity.Site> Get()
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.Site, Guid>().Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Domain.Entity.Site Get(Guid id)
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.Site, Guid>().GetById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Domain.Entity.Site value)
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.Site, Guid>().Insert(value);
        }
    }
}
