using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartShop.Infrastructure.Migrations
{
    public partial class Add_Stock_To_Producto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Producto");
        }
    }
}
