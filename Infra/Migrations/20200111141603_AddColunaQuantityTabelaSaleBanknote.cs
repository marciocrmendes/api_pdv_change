using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AddColunaQuantityTabelaSaleBanknote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "sale_banknote",
                nullable: false,
                defaultValue: 1);

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

            migrationBuilder.InsertData(
                table: "sale_banknote",
                columns: new[] { "banknote_id", "sale_id", "quantity" },
                values: new object[,]
                {
                    { 6, 1, 2 },
                    { 4, 1, 5 },
                    { 3, 1, 1 }
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
                value: new DateTime(2020, 1, 11, 11, 16, 2, 602, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 11, 11, 16, 2, 603, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.CreateIndex(
                name: "IX_sale_banknote_quantity",
                table: "sale_banknote",
                column: "quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_sale_banknote_quantity",
                table: "sale_banknote");

            migrationBuilder.DeleteData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "sale_banknote",
                keyColumns: new[] { "banknote_id", "sale_id" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "sale_banknote");

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
                value: new DateTime(2020, 1, 10, 4, 19, 19, 906, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 10, 4, 19, 19, 907, DateTimeKind.Local).AddTicks(8673));
        }
    }
}
