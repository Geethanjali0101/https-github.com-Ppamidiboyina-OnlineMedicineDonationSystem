using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMedicineManagementSystem.Migrations
{
    public partial class @in : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MedicineName",
                table: "UserMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "UserMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "UserMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicineName",
                table: "UserMaster");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "UserMaster");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "UserMaster");
        }
    }
}
