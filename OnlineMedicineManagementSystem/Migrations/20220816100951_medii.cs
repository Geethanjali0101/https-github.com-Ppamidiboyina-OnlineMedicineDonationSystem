using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMedicineManagementSystem.Migrations
{
    public partial class medii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicineName",
                table: "UserMaster");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "UserMaster");

            migrationBuilder.DropColumn(
                name: "Qunatity",
                table: "UserMaster");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Qunatity",
                table: "UserMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
