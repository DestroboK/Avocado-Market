using Microsoft.EntityFrameworkCore.Migrations;

namespace Avocado_Market.Migrations
{
    public partial class Ajuste1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Ordenes");

            migrationBuilder.AddColumn<int>(
                name: "CarritoID",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdenId",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CarritoID",
                table: "Productos",
                column: "CarritoID");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_OrdenId",
                table: "Productos",
                column: "OrdenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Carrito_CarritoID",
                table: "Productos",
                column: "CarritoID",
                principalTable: "Carrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Ordenes_OrdenId",
                table: "Productos",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Carrito_CarritoID",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ordenes_OrdenId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CarritoID",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_OrdenId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CarritoID",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "OrdenId",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Ordenes",
                type: "TEXT",
                nullable: true);
        }
    }
}
