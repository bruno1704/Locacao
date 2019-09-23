using Microsoft.EntityFrameworkCore.Migrations;

namespace Locacao.Migrations
{
    public partial class veiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorHora",
                table: "Veiculo",
                newName: "ValorDiaria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorDiaria",
                table: "Veiculo",
                newName: "ValorHora");
        }
    }
}
