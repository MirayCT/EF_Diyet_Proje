using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03Project.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    MealTimeId = table.Column<int>(type: "int", nullable: false),
                    PortionSizeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoods_MealTimes_MealTimeId",
                        column: x => x.MealTimeId,
                        principalTable: "MealTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoods_PortionSizes_PortionSizeId",
                        column: x => x.PortionSizeId,
                        principalTable: "PortionSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_FoodId",
                table: "UserFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_MealTimeId",
                table: "UserFoods",
                column: "MealTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_PortionSizeId",
                table: "UserFoods",
                column: "PortionSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_UserId",
                table: "UserFoods",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFoods");

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
    }
}
