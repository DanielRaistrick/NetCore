using Microsoft.EntityFrameworkCore.Migrations;


namespace EFCorePoC.Migrations
{
    public partial class blankmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            //SqlQuery("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            //Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Blues')");
            //Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Rock')");
            //Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Country')");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Jazz" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Blues" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Rock" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Country" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
