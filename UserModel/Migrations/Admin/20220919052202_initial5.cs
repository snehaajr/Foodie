using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations.Admin
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RestaurantName",
                table: "MainRestaurantList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantName",
                table: "MainRestaurantList");
        }
    }
}
