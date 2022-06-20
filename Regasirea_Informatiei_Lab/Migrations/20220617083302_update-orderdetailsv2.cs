using Microsoft.EntityFrameworkCore.Migrations;

namespace Regasirea_Informatiei_Lab.Migrations
{
    public partial class updateorderdetailsv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Metoda_Plata",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Metoda_Plata",
                table: "OrderDetails");
        }
    }
}
