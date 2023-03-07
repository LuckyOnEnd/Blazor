using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazzorFullStack.Server.Migrations
{
    public partial class newSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CategoryId", "Model", "Price" },
                values: new object[] { 3, "BMW", 1, "M7", 200000m });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CarType", "Url" },
                values: new object[] { 3, "SUV", "suv" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CategoryId", "Model", "Price" },
                values: new object[] { 4, "BMW", 3, "X7", 210000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
