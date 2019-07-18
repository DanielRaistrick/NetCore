using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePoC.Migrations
{
    public partial class quanUnitPrice1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Invoices",
                newName: "TotalTax");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalGross",
                table: "Invoices",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalNet",
                table: "Invoices",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalGross",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "TotalNet",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "TotalTax",
                table: "Invoices",
                newName: "UnitPrice");
        }
    }
}
