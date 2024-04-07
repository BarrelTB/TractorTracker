using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TractorTracker.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityBaseWithIsDeletedDeleteBehavRestricted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Worker",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Note",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Location",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chassis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    RustRating = table.Column<int>(type: "int", nullable: false),
                    LastCleaningAndLubricationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chassis_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    size = table.Column<double>(type: "float", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    NumberOfCylinders = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<int>(type: "int", nullable: false),
                    OilType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastOilChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastFilterChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engine_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentWorker",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    WorkersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentWorker", x => new { x.EquipmentId, x.WorkersId });
                    table.ForeignKey(
                        name: "FK_EquipmentWorker_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipmentWorker_Worker_WorkersId",
                        column: x => x.WorkersId,
                        principalTable: "Worker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Part_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transmission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastFluidChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastFilterChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transmission_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wheel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrakeRating = table.Column<int>(type: "int", nullable: false),
                    LastBrakeChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChassisId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wheel_Chassis_ChassisId",
                        column: x => x.ChassisId,
                        principalTable: "Chassis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    RustRating = table.Column<int>(type: "int", nullable: false),
                    WheelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rim_Wheel_WheelId",
                        column: x => x.WheelId,
                        principalTable: "Wheel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Psi = table.Column<int>(type: "int", nullable: false),
                    TreadPattern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WearRating = table.Column<int>(type: "int", nullable: false),
                    WheelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tire_Wheel_WheelId",
                        column: x => x.WheelId,
                        principalTable: "Wheel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Note_ChassisId",
                table: "Note",
                column: "ChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_EngineId",
                table: "Note",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_EquipmentId",
                table: "Note",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_PartId",
                table: "Note",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_RimId",
                table: "Note",
                column: "RimId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_TireId",
                table: "Note",
                column: "TireId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_TransmissionId",
                table: "Note",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_WheelId",
                table: "Note",
                column: "WheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_EquipmentId",
                table: "Chassis",
                column: "EquipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engine_EquipmentId",
                table: "Engine",
                column: "EquipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_LocationId",
                table: "Equipment",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UserId",
                table: "Equipment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentWorker_WorkersId",
                table: "EquipmentWorker",
                column: "WorkersId");

            migrationBuilder.CreateIndex(
                name: "IX_Part_EquipmentId",
                table: "Part",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rim_WheelId",
                table: "Rim",
                column: "WheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tire_WheelId",
                table: "Tire",
                column: "WheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_EquipmentId",
                table: "Transmission",
                column: "EquipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wheel_ChassisId",
                table: "Wheel",
                column: "ChassisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Chassis_ChassisId",
                table: "Note",
                column: "ChassisId",
                principalTable: "Chassis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Engine_EngineId",
                table: "Note",
                column: "EngineId",
                principalTable: "Engine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Equipment_EquipmentId",
                table: "Note",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Part_PartId",
                table: "Note",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Rim_RimId",
                table: "Note",
                column: "RimId",
                principalTable: "Rim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Tire_TireId",
                table: "Note",
                column: "TireId",
                principalTable: "Tire",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Transmission_TransmissionId",
                table: "Note",
                column: "TransmissionId",
                principalTable: "Transmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Wheel_WheelId",
                table: "Note",
                column: "WheelId",
                principalTable: "Wheel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Chassis_ChassisId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Engine_EngineId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Equipment_EquipmentId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Part_PartId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Rim_RimId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Tire_TireId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Transmission_TransmissionId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Wheel_WheelId",
                table: "Note");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "EquipmentWorker");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Rim");

            migrationBuilder.DropTable(
                name: "Tire");

            migrationBuilder.DropTable(
                name: "Transmission");

            migrationBuilder.DropTable(
                name: "Wheel");

            migrationBuilder.DropTable(
                name: "Chassis");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Note_ChassisId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_EngineId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_EquipmentId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_PartId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_RimId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_TireId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_TransmissionId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_WheelId",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Worker");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Location");
        }
    }
}
