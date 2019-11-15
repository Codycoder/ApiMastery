using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMastery.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 8,
                column: "Ability",
                value: "Super Speed");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 9,
                column: "Ability",
                value: "Chaos Control");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./images/sega.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 8,
                column: "Ability",
                value: "Very Fast");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 9,
                column: "Ability",
                value: "Choas Control");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./images/sega.jpg");
        }
    }
}
