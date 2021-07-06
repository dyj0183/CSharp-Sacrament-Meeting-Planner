﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Data;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    partial class SacramentMeetingPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SacramentMeeting", b =>
                {
                    b.Property<int>("SacramentMeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CloseHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosePrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductLeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfMeeting")
                        .HasColumnType("datetime2");

                    b.Property<string>("MusicalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SacramentMeetingId");

                    b.ToTable("SacramentMeeting");
                });
#pragma warning restore 612, 618
        }
    }
}
