﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Seesaw;

namespace Seesaw.Migrations
{
    [DbContext(typeof(SeesawDbContext))]
    [Migration("20211129182813_FullDatabaseBuild")]
    partial class FullDatabaseBuild
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresExtension("postgis")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DeskDeskAttribute", b =>
                {
                    b.Property<int>("AttributesId")
                        .HasColumnType("integer");

                    b.Property<int>("QualifyingDesksId")
                        .HasColumnType("integer");

                    b.HasKey("AttributesId", "QualifyingDesksId");

                    b.HasIndex("QualifyingDesksId");

                    b.ToTable("DeskDeskAttribute");
                });

            modelBuilder.Entity("DeskTeamReservation", b =>
                {
                    b.Property<int>("ReservedDesksId")
                        .HasColumnType("integer");

                    b.Property<int>("TeamReservationsId")
                        .HasColumnType("integer");

                    b.HasKey("ReservedDesksId", "TeamReservationsId");

                    b.HasIndex("TeamReservationsId");

                    b.ToTable("DeskTeamReservation");
                });

            modelBuilder.Entity("MeetingRoomMeetingRoomAttribute", b =>
                {
                    b.Property<int>("AttributesId")
                        .HasColumnType("integer");

                    b.Property<int>("QualifyingRoomsId")
                        .HasColumnType("integer");

                    b.HasKey("AttributesId", "QualifyingRoomsId");

                    b.HasIndex("QualifyingRoomsId");

                    b.ToTable("MeetingRoomMeetingRoomAttribute");
                });

            modelBuilder.Entity("Seesaw.Models.Desk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<Polygon>("BoundingBox")
                        .HasColumnType("geometry");

                    b.Property<int?>("ContainingUnitId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContainingUnitId");

                    b.ToTable("Desks");
                });

            modelBuilder.Entity("Seesaw.Models.DeskAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DeskAttributes");
                });

            modelBuilder.Entity("Seesaw.Models.DeskBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BookedDeskId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BookedFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("BookedTo")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("BookerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<int?>("OccupierId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookedDeskId");

                    b.HasIndex("BookerId");

                    b.HasIndex("OccupierId");

                    b.ToTable("DeskBookings");
                });

            modelBuilder.Entity("Seesaw.Models.MeetingRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<Polygon>("BoundingBox")
                        .HasColumnType("geometry");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<int?>("ContainingUnitId")
                        .HasColumnType("integer");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContainingUnitId");

                    b.ToTable("MeetingRooms");
                });

            modelBuilder.Entity("Seesaw.Models.MeetingRoomAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MeetingRoomAttributes");
                });

            modelBuilder.Entity("Seesaw.Models.MeetingRoomBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BookedFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("BookedUntil")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("BookerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<int?>("OccupierId")
                        .HasColumnType("integer");

                    b.Property<int?>("RoomId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookerId");

                    b.HasIndex("OccupierId");

                    b.HasIndex("RoomId");

                    b.ToTable("MeetingRoomBookings");
                });

            modelBuilder.Entity("Seesaw.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Seesaw.Models.TeamReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ReservedFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ReservedUntil")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TeamName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("TeamReservations");
                });

            modelBuilder.Entity("Seesaw.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ContainingOfficeId")
                        .HasColumnType("integer");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<byte[]>("FloorPlanImage")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("ContainingOfficeId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Seesaw.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DefaultOfficeId")
                        .HasColumnType("integer");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("DefaultOfficeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DeskDeskAttribute", b =>
                {
                    b.HasOne("Seesaw.Models.DeskAttribute", null)
                        .WithMany()
                        .HasForeignKey("AttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seesaw.Models.Desk", null)
                        .WithMany()
                        .HasForeignKey("QualifyingDesksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DeskTeamReservation", b =>
                {
                    b.HasOne("Seesaw.Models.Desk", null)
                        .WithMany()
                        .HasForeignKey("ReservedDesksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seesaw.Models.TeamReservation", null)
                        .WithMany()
                        .HasForeignKey("TeamReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MeetingRoomMeetingRoomAttribute", b =>
                {
                    b.HasOne("Seesaw.Models.MeetingRoomAttribute", null)
                        .WithMany()
                        .HasForeignKey("AttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seesaw.Models.MeetingRoom", null)
                        .WithMany()
                        .HasForeignKey("QualifyingRoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seesaw.Models.Desk", b =>
                {
                    b.HasOne("Seesaw.Models.Unit", "ContainingUnit")
                        .WithMany("Desks")
                        .HasForeignKey("ContainingUnitId");

                    b.Navigation("ContainingUnit");
                });

            modelBuilder.Entity("Seesaw.Models.DeskBooking", b =>
                {
                    b.HasOne("Seesaw.Models.Desk", "BookedDesk")
                        .WithMany("Bookings")
                        .HasForeignKey("BookedDeskId");

                    b.HasOne("Seesaw.Models.User", "Booker")
                        .WithMany()
                        .HasForeignKey("BookerId");

                    b.HasOne("Seesaw.Models.User", "Occupier")
                        .WithMany("DeskBookings")
                        .HasForeignKey("OccupierId");

                    b.Navigation("BookedDesk");

                    b.Navigation("Booker");

                    b.Navigation("Occupier");
                });

            modelBuilder.Entity("Seesaw.Models.MeetingRoom", b =>
                {
                    b.HasOne("Seesaw.Models.Unit", "ContainingUnit")
                        .WithMany("MeetingRooms")
                        .HasForeignKey("ContainingUnitId");

                    b.Navigation("ContainingUnit");
                });

            modelBuilder.Entity("Seesaw.Models.MeetingRoomBooking", b =>
                {
                    b.HasOne("Seesaw.Models.User", "Booker")
                        .WithMany()
                        .HasForeignKey("BookerId");

                    b.HasOne("Seesaw.Models.User", "Occupier")
                        .WithMany("MeetingRoomBookings")
                        .HasForeignKey("OccupierId");

                    b.HasOne("Seesaw.Models.MeetingRoom", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId");

                    b.Navigation("Booker");

                    b.Navigation("Occupier");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Seesaw.Models.TeamReservation", b =>
                {
                    b.HasOne("Seesaw.Models.User", "Creator")
                        .WithMany("Teams")
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Seesaw.Models.Unit", b =>
                {
                    b.HasOne("Seesaw.Models.Office", "ContainingOffice")
                        .WithMany("Units")
                        .HasForeignKey("ContainingOfficeId");

                    b.Navigation("ContainingOffice");
                });

            modelBuilder.Entity("Seesaw.Models.User", b =>
                {
                    b.HasOne("Seesaw.Models.Office", "DefaultOffice")
                        .WithMany("DefaultOccupiers")
                        .HasForeignKey("DefaultOfficeId");

                    b.Navigation("DefaultOffice");
                });

            modelBuilder.Entity("Seesaw.Models.Desk", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Seesaw.Models.MeetingRoom", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Seesaw.Models.Office", b =>
                {
                    b.Navigation("DefaultOccupiers");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Seesaw.Models.Unit", b =>
                {
                    b.Navigation("Desks");

                    b.Navigation("MeetingRooms");
                });

            modelBuilder.Entity("Seesaw.Models.User", b =>
                {
                    b.Navigation("DeskBookings");

                    b.Navigation("MeetingRoomBookings");

                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
