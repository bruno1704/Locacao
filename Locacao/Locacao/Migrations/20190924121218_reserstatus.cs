using Microsoft.EntityFrameworkCore.Migrations;

namespace Locacao.Migrations
{
    public partial class reserstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusPedidoId",
                table: "Reserva",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_StatusPedidoId",
                table: "Reserva",
                column: "StatusPedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_StatusPedido_StatusPedidoId",
                table: "Reserva",
                column: "StatusPedidoId",
                principalTable: "StatusPedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_StatusPedido_StatusPedidoId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_StatusPedidoId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "StatusPedidoId",
                table: "Reserva");
        }
    }
}
