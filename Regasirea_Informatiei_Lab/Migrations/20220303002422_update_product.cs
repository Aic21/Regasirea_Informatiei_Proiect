using Microsoft.EntityFrameworkCore.Migrations;

namespace Regasirea_Informatiei_Lab.Migrations
{
    public partial class update_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pret",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Products");
        }
    }
}
