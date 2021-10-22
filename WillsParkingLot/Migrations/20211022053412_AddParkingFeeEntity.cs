using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WillsParkingLot.Migrations
{
    public partial class AddParkingFeeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingFees",
                columns: table => new
                {
                    ParkingFeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalParkingFeeCollected = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ParkingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingFees", x => x.ParkingFeeId);
                    table.ForeignKey(
                        name: "FK_ParkingFees_Parkings_ParkingId",
                        column: x => x.ParkingId,
                        principalTable: "Parkings",
                        principalColumn: "ParkingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 945, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 17,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 18,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 19,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 20,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 21,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.CreateIndex(
                name: "IX_ParkingFees_ParkingId",
                table: "ParkingFees",
                column: "ParkingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingFees");

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 755, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 17,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 18,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 19,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 20,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "RateYearsDays",
                keyColumn: "RateYearDayId",
                keyValue: 21,
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 21, 22, 58, 37, 757, DateTimeKind.Local).AddTicks(9657));
        }
    }
}
