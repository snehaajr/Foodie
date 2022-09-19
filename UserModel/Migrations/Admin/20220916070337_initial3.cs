using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations.Admin
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "RestaurantRequest");

            migrationBuilder.AddColumn<string>(
                name: "RestaurantName",
                table: "RestaurantRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantName",
                table: "RestaurantRequest");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "RestaurantRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
