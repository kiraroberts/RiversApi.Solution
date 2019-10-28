using Microsoft.EntityFrameworkCore.Migrations;

namespace RiversAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rivers",
                columns: new[] { "RiverId", "Flow", "Length", "Mouth", "Name", "Source", "States", "Tributaries" },
                values: new object[] { 1, "265,000 cu ft/s ", "1,243 miles", "Pacific Ocean", "Columbia River", "Columbia Lake", "Washington, Oregon, British Columbia", "Spillimacheen River, Beaver River, Illecillewaet River, Incomappleux River, Kootenay River, Pend Oreille River, Spokane River, Crab Creek, Snake River, John Day River, Deschutes River, Willamette River, Kicking Horse River, Blaeberry River, Canoe River, Kettle River, Sanpoil River, Okanogan River, Entiat River, Wenatchee River, Yakima River, Lewis River, Cowlitz River" });

            migrationBuilder.InsertData(
                table: "Rivers",
                columns: new[] { "RiverId", "Flow", "Length", "Mouth", "Name", "Source", "States", "Tributaries" },
                values: new object[] { 2, "33,010 cu ft/s", "187 miles", "Columbia River", "Willamette River", "Coast Fork Willamette River and Middle Fork Willamette River", "Oregon", "	Coast Fork Willamette River, Long Tom River, Marys River, Luckiamute River, Yamhill River, Tualatin River, Middle Fork Willamette River, McKenzie River, Calapooia River, Santiam River, Molalla River, Clackamas River" });

            migrationBuilder.InsertData(
                table: "Rivers",
                columns: new[] { "RiverId", "Flow", "Length", "Mouth", "Name", "Source", "States", "Tributaries" },
                values: new object[] { 3, "5,824 cu ft/s", "252 miles", "Columbia River", "Deschutes River", "	Little Lava Lake", "Oregon", "Cultus River, Fall River, Little Deschutes River, Spring River, Metolius River, Crooked River, Warm Springs River, White River" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 3);
        }
    }
}
