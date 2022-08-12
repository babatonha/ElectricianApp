using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Data.Migrations
{
    public partial class fifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ElectricJobs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateAttended = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricJobs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ElectricJobs_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobImages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectricJobID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JobImages_ElectricJobs_ElectricJobID",
                        column: x => x.ElectricJobID,
                        principalTable: "ElectricJobs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectricJobs_JobTypeId",
                table: "ElectricJobs",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobImages_ElectricJobID",
                table: "JobImages",
                column: "ElectricJobID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobImages");

            migrationBuilder.DropTable(
                name: "ElectricJobs");

            migrationBuilder.DropTable(
                name: "JobTypes");
        }
    }
}
