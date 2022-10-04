using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi.Migrations
{
    public partial class AddListaFolha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamentos_FuncionarioId",
                table: "FolhaPagamentos");

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

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamentos_FuncionarioId",
                table: "FolhaPagamentos",
                column: "FuncionarioId");
        }
    }
}
