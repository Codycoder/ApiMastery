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

        private IRepository<Character> characterRepo;

        public CharacterController(IRepository<Character> characterRepo)
        {
            this.characterRepo = characterRepo;
        }

        // GET: api/Character
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return characterRepo.GetAll();
            //return new List<Artist>();
        }

        // GET: api/Character/5
        [HttpGet("{id}")]
        public Character Get(int id)
        {
            return characterRepo.GetById(id);

        }

        // POST: api/Character
        [HttpPost]
        public IEnumerable<Character> Post([FromBody] Character character)
        {
            characterRepo.Create(character);
            return characterRepo.GetAll();
        }

        // PUT: api/Character/5
        [HttpPut("{id}")]

        public IEnumerable<Character> Put([FromBody] Character character)
        {
            characterRepo.Update(character);
            return characterRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]

        public IEnumerable<Character> Delete(int id)
        {
            var deletecharacter = characterRepo.GetById(id);
            characterRepo.Delete(deletecharacter);
            return characterRepo.GetAll();
        }
    }
}
