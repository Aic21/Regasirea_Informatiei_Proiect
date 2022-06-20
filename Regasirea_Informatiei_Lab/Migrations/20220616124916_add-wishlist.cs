using Microsoft.EntityFrameworkCore.Migrations;

namespace Regasirea_Informatiei_Lab.Migrations
{
    public partial class addwishlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WishlistCartItems",
                columns: table => new
                {
                    WhishlistItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhishlistId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdusProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistCartItems", x => x.WhishlistItemId);
                    table.ForeignKey(
                        name: "FK_WishlistCartItems_Products_ProdusProductId",
                        column: x => x.ProdusProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WishlistCartItems_ProdusProductId",
                table: "WishlistCartItems",
                column: "ProdusProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WishlistCartItems");
        }
    }
}
