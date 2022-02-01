using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "customers");

            migrationBuilder.AddColumn<string>(
                name: "OrderStatus",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "customers");

            migrationBuilder.AddColumn<string>(
                name: "Order",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
