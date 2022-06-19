using Microsoft.EntityFrameworkCore.Migrations;

namespace MK_MVC.Migrations
{
    public partial class SeededsomePeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "City", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Guápiles", "Howard Bishop", "(749) 863-3748" },
                    { 2, "Valéncia", "Derek Dixon", "(542) 246-1009" },
                    { 3, "Lauro de Freitas", "Nathan Gilbert", "1-676-671-1754" },
                    { 4, "Uberlândia", "Clementine Michael", "(385) 763-6528" },
                    { 5, "Canberra", "Elliott Carrillo", "(950) 400-6396" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 5);
        }
    }
}
