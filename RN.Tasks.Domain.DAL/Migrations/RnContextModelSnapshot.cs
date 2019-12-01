﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RN.Tasks.Domain.DAL;

namespace RN.Tasks.Domain.DAL.Migrations
{
    [DbContext(typeof(RnContext))]
    partial class RnContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RN.Tasks.Domain.Entities.UserTask", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("LeadTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Performer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PlannedComplexity")
                        .HasColumnType("bigint");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2019, 12, 1, 16, 56, 46, 512, DateTimeKind.Local).AddTicks(7545),
                            Description = "First task description",
                            FinishedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeadTime = 0L,
                            Name = "First task",
                            Performer = "All",
                            PlannedComplexity = 100L
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTime(2019, 12, 1, 16, 56, 46, 514, DateTimeKind.Local).AddTicks(99),
                            Description = "Second sub task description",
                            FinishedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeadTime = 0L,
                            Name = "Second task",
                            Performer = "User",
                            PlannedComplexity = 140L,
                            TaskId = 1
                        },
                        new
                        {
                            Id = 3L,
                            CreationDate = new DateTime(2019, 12, 1, 16, 56, 46, 514, DateTimeKind.Local).AddTicks(181),
                            Description = "Third task description",
                            FinishedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeadTime = 0L,
                            Name = "Third task",
                            Performer = "Admin",
                            PlannedComplexity = 999L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
