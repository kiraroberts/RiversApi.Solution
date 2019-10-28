using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RiversAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rivers",
                columns: table => new
                {
                    RiverId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    Mouth = table.Column<string>(nullable: true),
                    Flow = table.Column<string>(nullable: true),
                    States = table.Column<string>(nullable: true),
                    Tribuatries = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rivers", x => x.RiverId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rivers");
        }
    }
}
