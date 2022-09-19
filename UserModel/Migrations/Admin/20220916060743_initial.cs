using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations.Admin
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
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
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    RestaurantId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    RestaurantId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Restaurant_RestaurantId1",
                        column: x => x.RestaurantId1,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantRequest",
                columns: table => new
                {
                    RestaurantRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isVerified = table.Column<bool>(type: "bit", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantRequest", x => x.RestaurantRequestId);
                    table.ForeignKey(
                        name: "FK_RestaurantRequest_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_RestaurantId1",
                table: "Item",
                column: "RestaurantId1");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantRequest_RestaurantId",
                table: "RestaurantRequest",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "RestaurantRequest");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
