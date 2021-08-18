using Microsoft.EntityFrameworkCore.Migrations;

namespace Avocado_Market.Migrations
{
    public partial class Ajuste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Carrito_CarritoID",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "CarritoID",
                table: "Productos",
                newName: "CarritoId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CarritoID",
                table: "Productos",
                newName: "IX_Productos_CarritoId");

            migrationBuilder.AddColumn<int>(
                name: "ProductosId",
                table: "Ordenes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_ProductosId",
                table: "Ordenes",
                column: "ProductosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordenes_Carrito_ProductosId",
                table: "Ordenes",
                column: "ProductosId",
                principalTable: "Carrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Carrito_CarritoId",
                table: "Productos",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_Carrito_ProductosId",
                table: "Ordenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Carrito_CarritoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Ordenes_ProductosId",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "ProductosId",
                table: "Ordenes");

            migrationBuilder.RenameColumn(
                name: "CarritoId",
                table: "Productos",
                newName: "CarritoID");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CarritoId",
                table: "Productos",
                newName: "IX_Productos_CarritoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Carrito_CarritoID",
                table: "Productos",
                column: "CarritoID",
                principalTable: "Carrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        } 
    }
}
