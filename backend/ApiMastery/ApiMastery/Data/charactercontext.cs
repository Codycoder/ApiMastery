using ApiMastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Data
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SuperMarioDB;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
            //.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(

                new Character()
                {
                    ID = 1,
                    Name = "Mario",
                    Game = "Mario Bros.",
                    CompanyID = 1,
                    Ability = "Super Mario",
                    Image = "./images/mario.png"
                },

                new Character()
                {
                    ID = 2,
                    Name = "Princess Toadstool",
                    Game = "Super Mario Bros. 2",
                    CompanyID = 1,
                    Ability = "Float",
                    Image = "./images/peach.png"
                },

                new Character()
                {
                    ID = 3,
                    Name = "Wario",
                    Game = "Super Mario Land 2",
                    CompanyID = 1,
                    Ability = "Invulnerability",
                    Image = "./images/wario.png"
                },

                new Character()
                {
                    ID = 4,
                    Name = "Mouser",
                    Game = "Super Mario Bros 2",
                    CompanyID = 1,
                    Ability = "Throws bombs",
                    Image = "./images/mouser.png"
                },

                new Character()
                {
                    ID = 5,
                    Name = "Bowser",
                    Game = "Super Mario Bros.",
                    CompanyID = 1,
                    Ability = "Flame Breath",
                    Image = "./images/bowser.png"
                },

                new Character()
                {
                    ID = 6,
                    Name = "Rosalina",
                    Game = "Super Mario Galaxy",
                    CompanyID = 1,
                    Ability = "Galactic Wand/Luma",
                    Image = "./images/rosalina.png"
                },

                new Character()
                {
                    ID = 7,
                    Name = "Dry Bones",
                    Game = "Super Mario Bros. 3",
                    CompanyID = 1,
                    Ability = "Reform",
                    Image = "./images/drybones.png"
                },

                new Character()
                {
                    ID = 8,
                    Name = "Sonic the Hedgehog",
                    Game = "Sonic the Hedgehog",
                    CompanyID = 2,
                    Ability = "Very Fast",
                    Image = "./images/sonic.png"
                },

                new Character()
                {
                    ID = 9,
                    Name = "Shadow the Hedgehog",
                    Game = "Sonic Adventure 2",
                    CompanyID = 2,
                    Ability = "Choas Control",
                    Image = "./images/shadow.png"
                });

            modelBuilder.Entity<Company>().HasData(

                new Company()
                {
                    ID = 1,
                    Title = "Nintendo",
                    Location = "Japan"
                },

                new Company()
                {
                    ID = 2,
                    Title = "Sega",
                    Location = "Japan"
                });
        }
    }
}

