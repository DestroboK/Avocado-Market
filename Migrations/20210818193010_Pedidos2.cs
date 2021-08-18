using Microsoft.EntityFrameworkCore.Migrations;

namespace Avocado_Market.Migrations
{
    public partial class Pedidos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsPedido_Ordenes_OrdenId",
                table: "ItemsPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsPedido",
                table: "ItemsPedido");

            migrationBuilder.RenameTable(
                name: "ItemsPedido",
                newName: "ItemsOrden");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsPedido_OrdenId",
                table: "ItemsOrden",
                newName: "IX_ItemsOrden_OrdenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsOrden",
                table: "ItemsOrden",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsOrden_Ordenes_OrdenId",
                table: "ItemsOrden",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsOrden_Ordenes_OrdenId",
                table: "ItemsOrden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsOrden",
                table: "ItemsOrden");

            migrationBuilder.RenameTable(
                name: "ItemsOrden",
                newName: "ItemsPedido");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsOrden_OrdenId",
                table: "ItemsPedido",
                newName: "IX_ItemsPedido_OrdenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsPedido",
                table: "ItemsPedido",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsPedido_Ordenes_OrdenId",
                table: "ItemsPedido",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
