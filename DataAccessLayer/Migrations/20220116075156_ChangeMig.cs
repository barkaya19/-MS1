using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class ChangeMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_CustomerId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_books_CustomerId",
                table: "books",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
