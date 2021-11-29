using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Seesaw.Migrations
{
    public partial class AddDesksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContainingUnitId",
                table: "MeetingRooms",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Desks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContainingUnitId = table.Column<int>(type: "integer", nullable: true),
                    BoundingBox = table.Column<Polygon>(type: "geometry", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desks_Units_ContainingUnitId",
                        column: x => x.ContainingUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRooms_ContainingUnitId",
                table: "MeetingRooms",
                column: "ContainingUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Desks_ContainingUnitId",
                table: "Desks",
                column: "ContainingUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRooms_Units_ContainingUnitId",
                table: "MeetingRooms",
                column: "ContainingUnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRooms_Units_ContainingUnitId",
                table: "MeetingRooms");

            migrationBuilder.DropTable(
                name: "Desks");

            migrationBuilder.DropIndex(
                name: "IX_MeetingRooms_ContainingUnitId",
                table: "MeetingRooms");

            migrationBuilder.DropColumn(
                name: "ContainingUnitId",
                table: "MeetingRooms");
        }
    }
}
