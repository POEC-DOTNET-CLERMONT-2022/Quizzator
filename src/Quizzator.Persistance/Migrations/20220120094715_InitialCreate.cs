using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quizzator.Persistance.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThemeEx",
                columns: table => new
                {
                    _Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_ThemeId", x => x._Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    _Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _Texte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_QuestionId", x => x._Id);
                    table.ForeignKey(
                        name: "Question_In_Theme",
                        column: x => x.Question,
                        principalTable: "ThemeEx",
                        principalColumn: "_Id");
                });

            migrationBuilder.CreateTable(
                name: "Reponses",
                columns: table => new
                {
                    _Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _Texte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Explication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _isTroll = table.Column<bool>(type: "bit", nullable: false),
                    Reponse = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_ReponseId", x => x._Id);
                    table.ForeignKey(
                        name: "Reponses_In_Question",
                        column: x => x.Reponse,
                        principalTable: "Questions",
                        principalColumn: "_Id");
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    _Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Element = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Links = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_LinksId", x => x._Id);
                    table.ForeignKey(
                        name: "Link_In_Response",
                        column: x => x.Links,
                        principalTable: "Reponses",
                        principalColumn: "_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_Links",
                table: "Links",
                column: "Links");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Question",
                table: "Questions",
                column: "Question");

            migrationBuilder.CreateIndex(
                name: "IX_Reponses_Reponse",
                table: "Reponses",
                column: "Reponse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Reponses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "ThemeEx");
        }
    }
}
