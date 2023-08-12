using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bankk2.Migrations.SqliteMigrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDCard",
                table: "DataUser");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "DataUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "DataUser");

            migrationBuilder.AddColumn<int>(
                name: "IDCard",
                table: "DataUser",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
