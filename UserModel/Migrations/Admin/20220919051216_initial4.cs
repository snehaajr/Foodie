using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations.Admin
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainRestaurantList",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    RestaurantOwnerEmailID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRestaurantList", x => x.RestaurantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainRestaurantList");
        }
    }
}
