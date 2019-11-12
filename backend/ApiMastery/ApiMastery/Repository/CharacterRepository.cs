using ApiMastery.Data;
using ApiMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repository
{
    public class CharacterRepository : Repository<Character>, IRepository<Character>
    {
        public CharacterRepository(CharacterContext context) : base(context)
        {

        }
    }
}
