using Microsoft.EntityFrameworkCore.Migrations;

namespace Votevent.Web.Migrations
{
    public partial class InitialDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Candidates",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
