using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewManagement.Data.Migrations
{
    public partial class AddNameToThing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Things",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Things");
        }
    }
}
