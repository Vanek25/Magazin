using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazin.Migrations
{
    public partial class ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShopCarId",
                table: "ShopCarItem");

            migrationBuilder.AddColumn<string>(
                name: "ShopCartId",
                table: "ShopCarItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShopCartId",
                table: "ShopCarItem");

            migrationBuilder.AddColumn<string>(
                name: "ShopCarId",
                table: "ShopCarItem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
