using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManagement.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Education" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Sport" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CategoryId", "Name", "PhotoName", "Price", "PublishYear", "Publisher" },
                values: new object[] { 1, "Le Cong Hoang Phuc", 1, "Cach hoc lap trinh c#", "", 300000L, "2021", "Giao Duc" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CategoryId", "Name", "PhotoName", "Price", "PublishYear", "Publisher" },
                values: new object[] { 2, "Tan Ton", 1, "Cach hoc lap trinh Java", "", 900000L, "2021", "Giao Duc" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CategoryId", "Name", "PhotoName", "Price", "PublishYear", "Publisher" },
                values: new object[] { 3, "Le Cong Hoang Phuc", 2, "Cach da bong hay", "", 200000L, "2021", "Bao Bong Da" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
