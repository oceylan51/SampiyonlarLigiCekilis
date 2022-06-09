using Microsoft.EntityFrameworkCore.Migrations;

namespace SampiyonlarLigiApp.Data.Migrations
{
    public partial class mg4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
