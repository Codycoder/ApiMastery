﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Models
{
    public class Company
    {
        public string Title { get; set; }
        public int ID { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }

        public virtual ICollection<Character> Characters { get; set; }

        public Company(string title, int id, string location, string image, string color)
        {
            Title = title;
            ID = id;
            Location = location;
            Image = image;
            Color = color;
        }

    public Company()
        {

        }
    }
}
