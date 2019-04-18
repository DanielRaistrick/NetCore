using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePoC.Migrations
{
    public partial class removeProductCodeFromInvoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "Invoices");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "Invoices",
                nullable: true);
        }
    }
}
