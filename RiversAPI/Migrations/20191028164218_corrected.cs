using Microsoft.EntityFrameworkCore.Migrations;

namespace RiversAPI.Migrations
{
    public partial class corrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tribuatries",
                table: "Rivers",
                newName: "Tributaries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tributaries",
                table: "Rivers",
                newName: "Tribuatries");
        }
    }
}
