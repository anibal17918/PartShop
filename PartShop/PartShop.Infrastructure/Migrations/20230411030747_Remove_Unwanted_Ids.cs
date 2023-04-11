using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartShop.Infrastructure.Migrations
{
    public partial class Remove_Unwanted_Ids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Marca_MarcaId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Modelo_ModeloId",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_MarcaId",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ModeloId",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_MarcaId",
                table: "Producto",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ModeloId",
                table: "Producto",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Marca_MarcaId",
                table: "Producto",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Modelo_ModeloId",
                table: "Producto",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id");
        }
    }
}
