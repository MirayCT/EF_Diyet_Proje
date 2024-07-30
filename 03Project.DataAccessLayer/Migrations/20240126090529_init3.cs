using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03Project.DataAccessLayer.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "MealTimes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "UserFoods",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "UserFoods");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "MealTimes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 25, 22, 5, 9, 179, DateTimeKind.Local).AddTicks(1989));
        }
    }
}
