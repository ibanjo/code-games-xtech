using Microsoft.AspNetCore.Mvc;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageLevelController : ControllerBase
    {
        // GET: api/<LanguageLevel>
        [HttpGet]
        public IEnumerable<Domain.Entity.LanguageLevel> Get()
        => new GenericService<Domain.Entity.LanguageLevel, Guid>().Get();
        

        // GET api/<LanguageLevel>/5
        [HttpGet("{id}")]
        public Domain.Entity.LanguageLevel Get(Guid id)
        => new GenericService<Domain.Entity.LanguageLevel, Guid>().GetById(id);
        
    }
}
