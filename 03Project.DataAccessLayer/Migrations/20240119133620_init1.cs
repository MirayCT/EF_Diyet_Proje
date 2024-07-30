using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03Project.DataAccessLayer.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Foods",
                type: "varbinary(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MealTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PortionSizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
