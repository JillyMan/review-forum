using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewManagement.Data.Migrations
{
    public partial class Add_RateInfo_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Things");

            migrationBuilder.AddColumn<string>(
                name: "UrlIImage",
                table: "Things",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ThingRateInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ThingId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Rate = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingRateInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThingRateInfo_Things_ThingId",
                        column: x => x.ThingId,
                        principalTable: "Things",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThingRateInfo_ThingId",
                table: "ThingRateInfo",
                column: "ThingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThingRateInfo");

            migrationBuilder.DropColumn(
                name: "UrlIImage",
                table: "Things");

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "Things",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
