using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePoC.Migrations
{
    public partial class quanUnitPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_CustomerId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_ProductId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Invoices",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Invoices",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_ProductId",
                table: "Invoices",
                newName: "IX_Invoices_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                newName: "IX_Invoices_customerId");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "customerId",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "Invoices",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Invoices",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customers_customerId",
                table: "Invoices",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Products_productId",
                table: "Invoices",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_customerId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_productId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Invoices",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Invoices",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_productId",
                table: "Invoices",
                newName: "IX_Invoices_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_customerId",
                table: "Invoices",
                newName: "IX_Invoices_CustomerId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Invoices",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Invoices",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
