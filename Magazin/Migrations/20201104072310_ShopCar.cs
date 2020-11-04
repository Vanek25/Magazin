using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazin.Migrations
{
    public partial class ShopCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopCarItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    ShopCarId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCarItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShopCarItem_Car_carid",
                        column: x => x.carid,
                        principalTable: "Car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCarItem_carid",
                table: "ShopCarItem",
                column: "carid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCarItem");
        }
    }
}
