using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03Project.DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 25, 21, 0, 17, 379, DateTimeKind.Local).AddTicks(9128));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 19, 16, 36, 19, 781, DateTimeKind.Local).AddTicks(6697));
        }
    }
}
