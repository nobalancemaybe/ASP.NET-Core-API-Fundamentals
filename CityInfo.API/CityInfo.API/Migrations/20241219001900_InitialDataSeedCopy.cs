using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CityInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeedCopy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The one with the cathedral that was never really finished.");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The one with that big tower.");

            migrationBuilder.UpdateData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The most visited urban park in the United States.");

            migrationBuilder.UpdateData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A 102-story skyscraper located in Midtown Manhattan.");

            migrationBuilder.UpdateData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans.");

            migrationBuilder.InsertData(
                table: "PointOfInterests",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[,]
                {
                    { 4, 2, "The the finest example of railway architecture in Belgium.", "Antwerp Central Station" },
                    { 5, 3, "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel.", "Eiffel Tower" },
                    { 6, 3, "The world's largest museum.", "The Louvre" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The one with the cathedral that was never really finished");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The one with that big tower");

            migrationBuilder.UpdateData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The most visited urban park in the United States");

            migrationBuilder.UpdateData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A 102-story skysraper located in Midtown Manhattan.");

            migrationBuilder.UpdateData(
                table: "PointOfInterests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A Gothic style cathedral, conceived by architects Jan and One");
        }
    }
}
