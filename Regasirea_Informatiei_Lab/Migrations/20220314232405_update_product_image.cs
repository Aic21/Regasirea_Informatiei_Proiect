using Microsoft.EntityFrameworkCore.Migrations;

namespace Regasirea_Informatiei_Lab.Migrations
{
    public partial class update_product_image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductPicture2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductPicture3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductVideo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPicture2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductPicture3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductVideo",
                table: "Products");
        }
    }
}
