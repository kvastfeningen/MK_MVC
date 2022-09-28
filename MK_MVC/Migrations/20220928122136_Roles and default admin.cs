using Microsoft.EntityFrameworkCore.Migrations;

namespace MK_MVC.Migrations
{
    public partial class Rolesanddefaultadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "072f8a4b-4ea4-4ea5-9d7b-b720c14b3956", "9fb90868-61a8-41bb-99c2-a7267fe37bf0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0240ec2f-b9b4-4a70-88d9-716bdfdb0f5e", "22d4315b-8ad5-4d38-aa9d-fc2fc87a9b7b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ebb50690-dc73-4d52-90ce-adfe4687c2c0", 0, "620325", "ebd208b3-9d57-4050-95dc-1275bffaf9a1", "admin@admin.com", false, "Ad", "Min", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEDeIP/I9guNlm3vYffwsdjrVd5YRylkhzejtBQNWJNbjT9A71r+JW2FcmHqvB8AU1Q==", null, false, "45b57888-ce0a-4ec7-8ccc-7a89a5f64029", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ebb50690-dc73-4d52-90ce-adfe4687c2c0", "072f8a4b-4ea4-4ea5-9d7b-b720c14b3956" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0240ec2f-b9b4-4a70-88d9-716bdfdb0f5e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ebb50690-dc73-4d52-90ce-adfe4687c2c0", "072f8a4b-4ea4-4ea5-9d7b-b720c14b3956" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "072f8a4b-4ea4-4ea5-9d7b-b720c14b3956");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebb50690-dc73-4d52-90ce-adfe4687c2c0");
        }
    }
}
