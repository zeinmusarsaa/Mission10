using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission10_Zein.Migrations
{
    /// <inheritdoc />
    public partial class firstOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "nvarchar (50)", nullable: false),
                    CaptainID = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BowlerLastName = table.Column<string>(type: "nvarchar (50)", nullable: true),
                    BowlerFirstName = table.Column<string>(type: "nvarchar (50)", nullable: true),
                    BowlerMiddleInit = table.Column<string>(type: "nvarchar (1)", nullable: true),
                    BowlerAddress = table.Column<string>(type: "nvarchar (50)", nullable: true),
                    BowlerCity = table.Column<string>(type: "nvarchar (50)", nullable: true),
                    BowlerState = table.Column<string>(type: "nvarchar (2)", nullable: true),
                    BowlerZip = table.Column<string>(type: "nvarchar (10)", nullable: true),
                    BowlerPhoneNumber = table.Column<string>(type: "nvarchar (14)", nullable: true),
                    TeamID = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerID);
                    table.ForeignKey(
                        name: "FK_Bowlers_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID");
                });

            migrationBuilder.CreateIndex(
                name: "BowlerLastName",
                table: "Bowlers",
                column: "BowlerLastName");

            migrationBuilder.CreateIndex(
                name: "BowlersTeamID",
                table: "Bowlers",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "TeamID",
                table: "Teams",
                column: "TeamID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
