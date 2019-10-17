using Microsoft.EntityFrameworkCore.Migrations;

namespace Team450Project.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCompletion",
                table: "ScoreBoard");

            migrationBuilder.AddColumn<string>(
                name: "TimeCompletion",
                table: "ScoreBoard",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeCompletion",
                table: "ScoreBoard");

            migrationBuilder.AddColumn<string>(
                name: "DateCompletion",
                table: "ScoreBoard",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
