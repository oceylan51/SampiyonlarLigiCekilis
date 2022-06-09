using Microsoft.EntityFrameworkCore.Migrations;

namespace SampiyonlarLigiApp.Data.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TemaCountry = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TemaCountry = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TemaCountry = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TemaCountry = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group5",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group6",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group7",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "last32Group8",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamCountry = table.Column<string>(type: "TEXT", nullable: true),
                    TeamPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsFor = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamGoalsAgainst = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalDifference = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_last32Group8", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group1");

            migrationBuilder.DropTable(
                name: "Group2");

            migrationBuilder.DropTable(
                name: "Group3");

            migrationBuilder.DropTable(
                name: "Group4");

            migrationBuilder.DropTable(
                name: "last32Group1");

            migrationBuilder.DropTable(
                name: "last32Group2");

            migrationBuilder.DropTable(
                name: "last32Group3");

            migrationBuilder.DropTable(
                name: "last32Group4");

            migrationBuilder.DropTable(
                name: "last32Group5");

            migrationBuilder.DropTable(
                name: "last32Group6");

            migrationBuilder.DropTable(
                name: "last32Group7");

            migrationBuilder.DropTable(
                name: "last32Group8");
        }
    }
}
