using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AddIdValueGeneratedOnAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 3,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 4,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 3, 1 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 4, 1 },
                column: "quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 6, 1 },
                column: "quantity",
                value: 2);

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
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 2, 2 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 3, 2 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 4, 2 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 1, 12, 14, 58, 59, 488, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 12, 14, 58, 59, 488, DateTimeKind.Local).AddTicks(7164));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 3,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "banknotes",
                keyColumn: "id",
                keyValue: 4,
                column: "type",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 3, 1 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 4, 1 },
                column: "quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 6, 1 },
                column: "quantity",
                value: 2);

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
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 2, 2 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 3, 2 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sale_product",
                keyColumns: new[] { "product_id", "sale_id" },
                keyValues: new object[] { 4, 2 },
                column: "quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 1, 12, 14, 56, 8, 395, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 12, 14, 56, 8, 395, DateTimeKind.Local).AddTicks(5523));
        }
    }
}
