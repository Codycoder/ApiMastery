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
        public DbSet<Profession> Profesions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ArtistDB;Trusted_Connection=True;";

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
                Name = "",
                ProfessionID = 1,
                Ability = "",
                Image = ""
            });

        }
    }
