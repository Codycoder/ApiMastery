using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMastery.Models;
using ApiMastery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiMastery.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private IRepository<Company> compRepo;

        public CompanyController(IRepository<Company> compRepo)
        {
            this.compRepo = compRepo;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return compRepo.GetAll();
        }

        // GET: api/Character/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            return compRepo.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
