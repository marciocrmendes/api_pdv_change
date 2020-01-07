using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AdicionandoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "name", "price" },
                values: new object[,]
                {
                    { 1, "Manteiga", 5m },
                    { 2, "Óleo de cozinha", 9.20m },
                    { 3, "Coca cola 2L", 10m },
                    { 4, "Chamito", 4.99m }
                });

            migrationBuilder.InsertData(
                table: "sales",
                columns: new[] { "id", "date", "descount", "total" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 7, 0, 47, 43, 584, DateTimeKind.Local).AddTicks(4954), 0m, 50m },
                    { 2, new DateTime(2020, 1, 7, 0, 47, 43, 584, DateTimeKind.Local).AddTicks(9521), 0m, 10m }
                });

            migrationBuilder.InsertData(
                table: "sale_product",
                columns: new[] { "product_id", "sale_id", "quantity" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 1, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "sales",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
