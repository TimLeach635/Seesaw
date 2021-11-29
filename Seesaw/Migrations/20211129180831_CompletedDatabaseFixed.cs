using Microsoft.EntityFrameworkCore.Migrations;

namespace Seesaw.Migrations
{
    public partial class CompletedDatabaseFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskBookings_Users_OccupierId",
                table: "DeskBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomBookings_Users_OccupierId",
                table: "MeetingRoomBookings");

            migrationBuilder.AlterColumn<int>(
                name: "OccupierId",
                table: "MeetingRoomBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookerId",
                table: "MeetingRoomBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "OccupierId",
                table: "DeskBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookerId",
                table: "DeskBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskBookings_Users_OccupierId",
                table: "DeskBookings",
                column: "OccupierId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRoomBookings_Users_OccupierId",
                table: "MeetingRoomBookings",
                column: "OccupierId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskBookings_Users_OccupierId",
                table: "DeskBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomBookings_Users_OccupierId",
                table: "MeetingRoomBookings");

            migrationBuilder.DropColumn(
                name: "BookerId",
                table: "MeetingRoomBookings");

            migrationBuilder.DropColumn(
                name: "BookerId",
                table: "DeskBookings");

            migrationBuilder.AlterColumn<int>(
                name: "OccupierId",
                table: "MeetingRoomBookings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OccupierId",
                table: "DeskBookings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskBookings_Users_OccupierId",
                table: "DeskBookings",
                column: "OccupierId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRoomBookings_Users_OccupierId",
                table: "MeetingRoomBookings",
                column: "OccupierId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
