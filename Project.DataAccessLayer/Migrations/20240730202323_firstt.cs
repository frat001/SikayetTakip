using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class firstt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sikayets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SikayetNo = table.Column<int>(type: "int", nullable: false),
                    BolgeSefligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParkIsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BakimImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SikayetImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeyazMasaNo = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sikayets", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sikayets");
        }
    }
}
