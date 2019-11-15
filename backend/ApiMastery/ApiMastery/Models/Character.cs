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
        public string Color { get; set; }

        public virtual Company Company { get; set; }
        public int CompanyID { get; set; }
      
        public Character(string name, string game, string ability, int id, string image, string color)
        {
            Name = name;
            Game = game;
            Ability = ability;
            ID = id;
            Image = image;
        }

        public Character()
        {

        }
    }
}
