using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructrer.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "IsDefulte", "IsDeleteed", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, false, false, "User", "USER" },
                    { "2", null, false, false, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "94e3b7c6-4bb1-43ec-b62a-eba3e1fb60b5", "user@bishyaka.com", true, "User", "", false, null, "user@bishyaka.com", "user@bishyaka.com", "+5e07borWQ==", "", false, "c320fe40-43f1-478f-a147-8e9dd9e86027", false, "user@bishyaka.com" },
                    { "2", 0, "833944c9-8cba-4355-a237-5af640e5364d", "admin@bishyaka.com", true, "Admin", "", false, null, "admin@bishyaka.com", "admin@bishyaka.com", "+5e07borWQ==", "", false, "0e4a995f-04ce-4c44-84f6-d0d9e972c13e", false, "admin@bishyaka.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
