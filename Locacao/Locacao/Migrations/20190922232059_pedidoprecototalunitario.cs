using Microsoft.EntityFrameworkCore.Migrations;

namespace Locacao.Migrations
{
    public partial class pedidoprecototalunitario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecoUnitario",
                table: "Pedido",
                newName: "Total");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Pedido",
                newName: "PrecoUnitario");
        }
    }
}
