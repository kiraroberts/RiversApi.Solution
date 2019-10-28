using Microsoft.EntityFrameworkCore.Migrations;

namespace RiversAPI.Migrations
{
    public partial class imageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Rivers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 1,
                column: "ImageURL",
                value: "https://www.worldatlas.com/r/w728-h425-c728x425/upload/b0/40/ea/shutterstock-275634467.jpg");

            migrationBuilder.UpdateData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 2,
                column: "ImageURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/4/4d/USACE_Fremont_Bridge_Portland.jpg");

            migrationBuilder.UpdateData(
                table: "Rivers",
                keyColumn: "RiverId",
                keyValue: 3,
                column: "ImageURL",
                value: "https://media-cdn.tripadvisor.com/media/photo-s/0e/9d/b8/0e/the-lower-deschutes-river.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Rivers");
        }
    }
}
