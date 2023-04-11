using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartShop.Infrastructure.Migrations
{
    public partial class Add_Ano_To_Producto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Producto");
        }
    }
}
