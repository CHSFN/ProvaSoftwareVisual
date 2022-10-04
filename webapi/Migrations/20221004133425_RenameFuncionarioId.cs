using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi.Migrations
{
    public partial class RenameFuncionarioId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Funcionarios",
                newName: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "Funcionarios",
                newName: "Id");
        }
    }
}
