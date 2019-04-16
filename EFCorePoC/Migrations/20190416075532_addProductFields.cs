using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePoC.Migrations
{
    public partial class addProductFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductGroup",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxCode",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductGroup",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TaxCode",
                table: "Products");
        }
    }
}
