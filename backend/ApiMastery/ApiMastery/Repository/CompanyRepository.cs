using ApiMastery.Data;
using ApiMastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repository
{
    public class CompanyRepository : Repository<Company>, IRepository<Company>
    {
        private DbContext db;
        public CompanyRepository(CharacterContext context) : base(context)
        {
            this.db = context;
        }

        public override Company GetById(int id)
        {
            return db.Set<Company>().Where(i => i.ID == id).Include("Characters").FirstOrDefault();
        }
    }
}
