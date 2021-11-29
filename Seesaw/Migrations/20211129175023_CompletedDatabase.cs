using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Seesaw.Migrations
{
    public partial class CompletedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomMeetingRoomAttribute_MeetingRooms_CompliantRooms~",
                table: "MeetingRoomMeetingRoomAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamReservations_Desks_DeskId",
                table: "TeamReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamReservations_Teams_TeamId",
                table: "TeamReservations");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_TeamReservations_DeskId",
                table: "TeamReservations");

            migrationBuilder.DropIndex(
                name: "IX_TeamReservations_TeamId",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "DeskId",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "BookerId",
                table: "DeskBookings");

            migrationBuilder.RenameColumn(
                name: "CompliantRoomsId",
                table: "MeetingRoomMeetingRoomAttribute",
                newName: "QualifyingRoomsId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetingRoomMeetingRoomAttribute_CompliantRoomsId",
                table: "MeetingRoomMeetingRoomAttribute",
                newName: "IX_MeetingRoomMeetingRoomAttribute_QualifyingRoomsId");

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "TeamReservations",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "TeamReservations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservedFrom",
                table: "TeamReservations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservedUntil",
                table: "TeamReservations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "TeamReservations",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OccupierId",
                table: "DeskBookings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "BookedDeskId",
                table: "DeskBookings",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookedFrom",
                table: "DeskBookings",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookedTo",
                table: "DeskBookings",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "DeskBookings",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DeskAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeskTeamReservation",
                columns: table => new
                {
                    ReservedDesksId = table.Column<int>(type: "integer", nullable: false),
                    TeamReservationsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskTeamReservation", x => new { x.ReservedDesksId, x.TeamReservationsId });
                    table.ForeignKey(
                        name: "FK_DeskTeamReservation_Desks_ReservedDesksId",
                        column: x => x.ReservedDesksId,
                        principalTable: "Desks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeskTeamReservation_TeamReservations_TeamReservationsId",
                        column: x => x.TeamReservationsId,
                        principalTable: "TeamReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "bytea", nullable: true),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    DefaultOfficeId = table.Column<int>(type: "integer", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Offices_DefaultOfficeId",
                        column: x => x.DefaultOfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeskDeskAttribute",
                columns: table => new
                {
                    AttributesId = table.Column<int>(type: "integer", nullable: false),
                    QualifyingDesksId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskDeskAttribute", x => new { x.AttributesId, x.QualifyingDesksId });
                    table.ForeignKey(
                        name: "FK_DeskDeskAttribute_DeskAttributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "DeskAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeskDeskAttribute_Desks_QualifyingDesksId",
                        column: x => x.QualifyingDesksId,
                        principalTable: "Desks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetingRoomBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: true),
                    OccupierId = table.Column<int>(type: "integer", nullable: true),
                    BookedFrom = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BookedUntil = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingRoomBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingRoomBookings_MeetingRooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "MeetingRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetingRoomBookings_Users_OccupierId",
                        column: x => x.OccupierId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamReservations_CreatorId",
                table: "TeamReservations",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskBookings_BookedDeskId",
                table: "DeskBookings",
                column: "BookedDeskId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskBookings_OccupierId",
                table: "DeskBookings",
                column: "OccupierId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDeskAttribute_QualifyingDesksId",
                table: "DeskDeskAttribute",
                column: "QualifyingDesksId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskTeamReservation_TeamReservationsId",
                table: "DeskTeamReservation",
                column: "TeamReservationsId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRoomBookings_OccupierId",
                table: "MeetingRoomBookings",
                column: "OccupierId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRoomBookings_RoomId",
                table: "MeetingRoomBookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DefaultOfficeId",
                table: "Users",
                column: "DefaultOfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskBookings_Desks_BookedDeskId",
                table: "DeskBookings",
                column: "BookedDeskId",
                principalTable: "Desks",
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
                name: "FK_MeetingRoomMeetingRoomAttribute_MeetingRooms_QualifyingRoom~",
                table: "MeetingRoomMeetingRoomAttribute",
                column: "QualifyingRoomsId",
                principalTable: "MeetingRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamReservations_Users_CreatorId",
                table: "TeamReservations",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskBookings_Desks_BookedDeskId",
                table: "DeskBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_DeskBookings_Users_OccupierId",
                table: "DeskBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRoomMeetingRoomAttribute_MeetingRooms_QualifyingRoom~",
                table: "MeetingRoomMeetingRoomAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamReservations_Users_CreatorId",
                table: "TeamReservations");

            migrationBuilder.DropTable(
                name: "DeskDeskAttribute");

            migrationBuilder.DropTable(
                name: "DeskTeamReservation");

            migrationBuilder.DropTable(
                name: "MeetingRoomBookings");

            migrationBuilder.DropTable(
                name: "DeskAttributes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_TeamReservations_CreatorId",
                table: "TeamReservations");

            migrationBuilder.DropIndex(
                name: "IX_DeskBookings_BookedDeskId",
                table: "DeskBookings");

            migrationBuilder.DropIndex(
                name: "IX_DeskBookings_OccupierId",
                table: "DeskBookings");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "ReservedFrom",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "ReservedUntil",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "TeamReservations");

            migrationBuilder.DropColumn(
                name: "BookedDeskId",
                table: "DeskBookings");

            migrationBuilder.DropColumn(
                name: "BookedFrom",
                table: "DeskBookings");

            migrationBuilder.DropColumn(
                name: "BookedTo",
                table: "DeskBookings");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "DeskBookings");

            migrationBuilder.RenameColumn(
                name: "QualifyingRoomsId",
                table: "MeetingRoomMeetingRoomAttribute",
                newName: "CompliantRoomsId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetingRoomMeetingRoomAttribute_QualifyingRoomsId",
                table: "MeetingRoomMeetingRoomAttribute",
                newName: "IX_MeetingRoomMeetingRoomAttribute_CompliantRoomsId");

            migrationBuilder.AddColumn<int>(
                name: "DeskId",
                table: "TeamReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "TeamReservations",
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

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BookedFrom = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BookedTo = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamReservations_DeskId",
                table: "TeamReservations",
                column: "DeskId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamReservations_TeamId",
                table: "TeamReservations",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRoomMeetingRoomAttribute_MeetingRooms_CompliantRooms~",
                table: "MeetingRoomMeetingRoomAttribute",
                column: "CompliantRoomsId",
                principalTable: "MeetingRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamReservations_Desks_DeskId",
                table: "TeamReservations",
                column: "DeskId",
                principalTable: "Desks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamReservations_Teams_TeamId",
                table: "TeamReservations",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
