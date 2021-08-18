using Microsoft.EntityFrameworkCore.Migrations;

namespace Avocado_Market.Migrations
{
    public partial class Pedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_Carrito_ProductosId",
                table: "Ordenes");

            migrationBuilder.DropIndex(
                name: "IX_Ordenes_ProductosId",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "ProductosId",
                table: "Ordenes");

            migrationBuilder.CreateTable(
                name: "ItemsPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioUnidad = table.Column<double>(type: "REAL", nullable: false),
                    UrlImagen = table.Column<string>(type: "TEXT", nullable: true),
                    Unidades = table.Column<int>(type: "INTEGER", nullable: false),
                    OrdenId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsPedido_Ordenes_OrdenId",
                        column: x => x.OrdenId,
                        principalTable: "Ordenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPedido_OrdenId",
                table: "ItemsPedido",
                column: "OrdenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsPedido");

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
        }
    }
}
