using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team450Project.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoreBoard",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usernamee = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<string>(nullable: true),
                    DateCompletion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreBoard", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreBoard");
        }
    }
}
