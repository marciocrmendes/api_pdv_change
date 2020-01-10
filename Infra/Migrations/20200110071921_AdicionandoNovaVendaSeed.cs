using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AdicionandoNovaVendaSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 3,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 4,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 1, 1 },
                column: "quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 2, 1 },
                column: "quantity",
                value: 3);

            migrationBuilder.InsertData(
                table: "sale_product",
                columns: new[] { "product_id", "sale_id", "quantity" },
                values: new object[,]
                {
                    { 2, 2, 1 },
                    { 3, 2, 1 },
                    { 4, 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "total" },
                values: new object[] { new DateTime(2020, 1, 10, 4, 19, 19, 906, DateTimeKind.Local).AddTicks(7548), 42.6m });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date", "total" },
                values: new object[] { new DateTime(2020, 1, 10, 4, 19, 19, 907, DateTimeKind.Local).AddTicks(8673), 29.18m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 3,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 4,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 1, 1 },
                column: "quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 2, 1 },
                column: "quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "total" },
                values: new object[] { new DateTime(2020, 1, 10, 3, 45, 59, 493, DateTimeKind.Local).AddTicks(5041), 50m });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date", "total" },
                values: new object[] { new DateTime(2020, 1, 10, 3, 45, 59, 494, DateTimeKind.Local).AddTicks(8427), 10m });
        }
    }
}
