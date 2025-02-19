using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructrer.Migrations
{
    /// <inheritdoc />
    public partial class Identityrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefulte",
                table: "AspNetRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleteed",
                table: "AspNetRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefulte",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleteed",
                table: "AspNetRoles");
        }
    }
}
