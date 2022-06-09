using Microsoft.EntityFrameworkCore.Migrations;

namespace SampiyonlarLigiApp.Data.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fixture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Team1Name = table.Column<string>(type: "TEXT", nullable: true),
                    Team2Name = table.Column<string>(type: "TEXT", nullable: true),
                    Team1GF = table.Column<int>(type: "INTEGER", nullable: false),
                    Team2Gf = table.Column<int>(type: "INTEGER", nullable: false),
                    Result = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixture", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixture");
        }
    }
}
