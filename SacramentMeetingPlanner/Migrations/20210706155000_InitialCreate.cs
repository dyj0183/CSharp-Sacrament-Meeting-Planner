using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentMeeting",
                columns: table => new
                {
                    SacramentMeetingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfMeeting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloseHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosePrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeeting", x => x.SacramentMeetingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentMeeting");
        }
    }
}
