using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WillsParkingLot.Migrations
{
    public partial class RemoveRequiredForIncrementPercent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "IncrementPercent",
                table: "RateYearsDays",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "RateYearsDays",
                columns: new[] { "RateYearDayId", "CarType", "DayId", "IncrementPercent", "Rate", "RegistrationDate", "YearId" },
                values: new object[,]
                {
                    { 1, 0, 1, null, 20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 0, 2, null, 20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 0, 3, null, 20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 0, 4, null, 20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 0, 5, null, 20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 0, 6, 15m, 20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 0, 7, null, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 7);

            migrationBuilder.AlterColumn<decimal>(
                name: "IncrementPercent",
                table: "RateYearsDays",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}
