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
        public string Ability { get; set; }
        public int ID { get; set; }
        public string Image { get; set; }

        public virtual Company company { get; set; }
        public int CompanyID { get; set; }
      
        public Character(string name, string game, string profession, string ability, int id, string image)
        {
            Name = name;
            Game = game;
            Profession = profession;
            Ability = ability;
            ID = id;
            Image = image;
        }

        public Character()
        {

        }
    }
}
