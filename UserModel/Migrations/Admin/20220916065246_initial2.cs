using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations.Admin
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantRequest_Restaurant_RestaurantId",
                table: "RestaurantRequest");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantRequest_RestaurantId",
                table: "RestaurantRequest");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RestaurantRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "RestaurantRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "RestaurantRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RestaurantOwnerEmailID",
                table: "RestaurantRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "RestaurantRequest");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "RestaurantRequest");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RestaurantRequest");

            migrationBuilder.DropColumn(
                name: "RestaurantOwnerEmailID",
                table: "RestaurantRequest");

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    RestaurantOwnerEmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false)
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
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RestaurantId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId1 = table.Column<int>(type: "int", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantRequest_RestaurantId",
                table: "RestaurantRequest",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_RestaurantId1",
                table: "Item",
                column: "RestaurantId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantRequest_Restaurant_RestaurantId",
                table: "RestaurantRequest",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
