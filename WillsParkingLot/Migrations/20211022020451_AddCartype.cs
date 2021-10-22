using Microsoft.EntityFrameworkCore.Migrations;

namespace WillsParkingLot.Migrations
{
    public partial class AddCartype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArrivetTime",
                table: "Parkings",
                newName: "ArriveTime");

            migrationBuilder.AddColumn<int>(
                name: "CarType",
                table: "RateYearsDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarType",
                table: "RateYearsDays");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ArriveTime",
                table: "Parkings",
                newName: "ArrivetTime");
        }
    }
}
