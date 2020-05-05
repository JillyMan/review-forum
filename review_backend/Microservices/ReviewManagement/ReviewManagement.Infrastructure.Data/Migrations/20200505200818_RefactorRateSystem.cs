using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewManagement.Data.Migrations
{
    public partial class RefactorRateSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaceRateInfos_Dish_DishId",
                table: "PlaceRateInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceRateInfos_Places_PlaceId",
                table: "PlaceRateInfos");

            migrationBuilder.DropIndex(
                name: "IX_PlaceRateInfos_DishId",
                table: "PlaceRateInfos");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "PlaceRateInfos");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceId",
                table: "PlaceRateInfos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DishRateInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Rate = table.Column<float>(nullable: false),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishRateInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DishRateInfos_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishRateInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishRateInfos_DishId",
                table: "DishRateInfos",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishRateInfos_UserId",
                table: "DishRateInfos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceRateInfos_Places_PlaceId",
                table: "PlaceRateInfos",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaceRateInfos_Places_PlaceId",
                table: "PlaceRateInfos");

            migrationBuilder.DropTable(
                name: "DishRateInfos");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceId",
                table: "PlaceRateInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "PlaceRateInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceRateInfos_DishId",
                table: "PlaceRateInfos",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceRateInfos_Dish_DishId",
                table: "PlaceRateInfos",
                column: "DishId",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceRateInfos_Places_PlaceId",
                table: "PlaceRateInfos",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
