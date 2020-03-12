using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PC.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserScores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: true),
                    EvaCount = table.Column<int>(nullable: false),
                    EvaCost = table.Column<int>(nullable: false),
                    NewtonCount = table.Column<int>(nullable: false),
                    NewtonCost = table.Column<int>(nullable: false),
                    JobsCount = table.Column<int>(nullable: false),
                    JobsCost = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserScores");
        }
    }
}
