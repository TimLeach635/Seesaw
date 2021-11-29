using Microsoft.EntityFrameworkCore.Migrations;

namespace Seesaw.Migrations
{
    public partial class DatabaseRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomBookings_MeetingRooms_RoomId",
                table: "MeetingRoomBookings");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "TeamReservations",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "MeetingRoomBookings",
                newName: "BookedRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetingRoomBookings_RoomId",
                table: "MeetingRoomBookings",
                newName: "IX_MeetingRoomBookings_BookedRoomId");

            migrationBuilder.RenameColumn(
                name: "BookedTo",
                table: "DeskBookings",
                newName: "BookedUntil");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRoomBookings_MeetingRooms_BookedRoomId",
                table: "MeetingRoomBookings",
                column: "BookedRoomId",
                principalTable: "MeetingRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomBookings_MeetingRooms_BookedRoomId",
                table: "MeetingRoomBookings");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "TeamReservations",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "BookedRoomId",
                table: "MeetingRoomBookings",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetingRoomBookings_BookedRoomId",
                table: "MeetingRoomBookings",
                newName: "IX_MeetingRoomBookings_RoomId");

            migrationBuilder.RenameColumn(
                name: "BookedUntil",
                table: "DeskBookings",
                newName: "BookedTo");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRoomBookings_MeetingRooms_RoomId",
                table: "MeetingRoomBookings",
                column: "RoomId",
                principalTable: "MeetingRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
