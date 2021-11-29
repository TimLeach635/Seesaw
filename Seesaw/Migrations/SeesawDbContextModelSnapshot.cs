﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Seesaw;

namespace Seesaw.Migrations
{
    [DbContext(typeof(SeesawDbContext))]
    partial class SeesawDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresExtension("postgis")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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

            modelBuilder.Entity("Seesaw.Models.MeetingRoomAttributes", b =>
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

            modelBuilder.Entity("Seesaw.Models.Desk", b =>
                {
                    b.HasOne("Seesaw.Models.Unit", "ContainingUnit")
                        .WithMany()
                        .HasForeignKey("ContainingUnitId");

                    b.Navigation("ContainingUnit");
                });

            modelBuilder.Entity("Seesaw.Models.MeetingRoom", b =>
                {
                    b.HasOne("Seesaw.Models.Unit", "ContainingUnit")
                        .WithMany()
                        .HasForeignKey("ContainingUnitId");

                    b.Navigation("ContainingUnit");
                });

            modelBuilder.Entity("Seesaw.Models.Unit", b =>
                {
                    b.HasOne("Seesaw.Models.Office", "ContainingOffice")
                        .WithMany("Units")
                        .HasForeignKey("ContainingOfficeId");

                    b.Navigation("ContainingOffice");
                });

            modelBuilder.Entity("Seesaw.Models.Office", b =>
                {
                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
