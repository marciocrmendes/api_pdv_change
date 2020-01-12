using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AlterTableNameBanknoteToBanknotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sale_banknote_banknote_banknote_id",
                table: "sale_banknote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_banknote",
                table: "banknote");

            migrationBuilder.RenameTable(
                name: "banknote",
                newName: "banknotes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_banknotes",
                table: "banknotes",
                column: "id");

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
                value: new DateTime(2020, 1, 12, 11, 14, 40, 115, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 12, 11, 14, 40, 116, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.AddForeignKey(
                name: "FK_sale_banknote_banknotes_banknote_id",
                table: "sale_banknote",
                column: "banknote_id",
                principalTable: "banknotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sale_banknote_banknotes_banknote_id",
                table: "sale_banknote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_banknotes",
                table: "banknotes");

            migrationBuilder.RenameTable(
                name: "banknotes",
                newName: "banknote");

            migrationBuilder.AddPrimaryKey(
                name: "PK_banknote",
                table: "banknote",
                column: "id");

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
                value: new DateTime(2020, 1, 11, 11, 16, 2, 602, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 1, 11, 11, 16, 2, 603, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.AddForeignKey(
                name: "FK_sale_banknote_banknote_banknote_id",
                table: "sale_banknote",
                column: "banknote_id",
                principalTable: "banknote",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
