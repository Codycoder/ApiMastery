using ApiMastery.Data;
using ApiMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repository
{
    public class ProfessionRepository : Repository<Company>, IRepository<Company>
    {
        public ProfessionRepository(CharacterContext context) : base(context)
        {

        }
    }
}
