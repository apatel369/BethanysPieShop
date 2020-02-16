using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class NotesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notesy",
                table: "Pies");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Pies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Pies");

            migrationBuilder.AddColumn<string>(
                name: "Notesy",
                table: "Pies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
