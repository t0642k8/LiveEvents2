using Microsoft.EntityFrameworkCore.Migrations;

namespace liveevents2.Data.Migrations
{
    public partial class live1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventPlace = table.Column<string>(nullable: true),
                    EventTitle = table.Column<string>(nullable: true),
                    EventLink = table.Column<string>(nullable: true),
                    EventDate = table.Column<string>(nullable: true),
                    EventSTime = table.Column<string>(nullable: true),
                    EventETime = table.Column<string>(nullable: true),
                    EventCenter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
