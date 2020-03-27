using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicService.Migrations
{
    public partial class NewShopCartItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "ShopCartItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "ShopCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
