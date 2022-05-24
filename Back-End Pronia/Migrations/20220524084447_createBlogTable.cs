using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End_Pronia.Migrations
{
    public partial class createBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminMessage = table.Column<string>(nullable: true),
                    AdminTitle = table.Column<string>(nullable: true),
                    AdminSubTitle = table.Column<string>(nullable: true),
                    AdminImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
