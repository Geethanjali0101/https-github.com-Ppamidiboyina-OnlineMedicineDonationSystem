using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMedicineManagementSystem.Migrations
{
    public partial class M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EXPDate",
                table: "MedicinesMaster");

            migrationBuilder.DropColumn(
                name: "MFDDate",
                table: "MedicinesMaster");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EXPDate",
                table: "MedicinesMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MFDDate",
                table: "MedicinesMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
