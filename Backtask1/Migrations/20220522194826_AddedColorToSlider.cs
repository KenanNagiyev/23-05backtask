using Microsoft.EntityFrameworkCore.Migrations;

namespace Backtask1.Migrations
{
    public partial class AddedColorToSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Sliders");
        }
    }
}
