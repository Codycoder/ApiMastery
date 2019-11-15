using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMastery.Migrations
{
    public partial class ColorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Characters",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 1,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 2,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 3,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 4,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 5,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 6,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 7,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 8,
                column: "Color",
                value: "rgb(24, 58, 207)");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 9,
                column: "Color",
                value: "rgb(24, 58, 207)");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 1,
                column: "Color",
                value: "rgb(180, 53, 6)");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2,
                column: "Color",
                value: "rgb(24, 58, 207)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Characters");
        }
    }
}
