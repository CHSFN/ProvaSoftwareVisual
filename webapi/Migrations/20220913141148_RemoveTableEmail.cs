using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi.Migrations
{
    public partial class RemoveTableEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Funcionarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Funcionarios",
                type: "TEXT",
                nullable: true);
        }
    }
}
