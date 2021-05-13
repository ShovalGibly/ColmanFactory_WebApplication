using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_ColmanFactory.Migrations
{
    public partial class UsersDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isEditor",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "isEditor",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
