using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi.Migrations
{
    public partial class AddSalario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamentos_FuncionarioId",
                table: "FolhaPagamentos");

            migrationBuilder.AddColumn<double>(
                name: "ImpostoFgts",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoInss",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoRenda",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioBruto",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamentos_FuncionarioId",
                table: "FolhaPagamentos",
                column: "FuncionarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamentos_FuncionarioId",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "ImpostoFgts",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "ImpostoInss",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "ImpostoRenda",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "SalarioBruto",
                table: "FolhaPagamentos");

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamentos_FuncionarioId",
                table: "FolhaPagamentos",
                column: "FuncionarioId");
        }
    }
}
