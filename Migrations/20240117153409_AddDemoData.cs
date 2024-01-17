using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoeStore.Migrations
{
    /// <inheritdoc />
    public partial class AddDemoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "TREZIOD");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "HANDBALL");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "CL");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "BB 4000");

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "CollectionTypeId", "ColorId", "ModelId", "Price", "SeasonId", "ShoeTypeId", "SizeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1200.0, 2, 1, 27 },
                    { 2, 1, 1, 1, 1250.0, 2, 1, 28 },
                    { 3, 1, 2, 1, 1300.0, 2, 1, 29 },
                    { 4, 1, 2, 2, 1100.0, 2, 1, 28 },
                    { 5, 1, 2, 2, 1100.0, 2, 1, 26 },
                    { 6, 1, 1, 2, 1100.0, 2, 1, 27 },
                    { 7, 1, 1, 3, 1400.0, 2, 1, 26 },
                    { 8, 1, 2, 3, 1400.0, 2, 1, 27 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "AdidasModel1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "AdidasModel2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "ReebokModel1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "ReebokModel2");
        }
    }
}
