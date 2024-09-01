using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Magnum.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GerichtData",
                columns: table => new
                {
                    GerichtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerichtData", x => x.GerichtId);
                });

            migrationBuilder.CreateTable(
                name: "ZutatData",
                columns: table => new
                {
                    ZutatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ZutatName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brennwert = table.Column<double>(type: "float", nullable: false),
                    Eiweiß = table.Column<double>(type: "float", nullable: false),
                    Kohlenhydrat = table.Column<double>(type: "float", nullable: false),
                    Fett = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZutatData", x => x.ZutatId);
                });

            migrationBuilder.CreateTable(
                name: "ZutatenBeigaben",
                columns: table => new
                {
                    ZutatenId = table.Column<int>(type: "int", nullable: false),
                    GerichtId = table.Column<int>(type: "int", nullable: false),
                    Menge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZutatenBeigaben", x => new { x.ZutatenId, x.GerichtId });
                });

            migrationBuilder.InsertData(
                table: "GerichtData",
                columns: new[] { "GerichtId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Backofen-Fisch", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, "Gebackene Bohnen und Kichererbsennudeln", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, "Brot mit körnigem Frischkäse", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, "Eine Banane", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, "Ein Bueno", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, "Gebackene Bohnen in Tomatensoße", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, "Suppe mit Tortellini", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, "Haferflocken mit Milch", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, "Rührei", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, "Handvoll Mandeln", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, "Kartoffelbrei", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ZutatData",
                columns: new[] { "ZutatId", "Brennwert", "Eiweiß", "Fett", "Kohlenhydrat", "UserId", "ZutatName" },
                values: new object[,]
                {
                    { 1, 232.79999999999998, 15.239999999999998, 10.319999999999999, 19.32, new Guid("00000000-0000-0000-0000-000000000000"), "Backofenfisch" },
                    { 2, 546.0, 33.0, 9.0, 76.5, new Guid("00000000-0000-0000-0000-000000000000"), "Kichererbsennudeln" },
                    { 3, 170.0, 10.0, 1.0, 28.0, new Guid("00000000-0000-0000-0000-000000000000"), "Gebackene Bohnen" },
                    { 4, 2587.5, 112.5, 15.0, 472.5, new Guid("00000000-0000-0000-0000-000000000000"), "Dinkelvollkornmehl" },
                    { 5, 883.80000000000007, 46.800000000000004, 46.800000000000004, 63.0, new Guid("00000000-0000-0000-0000-000000000000"), "Sonnenblumenkerne" },
                    { 6, 267.0, 9.0, 21.0, 14.5, new Guid("00000000-0000-0000-0000-000000000000"), "Leinsamen" },
                    { 7, 35.850000000000001, 0.045000000000000005, 4.0499999999999998, 0.005000000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "Butter" },
                    { 8, 46.0, 6.5, 2.0, 0.5, new Guid("00000000-0000-0000-0000-000000000000"), "Körniger Frischkäse" },
                    { 9, 111.59999999999999, 1.3799999999999999, 0.23999999999999999, 27.599999999999998, new Guid("00000000-0000-0000-0000-000000000000"), "Banane" },
                    { 10, 125.84, 1.8919999999999999, 8.2059999999999995, 10.890000000000001, new Guid("00000000-0000-0000-0000-000000000000"), "Kinder Bueno" },
                    { 11, 696.0, 31.5, 15.0, 105.0, new Guid("00000000-0000-0000-0000-000000000000"), "Gefüllte Tortellini" },
                    { 12, 44.200000000000003, 0.0, 5.0, 0.0, new Guid("00000000-0000-0000-0000-000000000000"), "Öl" },
                    { 13, 8.2000000000000011, 1.0, 0.0, 0.57999999999999996, new Guid("00000000-0000-0000-0000-000000000000"), "Sojasoße" },
                    { 14, 339.0, 12.5, 6.5, 55.0, new Guid("00000000-0000-0000-0000-000000000000"), "Haferflocken" },
                    { 15, 115.2, 5.9399999999999995, 6.2999999999999998, 8.6400000000000006, new Guid("00000000-0000-0000-0000-000000000000"), "Milch" },
                    { 16, 90.0, 7.5, 6.5999999999999996, 0.41999999999999998, new Guid("00000000-0000-0000-0000-000000000000"), "Ei" },
                    { 17, 611.0, 24.0, 53.0, 5.7000000000000002, new Guid("00000000-0000-0000-0000-000000000000"), "Mandeln" },
                    { 18, 552.0, 16.0, 0.0, 112.0, new Guid("00000000-0000-0000-0000-000000000000"), "Kartoffeln" }
                });

            migrationBuilder.InsertData(
                table: "ZutatenBeigaben",
                columns: new[] { "GerichtId", "ZutatenId", "Menge" },
                values: new object[,]
                {
                    { 1, 1, 100 },
                    { 2, 2, 100 },
                    { 2, 3, 100 },
                    { 6, 3, 100 },
                    { 3, 4, 5 },
                    { 3, 5, 5 },
                    { 3, 6, 5 },
                    { 3, 7, 100 },
                    { 9, 7, 100 },
                    { 11, 7, 100 },
                    { 3, 8, 100 },
                    { 4, 9, 100 },
                    { 5, 10, 100 },
                    { 7, 11, 100 },
                    { 7, 12, 100 },
                    { 7, 13, 100 },
                    { 8, 14, 100 },
                    { 8, 15, 100 },
                    { 11, 15, 100 },
                    { 9, 16, 100 },
                    { 10, 17, 100 },
                    { 11, 18, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GerichtData");

            migrationBuilder.DropTable(
                name: "ZutatData");

            migrationBuilder.DropTable(
                name: "ZutatenBeigaben");
        }
    }
}
