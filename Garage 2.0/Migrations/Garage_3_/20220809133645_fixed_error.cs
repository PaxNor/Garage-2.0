using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations.Garage_3_
{
    public partial class fixed_error : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_Vehicle_VehicleId",
                table: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleType_VehicleId",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "VehicleType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "VehicleType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_VehicleId",
                table: "VehicleType",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_Vehicle_VehicleId",
                table: "VehicleType",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id");
        }
    }
}
