using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WK2018.Migrations
{
    public partial class WKContext_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Thuis = table.Column<int>(nullable: false),
                    Uit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => new { x.Thuis, x.Uit });
                });

            migrationBuilder.CreateTable(
                name: "Toernooien",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: false),
                    Logo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toernooien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KnockoutStages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false),
                    Toernooi_ID = table.Column<int>(nullable: false),
                    ToernooiID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnockoutStages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KnockoutStages_Toernooien_ToernooiID",
                        column: x => x.ToernooiID,
                        principalTable: "Toernooien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poules",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: false),
                    Toernooi_ID = table.Column<int>(nullable: false),
                    ToernooiID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Poules_Toernooien_ToernooiID",
                        column: x => x.ToernooiID,
                        principalTable: "Toernooien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: false),
                    Punten = table.Column<int>(nullable: false),
                    Poule_ID = table.Column<int>(nullable: false),
                    PouleID = table.Column<int>(nullable: true),
                    Knockout_ID = table.Column<int>(nullable: true),
                    KnockoutStageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teams_KnockoutStages_KnockoutStageID",
                        column: x => x.KnockoutStageID,
                        principalTable: "KnockoutStages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Poules_PouleID",
                        column: x => x.PouleID,
                        principalTable: "Poules",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spelers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: false),
                    WG = table.Column<int>(nullable: false),
                    GK = table.Column<int>(nullable: false),
                    RK = table.Column<int>(nullable: false),
                    DP = table.Column<int>(nullable: false),
                    Positie = table.Column<string>(nullable: false),
                    GeboorteDatum = table.Column<DateTime>(nullable: false),
                    Team_ID = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spelers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Spelers_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wedstrijden",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    Score_Thuis = table.Column<int>(nullable: false),
                    Score_Uit = table.Column<int>(nullable: false),
                    ScoreThuis = table.Column<int>(nullable: true),
                    ScoreUit = table.Column<int>(nullable: true),
                    Team_ThuisID = table.Column<int>(nullable: true),
                    Team_UitID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wedstrijden", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Wedstrijden_Teams_Team_ThuisID",
                        column: x => x.Team_ThuisID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wedstrijden_Teams_Team_UitID",
                        column: x => x.Team_UitID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wedstrijden_Scores_ScoreThuis_ScoreUit",
                        columns: x => new { x.ScoreThuis, x.ScoreUit },
                        principalTable: "Scores",
                        principalColumns: new[] { "Thuis", "Uit" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KnockoutStages_ToernooiID",
                table: "KnockoutStages",
                column: "ToernooiID");

            migrationBuilder.CreateIndex(
                name: "IX_Poules_ToernooiID",
                table: "Poules",
                column: "ToernooiID");

            migrationBuilder.CreateIndex(
                name: "IX_Spelers_TeamID",
                table: "Spelers",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_KnockoutStageID",
                table: "Teams",
                column: "KnockoutStageID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PouleID",
                table: "Teams",
                column: "PouleID");

            migrationBuilder.CreateIndex(
                name: "IX_Wedstrijden_Team_ThuisID",
                table: "Wedstrijden",
                column: "Team_ThuisID");

            migrationBuilder.CreateIndex(
                name: "IX_Wedstrijden_Team_UitID",
                table: "Wedstrijden",
                column: "Team_UitID");

            migrationBuilder.CreateIndex(
                name: "IX_Wedstrijden_ScoreThuis_ScoreUit",
                table: "Wedstrijden",
                columns: new[] { "ScoreThuis", "ScoreUit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spelers");

            migrationBuilder.DropTable(
                name: "Wedstrijden");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "KnockoutStages");

            migrationBuilder.DropTable(
                name: "Poules");

            migrationBuilder.DropTable(
                name: "Toernooien");
        }
    }
}
