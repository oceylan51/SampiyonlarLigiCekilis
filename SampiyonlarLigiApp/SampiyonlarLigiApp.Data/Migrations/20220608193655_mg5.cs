using Microsoft.EntityFrameworkCore.Migrations;

namespace SampiyonlarLigiApp.Data.Migrations
{
    public partial class mg5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group8",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group7",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group6",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group5",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group4",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group3",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group2",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                table: "last32Group1",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group8");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group7");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group6");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group5");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group4");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group3");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group2");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "last32Group1");
        }
    }
}
