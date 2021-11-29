using Microsoft.EntityFrameworkCore.Migrations;

namespace Seesaw.Migrations
{
    public partial class FullDatabaseBuild : Migration
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
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BookerId",
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

            migrationBuilder.AlterColumn<int>(
                name: "BookerId",
                table: "DeskBookings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRoomBookings_BookerId",
                table: "MeetingRoomBookings",
                column: "BookerId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskBookings_BookerId",
                table: "DeskBookings",
                column: "BookerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskBookings_Users_BookerId",
                table: "DeskBookings",
                column: "BookerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskBookings_Users_OccupierId",
                table: "DeskBookings",
                column: "OccupierId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRoomBookings_Users_BookerId",
                table: "MeetingRoomBookings",
                column: "BookerId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskBookings_Users_BookerId",
                table: "DeskBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_DeskBookings_Users_OccupierId",
                table: "DeskBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomBookings_Users_BookerId",
                table: "MeetingRoomBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomBookings_Users_OccupierId",
                table: "MeetingRoomBookings");

            migrationBuilder.DropIndex(
                name: "IX_MeetingRoomBookings_BookerId",
                table: "MeetingRoomBookings");

            migrationBuilder.DropIndex(
                name: "IX_DeskBookings_BookerId",
                table: "DeskBookings");

            migrationBuilder.AlterColumn<int>(
                name: "OccupierId",
                table: "MeetingRoomBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookerId",
                table: "MeetingRoomBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OccupierId",
                table: "DeskBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookerId",
                table: "DeskBookings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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
    }
}
