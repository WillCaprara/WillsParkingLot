using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WillsParkingLot.Migrations
{
    public partial class AddDataForRateYearDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RateYearsDays",
                columns: new[] { "RateYearDayId", "CarType", "DayId", "IncrementPercent", "Rate", "RegistrationDate", "YearId" },
                values: new object[,]
                {
                    { 8, 1, 1, null, 22m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, 1, 2, null, 22m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, 1, 3, null, 22m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, 1, 4, null, 22m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, 1, 5, null, 22m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, 1, 6, 15m, 22m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, 1, 7, null, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, 2, 1, null, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, 2, 2, null, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, 2, 3, null, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, 2, 4, null, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, 2, 5, null, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, 2, 6, 15m, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 21, 2, 7, null, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 21);
        }
    }
}
