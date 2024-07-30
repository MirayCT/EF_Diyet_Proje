using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03Project.DataAccessLayer.Migrations
{
    public partial class ini5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "UserFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 28, 20, 32, 55, 516, DateTimeKind.Local).AddTicks(4044));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "UserFoods",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 26, 12, 5, 29, 441, DateTimeKind.Local).AddTicks(6558));
        }
    }
}
