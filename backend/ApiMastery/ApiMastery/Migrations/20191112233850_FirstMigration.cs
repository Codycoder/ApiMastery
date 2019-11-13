using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMastery.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: true),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: true),
                    Game = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Ability = table.Column<string>(nullable: true),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Characters_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "ID", "Location", "Title" },
                values: new object[] { 1, "Japan", "Nintendo" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "ID", "Location", "Title" },
                values: new object[] { 2, "Japan", "Sega" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "ID", "Ability", "CompanyID", "Game", "Image", "Name", "Profession" },
                values: new object[,]
                {
                    { 1, "Super Mario", 1, "Mario Bros.", "./images/mario.png", "Mario", null },
                    { 2, "Float", 1, "Super Mario Bros. 2", "./images/peach.png", "Princess Toadstool", null },
                    { 3, "Invulnerability", 1, "Super Mario Land 2", "./images/wario.png", "Wario", null },
                    { 4, "Throws bombs", 1, "Super Mario Bros 2", "./images/mouser.png", "Mouser", null },
                    { 5, "Flame Breath", 1, "Super Mario Bros.", "./images/bowser.png", "Bowser", null },
                    { 6, "Galactic Wand/Luma", 1, "Super Mario Galaxy", "./images/rosalina.png", "Rosalina", null },
                    { 7, "Reform", 1, "Super Mario Bros. 3", "./images/drybones.png", "Dry Bones", null },
                    { 8, "Very Fast", 2, "Sonic the Hedgehog", "./images/sonic.png", "Sonic the Hedgehog", null },
                    { 9, "Choas Control", 2, "Sonic Adventure 2", "./images/shadow.png", "Shadow the Hedgehog", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CompanyID",
                table: "Characters",
                column: "CompanyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
