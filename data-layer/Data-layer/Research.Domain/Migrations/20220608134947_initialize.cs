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

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResearchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MatchAcceptedByEmployee = table.Column<bool>(type: "bit", nullable: true),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.MatchId);
                    table.ForeignKey(
                        name: "FK_Match_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Match_Research_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Research",
                        principalColumn: "ResearchId");
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("126412c8-d142-439a-8790-fa41806b7996"), 3, "German" },
                    { new Guid("2cd6764a-4aa7-4076-a013-c460a1b06552"), 7, "Russian" },
                    { new Guid("452979c6-bfaa-4aef-b521-43fb5ab6b5fd"), 6, "Portuguese" },
                    { new Guid("461ef141-f99e-4358-a6a1-8711102d8422"), 5, "Italian" },
                    { new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"), 1, "English" },
                    { new Guid("95ef9726-3a87-43cb-ac5d-95e629f3a5ef"), 2, "French" },
                    { new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"), 4, "Spanish" }
                });

            migrationBuilder.InsertData(
                table: "LanguageLevel",
                columns: new[] { "LanguageLevelId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("65f15268-b8e1-450e-b849-630c5fcdc7c4"), 3, "Pre-Intermediate" },
                    { new Guid("6f7babe6-9373-41ff-b0c0-15cad4c86575"), 6, "Advanced" },
                    { new Guid("9367ac9f-e73e-456b-94a6-8b74746821d9"), 4, "Intermediate" },
                    { new Guid("bb79aa2d-68f2-49bd-a8d8-cd196b5c304b"), 1, "Beginner" },
                    { new Guid("d05ec7a8-ee43-49f9-8806-773c8fabfe2d"), 2, "Elementary" },
                    { new Guid("d0846799-ae10-4423-b626-c2645b3ebd3c"), 5, "Upper-Intermediate" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "SiteId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39"), 2, "CHICAGO" },
                    { new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce"), 5, "LONDON" },
                    { new Guid("3ff5b4a0-6950-431e-9036-4730ebe3668c"), 3, "WASHINGTON" },
                    { new Guid("960eba91-1c88-474a-90f6-0737e2abb8f5"), 4, "LOS ANGELES" },
                    { new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"), 1, "NEW YORK" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Code", "Description", "FEBEDevops", "ProjectRef", "Technology", "WebMobile" },
                values: new object[,]
                {
                    { new Guid("38bacb15-edff-497b-8780-f3870de6a7ac"), 2, "TS", "", "", "", "typescript" },
                    { new Guid("4a086652-b7a3-407f-ae75-98015d30a593"), 1, "Angular 9", "", "", "", "angular" },
                    { new Guid("cdc68fbd-e81c-417e-b67a-0e89365bd85d"), 7, "SMSS", "", "", "SSMS", "" },
                    { new Guid("ecff704d-e320-4b89-9f56-0d2622aeda9d"), 3, "Azure", "Azure", "", "", "" },
                    { new Guid("f7572b8d-b6cc-46a0-8fa9-fd38b4b97f1e"), 6, ".NET", ".NET", "", "", "" },
                    { new Guid("fdfdc6ae-9f49-4529-8fce-c22fb41e98de"), 5, "Iot", "", "", "Iot", "" },
                    { new Guid("ffb6944c-af40-44a6-8b14-b25001c608eb"), 4, "Flutter", "", "", "", "Flutter" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Code", "IsRecruiter", "Name", "Position", "Remote", "SiteId", "Surnamme", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), 3, true, "Mario", "recruiter", false, new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"), "Rossi", 2 },
                    { new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), 2, true, "Mario", "recuiter", true, new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39"), "Rossi", 2 },
                    { new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"), 4, false, "Mario", "dev", true, new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"), "Rossi", 2 },
                    { new Guid("7b81a1d6-d343-47a8-ad87-d2bf94e73327"), 6, false, "Alessandra", "dev", true, new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39"), "Verdi", 15 },
                    { new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"), 1, false, "Nicoletta", "dev", false, new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"), "Morsia", 2 },
                    { new Guid("c1a7eb76-651b-4c10-96a8-27328c722eec"), 5, false, "Giovanni", "dev", true, new Guid("3ff5b4a0-6950-431e-9036-4730ebe3668c"), "Bianchi", 4 },
                    { new Guid("c567c61b-4d95-4f3b-b4b6-0aabf6dff459"), 7, false, "Giovanni", "dev", true, new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce"), "Novembre", 1 }
                });

            migrationBuilder.InsertData(
                table: "LanguageLink",
                columns: new[] { "LanguageLinkId", "LanguageId", "LanguageLevelId", "PersonId", "Preferred" },
                values: new object[,]
                {
                    { new Guid("0fa95d29-9a13-40a9-905d-0f779c12d601"), new Guid("461ef141-f99e-4358-a6a1-8711102d8422"), new Guid("65f15268-b8e1-450e-b849-630c5fcdc7c4"), new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), true },
                    { new Guid("25279a4d-f266-4add-9d2b-21ed1f408168"), new Guid("2cd6764a-4aa7-4076-a013-c460a1b06552"), new Guid("d0846799-ae10-4423-b626-c2645b3ebd3c"), new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"), true },
                    { new Guid("653b4538-2394-4204-a2d0-a6fc469288d3"), new Guid("126412c8-d142-439a-8790-fa41806b7996"), new Guid("bb79aa2d-68f2-49bd-a8d8-cd196b5c304b"), new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), true },
                    { new Guid("6bde5d37-22a6-4e01-b141-7b91f44baf98"), new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"), new Guid("65f15268-b8e1-450e-b849-630c5fcdc7c4"), new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"), true },
                    { new Guid("ca575305-0be3-4514-bc3c-81c33b3dea6c"), new Guid("95ef9726-3a87-43cb-ac5d-95e629f3a5ef"), new Guid("6f7babe6-9373-41ff-b0c0-15cad4c86575"), new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"), false },
                    { new Guid("e0d1e0cc-4a7a-4afc-b042-ac613be58fa3"), new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"), new Guid("d05ec7a8-ee43-49f9-8806-773c8fabfe2d"), new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), false },
                    { new Guid("e5f07299-a711-4f15-bf6d-d1e1310504a9"), new Guid("452979c6-bfaa-4aef-b521-43fb5ab6b5fd"), new Guid("9367ac9f-e73e-456b-94a6-8b74746821d9"), new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), false }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("099c0f69-c4e4-4aac-ab1f-7322fb5882e0"), 6, "Back end .NET", new Guid("461ef141-f99e-4358-a6a1-8711102d8422"), new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), true, new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39") },
                    { new Guid("1e87989c-bfc3-484c-97b6-9b9d568e8b59"), 8, "Flutter", new Guid("452979c6-bfaa-4aef-b521-43fb5ab6b5fd"), new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), true, new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a") },
                    { new Guid("7dcea56c-595f-43c9-b8f4-e109f6f8bfb5"), 2, "Back end .NET", new Guid("95ef9726-3a87-43cb-ac5d-95e629f3a5ef"), new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), true, new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39") },
                    { new Guid("8c394c3d-4b20-4982-aed4-c44900a0819d"), 5, "Smss", new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"), new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), false, new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce") },
                    { new Guid("b5c14745-c33e-4654-9fcd-4dac60d68724"), 7, "Azure", new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"), new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), true, new Guid("960eba91-1c88-474a-90f6-0737e2abb8f5") },
                    { new Guid("ba5233d9-f106-4933-9f2c-f6659f16110b"), 9, "Back end .NET", new Guid("2cd6764a-4aa7-4076-a013-c460a1b06552"), new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), true, new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce") },
                    { new Guid("be14ee89-3158-4652-97ae-93cd7d491529"), 1, "Front end Angular", new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"), new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), true, new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a") },
                    { new Guid("bf73ad97-64e1-4dd5-8ac4-6cec81a18cdd"), 4, "Azure", new Guid("126412c8-d142-439a-8790-fa41806b7996"), new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), false, new Guid("960eba91-1c88-474a-90f6-0737e2abb8f5") },
                    { new Guid("da87d61e-c0b7-4d7f-b770-efbe7d7ea563"), 3, "Typescript", new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"), new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), true, new Guid("3ff5b4a0-6950-431e-9036-4730ebe3668c") }
                });

            migrationBuilder.InsertData(
                table: "SkillLink",
                columns: new[] { "SkillLinkId", "Level", "PersonId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("0b96ed92-8ee7-47c0-ae14-ddcc297e0bb7"), 1, new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"), new Guid("4a086652-b7a3-407f-ae75-98015d30a593") },
                    { new Guid("116adc8e-fe03-4e3e-9f31-52adbcfd8a0e"), 2, new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"), new Guid("ecff704d-e320-4b89-9f56-0d2622aeda9d") },
                    { new Guid("51bcbc4c-24a6-4c8e-8eaf-1b215ab39ac7"), 3, new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"), new Guid("f7572b8d-b6cc-46a0-8fa9-fd38b4b97f1e") },
                    { new Guid("525aaa26-ba54-4b30-aa5d-d5fb8ad559ff"), 3, new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"), new Guid("ecff704d-e320-4b89-9f56-0d2622aeda9d") },
                    { new Guid("939c2e4d-7325-476f-a1fa-8de191136434"), 2, new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"), new Guid("38bacb15-edff-497b-8780-f3870de6a7ac") },
                    { new Guid("c3578201-9e89-43d5-a7a8-242604f4cc61"), 2, new Guid("c1a7eb76-651b-4c10-96a8-27328c722eec"), new Guid("cdc68fbd-e81c-417e-b67a-0e89365bd85d") },
                    { new Guid("cb406ebd-5350-4fa9-9f93-911bf4c12675"), 1, new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"), new Guid("ffb6944c-af40-44a6-8b14-b25001c608eb") },
                    { new Guid("ea0fb5b1-3d73-4e74-a97b-a1f839c0e7b9"), 6, new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"), new Guid("fdfdc6ae-9f49-4529-8fce-c22fb41e98de") }
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
                name: "IX_Match_PersonId",
                table: "Match",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_ResearchId",
                table: "Match",
                column: "ResearchId");

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
                name: "Match");

            migrationBuilder.DropTable(
                name: "SkillLink");

            migrationBuilder.DropTable(
                name: "LanguageLevel");

            migrationBuilder.DropTable(
                name: "Research");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Site");
        }
    }
}
