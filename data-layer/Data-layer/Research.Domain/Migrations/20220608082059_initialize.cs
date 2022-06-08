using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Research.Domain.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "LanguageLevel",
                columns: table => new
                {
                    LanguageLevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageLevel", x => x.LanguageLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    FEBEDevops = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surnamme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remote = table.Column<bool>(type: "bit", nullable: false),
                    IsRecruiter = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId");
                });

            migrationBuilder.CreateTable(
                name: "LanguageLink",
                columns: table => new
                {
                    LanguageLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageLevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Preferred = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageLink", x => x.LanguageLinkId);
                    table.ForeignKey(
                        name: "FK_LanguageLink_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageLink_LanguageLevel_LanguageLevelId",
                        column: x => x.LanguageLevelId,
                        principalTable: "LanguageLevel",
                        principalColumn: "LanguageLevelId");
                    table.ForeignKey(
                        name: "FK_LanguageLink_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Research",
                columns: table => new
                {
                    ResearchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remote = table.Column<bool>(type: "bit", nullable: false),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Research", x => x.ResearchId);
                    table.ForeignKey(
                        name: "FK_Research_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Research_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Research_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillLink",
                columns: table => new
                {
                    SkillLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillLink", x => x.SkillLinkId);
                    table.ForeignKey(
                        name: "FK_SkillLink_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillLink_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageLink_LanguageId",
                table: "LanguageLink",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageLink_LanguageLevelId",
                table: "LanguageLink",
                column: "LanguageLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageLink_PersonId",
                table: "LanguageLink",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SiteId",
                table: "Person",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Research_LanguageId",
                table: "Research",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Research_PersonId",
                table: "Research",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Research_SiteId",
                table: "Research",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillLink_PersonId",
                table: "SkillLink",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillLink_SkillId",
                table: "SkillLink",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageLink");

            migrationBuilder.DropTable(
                name: "Research");

            migrationBuilder.DropTable(
                name: "SkillLink");

            migrationBuilder.DropTable(
                name: "LanguageLevel");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Site");
        }
    }
}
