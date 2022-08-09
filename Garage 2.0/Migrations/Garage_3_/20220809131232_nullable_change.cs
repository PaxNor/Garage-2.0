using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations.Garage_3_
{
    public partial class nullable_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parking_Vehicle_VehicleId",
                table: "Parking");

            migrationBuilder.DropIndex(
                name: "IX_Parking_VehicleId",
                table: "Parking");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Parking",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Parking_VehicleId",
                table: "Parking",
                column: "VehicleId",
                unique: true,
                filter: "[VehicleId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Parking_Vehicle_VehicleId",
                table: "Parking",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parking_Vehicle_VehicleId",
                table: "Parking");

            migrationBuilder.DropIndex(
                name: "IX_Parking_VehicleId",
                table: "Parking");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Parking",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parking_VehicleId",
                table: "Parking",
                column: "VehicleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Parking_Vehicle_VehicleId",
                table: "Parking",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
