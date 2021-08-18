using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avocado_Market.Migrations
{
    public partial class SinBytes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "PaginasSlider");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Productos",
                type: "BLOB",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "PaginasSlider",
                type: "BLOB",
                nullable: true);
        }
    }
}
