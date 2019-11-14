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
        private IRepository<Company> companyRepo;

        public CompanyController(IRepository<Company> companyRepo)
        {
            this.companyRepo = companyRepo;
        }
        // GET: api/Company
        [HttpGet]
        public IEnumerable<Company> Get()
        { 
            return companyRepo.GetAll();
            //return new List<Company>();
        }

        // GET: api/Company/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            return companyRepo.GetById(id);
        }

        // POST: api/Company
        [HttpPost]
        public IEnumerable<Company> Post([FromBody] Company company)
        {
            companyRepo.Create(company);
            return companyRepo.GetAll();
        }

        // PUT: api/Company/5
        [HttpPut("{id}")]

        public IEnumerable<Company> Put([FromBody] Company company)
        {
            companyRepo.Update(company);
            return companyRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        public IEnumerable<Company> Delete(int id)
        {
            var company = companyRepo.GetById(id);
            companyRepo.Delete(company);
            return companyRepo.GetAll();
        }
    }
}
