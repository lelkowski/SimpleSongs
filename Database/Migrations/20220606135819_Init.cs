using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 1, "The Dark Side of the Moon", "Pink Floyd", 3.5800000000000001, "Speak to Me" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 2, "Bad", "Michael Jackson", 3.5800000000000001, "Bad" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 3, "Bad", "Michael Jackson", 3.5800000000000001, "Speed Demon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
