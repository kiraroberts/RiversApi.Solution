using Microsoft.EntityFrameworkCore.Migrations;

namespace RiversAPI.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 2,
                column: "Tributaries",
                value: "Coast Fork Willamette River, Long Tom River, Marys River, Luckiamute River, Yamhill River, Tualatin River, Middle Fork Willamette River, McKenzie River, Calapooia River, Santiam River, Molalla River, Clackamas River");

            migrationBuilder.UpdateData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 3,
                column: "Source",
                value: "Little Lava Lake");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 2,
                column: "Tributaries",
                value: "	Coast Fork Willamette River, Long Tom River, Marys River, Luckiamute River, Yamhill River, Tualatin River, Middle Fork Willamette River, McKenzie River, Calapooia River, Santiam River, Molalla River, Clackamas River");

            migrationBuilder.UpdateData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 3,
                column: "Source",
                value: "	Little Lava Lake");
        }
    }
}
