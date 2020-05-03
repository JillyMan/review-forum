using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewManagement.Data.Migrations
{
    public partial class AddRateLikeProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThingRateInfo_Things_ThingId",
                table: "ThingRateInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThingRateInfo",
                table: "ThingRateInfo");

            migrationBuilder.RenameTable(
                name: "ThingRateInfo",
                newName: "ThingRateInfos");

            migrationBuilder.RenameIndex(
                name: "IX_ThingRateInfo_ThingId",
                table: "ThingRateInfos",
                newName: "IX_ThingRateInfos_ThingId");

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "Things",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThingRateInfos",
                table: "ThingRateInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThingRateInfos_Things_ThingId",
                table: "ThingRateInfos",
                column: "ThingId",
                principalTable: "Things",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThingRateInfos_Things_ThingId",
                table: "ThingRateInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThingRateInfos",
                table: "ThingRateInfos");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Things");

            migrationBuilder.RenameTable(
                name: "ThingRateInfos",
                newName: "ThingRateInfo");

            migrationBuilder.RenameIndex(
                name: "IX_ThingRateInfos_ThingId",
                table: "ThingRateInfo",
                newName: "IX_ThingRateInfo_ThingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThingRateInfo",
                table: "ThingRateInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThingRateInfo_Things_ThingId",
                table: "ThingRateInfo",
                column: "ThingId",
                principalTable: "Things",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
