using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageLevel : ControllerBase
    {
        // GET: api/<LanguageLevel>
        [HttpGet]
        public IEnumerable<Domain.Entity.LanguageLevel> Get()
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.LanguageLevel, Guid>().Get();
        }

        // GET api/<LanguageLevel>/5
        [HttpGet("{id}")]
        public Domain.Entity.LanguageLevel Get(Guid id)
        {
            return new ServiceLayer.GenericService.GenericService<Domain.Entity.LanguageLevel, Guid>().GetById(id);
        }
    }
}
