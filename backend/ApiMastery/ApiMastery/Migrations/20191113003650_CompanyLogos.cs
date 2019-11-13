using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMastery.Migrations
{
    public partial class CompanyLogos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Characters");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Companies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./images/nintendo.png");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./images/sega.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Characters",
                nullable: true);
        }
    }
}
