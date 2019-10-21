using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locacao.Migrations
{
    public partial class alteracoesUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeNascimento",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Usuario");
        }
    }
}
