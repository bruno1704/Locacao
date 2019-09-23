using Microsoft.EntityFrameworkCore.Migrations;

namespace Locacao.Migrations
{
    public partial class alteracaousuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Administrador",
                table: "Usuario",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Administrador",
                table: "Usuario");
        }
    }
}
