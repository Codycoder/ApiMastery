using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Game { get; set; }
        public string Profession { get; set; }
        public string Ability { get; set; }
        public int ID { get; set; }
        public string Image { get; set; }

        public Character()
        {

        }
    }
}
