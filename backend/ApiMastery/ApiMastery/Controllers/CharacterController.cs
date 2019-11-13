using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMastery.Models;
using ApiMastery.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMastery.Controllers
{
    [Route("api/character")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private IRepository<Character> charRepo;

        public CharacterController(IRepository<Character> charRepo)
        {
            this.charRepo = charRepo;
        }

        // GET: api/Character
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return charRepo.GetAll();
        }

        // GET: api/Character/5
        [HttpGet("{id}")]
        public Character Get(int id)
        {
            return charRepo.GetById(id);
        }

        // POST: api/Character
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Character/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
