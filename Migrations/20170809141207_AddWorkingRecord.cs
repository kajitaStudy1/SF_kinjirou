using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreSpa.Migrations
{
    public partial class AddWorkingRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkingRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClockIn = table.Column<DateTime>(nullable: true),
                    ClockOut = table.Column<DateTime>(nullable: true),
                    OverTime = table.Column<int>(nullable: true),
                    RecordeDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    WorkingTime = table.Column<int>(nullable: true),
                    WorkingType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkingRecord_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkingRecord_UserId",
                table: "WorkingRecord",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkingRecord");
        }
    }
}
