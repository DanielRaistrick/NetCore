using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePoC.Migrations
{
    public partial class addingCustomerTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ContactFirstName",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ContactLastName",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "CustomerName");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Invoices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductId",
                table: "Invoices",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customers_CustomerId",
                table: "Invoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Products_ProductId",
                table: "Invoices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_CustomerId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_ProductId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ProductId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Customers",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactFirstName",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactLastName",
                table: "Invoices",
                nullable: true);
        }
    }
}
