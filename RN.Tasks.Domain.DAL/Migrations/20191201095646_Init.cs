using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RN.Tasks.Domain.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Performer = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    FinishedDate = table.Column<DateTime>(nullable: false),
                    PlannedComplexity = table.Column<long>(nullable: false),
                    LeadTime = table.Column<long>(nullable: false),
                    TaskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreationDate", "Description", "FinishedDate", "LeadTime", "Name", "Performer", "PlannedComplexity", "TaskId" },
                values: new object[] { 1L, new DateTime(2019, 12, 1, 16, 56, 46, 512, DateTimeKind.Local).AddTicks(7545), "First task description", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "First task", "All", 100L, null });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreationDate", "Description", "FinishedDate", "LeadTime", "Name", "Performer", "PlannedComplexity", "TaskId" },
                values: new object[] { 2L, new DateTime(2019, 12, 1, 16, 56, 46, 514, DateTimeKind.Local).AddTicks(99), "Second sub task description", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "Second task", "User", 140L, 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreationDate", "Description", "FinishedDate", "LeadTime", "Name", "Performer", "PlannedComplexity", "TaskId" },
                values: new object[] { 3L, new DateTime(2019, 12, 1, 16, 56, 46, 514, DateTimeKind.Local).AddTicks(181), "Third task description", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "Third task", "Admin", 999L, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
