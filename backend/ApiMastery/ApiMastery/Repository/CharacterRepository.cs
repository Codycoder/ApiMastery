using ApiMastery.Data;
using ApiMastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repository
{
    public class CharacterRepository : Repository<Character>, IRepository<Character>
    {
        private DbContext db;
        public CharacterRepository(CharacterContext context) : base(context)
        {
            this.db = context;
        }

        public override Character GetById(int id)
        {
            return db.Set<Character>().Where(i => i.ID == id).Include("Company").FirstOrDefault();
        }
    }
}
