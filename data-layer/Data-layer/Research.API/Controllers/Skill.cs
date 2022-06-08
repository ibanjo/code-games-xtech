﻿using Microsoft.AspNetCore.Mvc;
using Research.Domain.GenericService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Research.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Skill : ControllerBase
    {
        // GET: api/<Skill>
        [HttpGet]
        public IEnumerable<Domain.Entity.Skill> Get()
        {
            return new GenericService<Domain.Entity.Skill, Guid>().Get();
        }

        // GET api/<Skill>/5
        [HttpGet("{id}")]
        public Domain.Entity.Skill Get(Guid id)
        {
            return new GenericService<Domain.Entity.Skill, Guid>().GetById(id);
        }

        // POST api/<Skill>
        [HttpPost]
        public void Post([FromBody] Domain.Entity.Skill value)
        {
            new GenericService<Domain.Entity.Skill, Guid>().Insert(value);
        }
    }
}
