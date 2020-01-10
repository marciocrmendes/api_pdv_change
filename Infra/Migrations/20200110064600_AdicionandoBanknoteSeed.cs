using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AdicionandoBanknoteSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "value",
                table: "banknote",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "banknote",
                columns: new[] { "id", "type", "value" },
                values: new object[,]
                {
                    { 1, (short)1, 0.01m },
                    { 2, (short)1, 0.05m },
                    { 3, (short)1, 0.10m },
                    { 4, (short)1, 0.50m }
                });

            migrationBuilder.InsertData(
                table: "banknote",
                columns: new[] { "id", "value" },
                values: new object[,]
                {
                    { 5, 10m },
                    { 6, 20m },
                    { 7, 50m },
                    { 8, 100m }
                });

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
                column: "date",
                value: new DateTime(2020, 1, 10, 3, 45, 59, 493, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 10, 3, 45, 59, 494, DateTimeKind.Local).AddTicks(8427));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "banknote",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.AlterColumn<int>(
                name: "value",
                table: "banknote",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal));

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
                column: "date",
                value: new DateTime(2020, 1, 7, 0, 47, 43, 584, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 7, 0, 47, 43, 584, DateTimeKind.Local).AddTicks(9521));
        }
    }
}
