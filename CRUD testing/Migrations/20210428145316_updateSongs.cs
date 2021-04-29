using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_testing.Migrations
{
    public partial class updateSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "songArtist",
                table: "Songs",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "songArtist",
                table: "Songs");
        }
    }
}
