using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewManagement.Data.Migrations
{
    public partial class ChangeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "HeaderImage");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "HeaderImage",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "HeaderImage");

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "HeaderImage",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
