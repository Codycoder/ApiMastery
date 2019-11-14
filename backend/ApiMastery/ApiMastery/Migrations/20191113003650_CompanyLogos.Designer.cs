﻿// <auto-generated />
using ApiMastery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiMastery.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20191113003650_CompanyLogos")]
    partial class CompanyLogos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiMastery.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ability");

                    b.Property<int>("CompanyID");

                    b.Property<string>("Game");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Characters");

                    b.HasData(
                        new { ID = 1, Ability = "Super Mario", CompanyID = 1, Game = "Mario Bros.", Image = "./images/mario.png", Name = "Mario" },
                        new { ID = 2, Ability = "Float", CompanyID = 1, Game = "Super Mario Bros. 2", Image = "./images/peach.png", Name = "Princess Toadstool" },
                        new { ID = 3, Ability = "Invulnerability", CompanyID = 1, Game = "Super Mario Land 2", Image = "./images/wario.png", Name = "Wario" },
                        new { ID = 4, Ability = "Throws bombs", CompanyID = 1, Game = "Super Mario Bros 2", Image = "./images/mouser.png", Name = "Mouser" },
                        new { ID = 5, Ability = "Flame Breath", CompanyID = 1, Game = "Super Mario Bros.", Image = "./images/bowser.png", Name = "Bowser" },
                        new { ID = 6, Ability = "Galactic Wand/Luma", CompanyID = 1, Game = "Super Mario Galaxy", Image = "./images/rosalina.png", Name = "Rosalina" },
                        new { ID = 7, Ability = "Reform", CompanyID = 1, Game = "Super Mario Bros. 3", Image = "./images/drybones.png", Name = "Dry Bones" },
                        new { ID = 8, Ability = "Very Fast", CompanyID = 2, Game = "Sonic the Hedgehog", Image = "./images/sonic.png", Name = "Sonic the Hedgehog" },
                        new { ID = 9, Ability = "Choas Control", CompanyID = 2, Game = "Sonic Adventure 2", Image = "./images/shadow.png", Name = "Shadow the Hedgehog" }
                    );
                });

            modelBuilder.Entity("ApiMastery.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Location");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Companies");

                    b.HasData(
                        new { ID = 1, Image = "./images/nintendo.png", Location = "Japan", Title = "Nintendo" },
                        new { ID = 2, Image = "./images/sega.jpg", Location = "Japan", Title = "Sega" }
                    );
                });

            modelBuilder.Entity("ApiMastery.Models.Character", b =>
                {
                    b.HasOne("ApiMastery.Models.Company", "company")
                        .WithMany("Characters")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}