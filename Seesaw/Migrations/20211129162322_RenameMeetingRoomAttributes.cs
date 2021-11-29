using Microsoft.EntityFrameworkCore.Migrations;

namespace Seesaw.Migrations
{
    public partial class RenameMeetingRoomAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingRoomMeetingRoomAttribute",
                columns: table => new
                {
                    AttributesId = table.Column<int>(type: "integer", nullable: false),
                    CompliantRoomsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingRoomMeetingRoomAttribute", x => new { x.AttributesId, x.CompliantRoomsId });
                    table.ForeignKey(
                        name: "FK_MeetingRoomMeetingRoomAttribute_MeetingRoomAttributes_Attri~",
                        column: x => x.AttributesId,
                        principalTable: "MeetingRoomAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingRoomMeetingRoomAttribute_MeetingRooms_CompliantRooms~",
                        column: x => x.CompliantRoomsId,
                        principalTable: "MeetingRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRoomMeetingRoomAttribute_CompliantRoomsId",
                table: "MeetingRoomMeetingRoomAttribute",
                column: "CompliantRoomsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingRoomMeetingRoomAttribute");
        }
    }
}
