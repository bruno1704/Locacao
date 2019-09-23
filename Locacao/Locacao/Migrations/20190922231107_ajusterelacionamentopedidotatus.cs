using Microsoft.EntityFrameworkCore.Migrations;

namespace Locacao.Migrations
{
    public partial class ajusterelacionamentopedidotatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatusPedido_Pedido_PedidoId",
                table: "StatusPedido");

            migrationBuilder.DropIndex(
                name: "IX_StatusPedido_PedidoId",
                table: "StatusPedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "StatusPedido");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_StatusId",
                table: "Pedido",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_StatusPedido_StatusId",
                table: "Pedido",
                column: "StatusId",
                principalTable: "StatusPedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_StatusPedido_StatusId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_StatusId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "StatusPedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatusPedido_PedidoId",
                table: "StatusPedido",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusPedido_Pedido_PedidoId",
                table: "StatusPedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
