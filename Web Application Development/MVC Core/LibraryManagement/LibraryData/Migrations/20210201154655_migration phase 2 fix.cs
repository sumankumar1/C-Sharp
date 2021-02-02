using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class migrationphase2fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Directory",
                table: "LibraryAssets");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "LibraryAssets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "LibraryAssets");

            migrationBuilder.AddColumn<string>(
                name: "Directory",
                table: "LibraryAssets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
