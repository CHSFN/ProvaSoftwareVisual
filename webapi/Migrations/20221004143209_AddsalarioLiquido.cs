using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi.Migrations
{
    public partial class AddsalarioLiquido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SalarioLiquido",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
                table: "FolhaPagamentos");
        }
    }
}
