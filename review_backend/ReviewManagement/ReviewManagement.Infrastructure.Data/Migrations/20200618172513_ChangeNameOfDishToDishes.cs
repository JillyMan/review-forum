using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewManagement.Data.Migrations
{
    public partial class ChangeNameOfDishToDishes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Images_ImageId",
                table: "Dish");

            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Places_PlaceId",
                table: "Dish");

            migrationBuilder.DropForeignKey(
                name: "FK_DishRateInfos_Dish_DishId",
                table: "DishRateInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "Dishes");

            migrationBuilder.RenameIndex(
                name: "IX_Dish_PlaceId",
                table: "Dishes",
                newName: "IX_Dishes_PlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Dish_ImageId",
                table: "Dishes",
                newName: "IX_Dishes_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Images_ImageId",
                table: "Dishes",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Places_PlaceId",
                table: "Dishes",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DishRateInfos_Dishes_DishId",
                table: "DishRateInfos",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Images_ImageId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Places_PlaceId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_DishRateInfos_Dishes_DishId",
                table: "DishRateInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes");

            migrationBuilder.RenameTable(
                name: "Dishes",
                newName: "Dish");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_PlaceId",
                table: "Dish",
                newName: "IX_Dish_PlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_ImageId",
                table: "Dish",
                newName: "IX_Dish_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Images_ImageId",
                table: "Dish",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Places_PlaceId",
                table: "Dish",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DishRateInfos_Dish_DishId",
                table: "DishRateInfos",
                column: "DishId",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
