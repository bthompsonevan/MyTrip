﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTrip.Models;

namespace MyTrip.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191208010344_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyTrip.Models.Trip", b =>
                {
                    b.Property<int>("TripID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TripDestination");

                    b.Property<DateTime>("TripEndDate");

                    b.Property<string>("TripName");

                    b.Property<DateTime>("TripStartDate");

                    b.Property<int?>("UserID");

                    b.HasKey("TripID");

                    b.HasIndex("UserID");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("MyTrip.Models.TripAttendee", b =>
                {
                    b.Property<int>("TripAttendeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttendeeEmail");

                    b.Property<string>("AttendeeFirstName");

                    b.Property<string>("AttendeeLastName");

                    b.Property<int?>("TripID");

                    b.HasKey("TripAttendeeID");

                    b.HasIndex("TripID");

                    b.ToTable("TripAttendees");
                });

            modelBuilder.Entity("MyTrip.Models.TripStop", b =>
                {
                    b.Property<int>("TripStopID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("StopBegin");

                    b.Property<DateTime>("StopEnd");

                    b.Property<string>("StopName");

                    b.Property<int?>("TripID");

                    b.HasKey("TripStopID");

                    b.HasIndex("TripID");

                    b.ToTable("TripStops");
                });

            modelBuilder.Entity("MyTrip.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyTrip.Models.Trip", b =>
                {
                    b.HasOne("MyTrip.Models.User")
                        .WithMany("UserTrips")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("MyTrip.Models.TripAttendee", b =>
                {
                    b.HasOne("MyTrip.Models.Trip")
                        .WithMany("TripAttendees")
                        .HasForeignKey("TripID");
                });

            modelBuilder.Entity("MyTrip.Models.TripStop", b =>
                {
                    b.HasOne("MyTrip.Models.Trip")
                        .WithMany("TripStops")
                        .HasForeignKey("TripID");
                });
#pragma warning restore 612, 618
        }
    }
}
