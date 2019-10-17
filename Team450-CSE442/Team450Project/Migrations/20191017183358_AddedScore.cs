using Microsoft.EntityFrameworkCore.Migrations;

namespace Team450Project.Migrations
{
    public partial class AddedScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Score",
                table: "ScoreBoard",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "ScoreBoard");
        }
    }
}
