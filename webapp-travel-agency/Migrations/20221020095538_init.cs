using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp_travel_agency.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Travelpackeges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travelpackeges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationTravelpackege",
                columns: table => new
                {
                    LocationsId = table.Column<int>(type: "int", nullable: false),
                    TravelpackesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTravelpackege", x => new { x.LocationsId, x.TravelpackesId });
                    table.ForeignKey(
                        name: "FK_LocationTravelpackege_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationTravelpackege_Travelpackeges_TravelpackesId",
                        column: x => x.TravelpackesId,
                        principalTable: "Travelpackeges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationTravelpackege_TravelpackesId",
                table: "LocationTravelpackege",
                column: "TravelpackesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationTravelpackege");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Travelpackeges");
        }
    }
}
