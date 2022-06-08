using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Research.Domain.Migrations
{
    public partial class addedSeedingDataWithRandom : Migration
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
                    { new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), 2, "French" },
                    { new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), 1, "English" },
                    { new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), 3, "German" },
                    { new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), 6, "Portuguese" },
                    { new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), 4, "Spanish" },
                    { new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), 5, "Italian" },
                    { new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), 7, "Russian" }
                });

            migrationBuilder.InsertData(
                table: "LanguageLevel",
                columns: new[] { "LanguageLevelId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("03d0108b-e85e-4906-a625-2f84dbbd3653"), 6, "Advanced" },
                    { new Guid("43531899-3585-4f87-bbce-0de38d082208"), 4, "Intermediate" },
                    { new Guid("574e7dea-81fd-41e1-8d5c-8ba83aec3a49"), 5, "Upper-Intermediate" },
                    { new Guid("9dd40625-5160-4d12-97f9-01c2f1d0236f"), 2, "Elementary" },
                    { new Guid("bca265d1-9324-4dd7-a9e7-2930a1c2a34e"), 1, "Beginner" },
                    { new Guid("ff1167a6-e0e5-4434-bc49-6c970f3995a7"), 3, "Pre-Intermediate" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "SiteId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074"), 5, "LONDON" },
                    { new Guid("18958862-067b-447b-9467-0eb616ad7b61"), 2, "CHICAGO" },
                    { new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2"), 1, "NEW YORK" },
                    { new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0"), 3, "WASHINGTON" },
                    { new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90"), 4, "LOS ANGELES" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Code", "Description", "FEBEDevops", "ProjectRef", "Technology", "WebMobile" },
                values: new object[,]
                {
                    { new Guid("2065f878-48ef-464e-9c0a-75ef84a5fab7"), 6, ".NET", ".NET", "", "", "" },
                    { new Guid("2ec7b396-ea11-4279-8a50-581d76f0e62b"), 5, "Iot", "", "", "Iot", "" },
                    { new Guid("8482a871-2f2a-42ab-93ce-c5c241b2531e"), 2, "TS", "", "", "", "typescript" },
                    { new Guid("96e11654-f341-41a7-a4c7-8f89bf483c1f"), 3, "Azure", "Azure", "", "", "" },
                    { new Guid("c28823a4-3bf0-4907-9384-41c25850fadb"), 1, "Angular 9", "", "", "", "angular" },
                    { new Guid("d4742c7d-8173-4677-a3bf-1cf633ed92a5"), 7, "SMSS", "", "", "SSMS", "" },
                    { new Guid("f2effd39-6298-4ab9-bbf4-80fc003c7c45"), 4, "Flutter", "", "", "", "Flutter" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Code", "IsRecruiter", "Name", "Position", "Remote", "SiteId", "Surnamme", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), 7, false, "Giovanni", "dev", true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074"), "Novembre", 1 },
                    { new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), 6, false, "Alessandra", "dev", true, new Guid("18958862-067b-447b-9467-0eb616ad7b61"), "Verdi", 15 },
                    { new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), 1, false, "Nicoletta", "dev", false, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2"), "Morsia", 2 },
                    { new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), 5, false, "Giovanni", "dev", true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0"), "Bianchi", 4 },
                    { new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), 3, true, "Mario", "recruiter", false, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2"), "Rossi", 2 },
                    { new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), 2, true, "Mario", "recuiter", true, new Guid("18958862-067b-447b-9467-0eb616ad7b61"), "Rossi", 2 },
                    { new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), 4, false, "Mario", "dev", true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2"), "Rossi", 2 }
                });

            migrationBuilder.InsertData(
                table: "LanguageLink",
                columns: new[] { "LanguageLinkId", "LanguageId", "LanguageLevelId", "PersonId", "Preferred" },
                values: new object[,]
                {
                    { new Guid("9ca53809-3c8c-4e2c-b459-54815f36f326"), new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("bca265d1-9324-4dd7-a9e7-2930a1c2a34e"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true },
                    { new Guid("aec4f525-e652-49dc-84fe-c202489d9ea5"), new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("ff1167a6-e0e5-4434-bc49-6c970f3995a7"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true },
                    { new Guid("d0cc80c7-4fc5-4dce-aaa2-edd79d169948"), new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("03d0108b-e85e-4906-a625-2f84dbbd3653"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), false },
                    { new Guid("da16291d-23f2-4d8e-8d80-9f34b1bca4c1"), new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("43531899-3585-4f87-bbce-0de38d082208"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), false },
                    { new Guid("de3ce73a-1bac-4af1-ba24-e0e3b05e934b"), new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("9dd40625-5160-4d12-97f9-01c2f1d0236f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), false },
                    { new Guid("e02e300e-fc44-4273-97c3-360cf3b330a5"), new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("ff1167a6-e0e5-4434-bc49-6c970f3995a7"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true },
                    { new Guid("f3cf542c-a696-406b-9719-1bcae1ce740b"), new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("574e7dea-81fd-41e1-8d5c-8ba83aec3a49"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("00079e8c-e699-407a-9fc1-a2e46020ae1c"), 973, "Research 972", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("00166ae9-2ad7-4077-aa6b-2b4ca5d54fb5"), 68, "Research 67", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("0101781b-26fc-4ad4-bd01-52399d6382b7"), 215, "Research 214", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0161040e-feed-432e-9bac-e2c6961cd5e1"), 904, "Research 903", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("0186921c-2c2a-41f8-b658-8cd54fc28ae6"), 917, "Research 916", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("01fe67ec-e54b-4dd3-8ad4-2fb9f8b9519d"), 240, "Research 239", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("02556cde-5173-4788-a763-d6a5c720968e"), 798, "Research 797", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("02abb5ea-9f8e-44dc-8fb3-fa93355dfe6b"), 635, "Research 634", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("02e278e9-a03e-4cdc-9041-21aa35c40669"), 162, "Research 161", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("030839e2-49ea-4054-bec3-f56bc06056df"), 222, "Research 221", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("033bed20-ed2e-4fc8-891d-03a28dbd694e"), 925, "Research 924", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("0348db30-daa5-4845-86f6-696e063eb420"), 60, "Research 59", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("0371563a-95f6-4563-a264-21727a5694a0"), 287, "Research 286", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("04de5987-037c-4d0d-b387-b6f16e775689"), 634, "Research 633", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("04df2d75-570e-4ec3-a4b6-158b9f904d04"), 119, "Research 118", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("059e27e0-0171-4166-9c8c-50b8a6f74afb"), 33, "Research 32", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("0625891c-5616-4e6a-8720-1fe5a3911d7b"), 466, "Research 465", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("062dfeb6-bc5a-40a4-b113-0734b8f8bdd3"), 701, "Research 700", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("06a2b838-0d01-4ecd-aa20-9988afe6bf0e"), 29, "Research 28", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("06a72dd7-b3c9-4ac4-939b-078f569d2e48"), 879, "Research 878", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("06f0678d-6699-4cd8-826d-6fafb42935fa"), 587, "Research 586", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("078bacac-c31c-4b4a-a0fe-99309ad8a9c9"), 623, "Research 622", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("08188cda-c036-425f-aea5-df43f45e3a85"), 457, "Research 456", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("08b64a01-4c1a-43b7-9bb3-49d1eca10151"), 284, "Research 283", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("08d98234-a53c-49ed-88f2-830f593f557f"), 17, "Research 16", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("08e26a67-3aac-4edd-9b33-da154842f6fa"), 211, "Research 210", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("09641279-b357-4acf-9eb5-81a2636310c9"), 484, "Research 483", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("098e2ac2-1f5c-4d0c-bc2f-2caddd61c04c"), 523, "Research 522", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("098e97f8-fff2-4b9b-b4fb-8d1b804b27b4"), 604, "Research 603", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("09c09046-0e0e-412d-93ea-e5a333c865c8"), 306, "Research 305", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("09c6a8c7-3a32-434a-b27f-50394e983766"), 706, "Research 705", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("0a932a6c-1cdd-426d-8da0-ddf49be2f4e6"), 975, "Research 974", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("0a9390e1-0e66-4aad-8266-8cf7d3b6458a"), 197, "Research 196", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("0a98d371-925b-482c-826f-266e7c8b44a4"), 209, "Research 208", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("0ad45804-50aa-4443-9742-ba011ec51270"), 697, "Research 696", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("0b03dfc1-7a53-457d-95e5-99e1e95c1713"), 883, "Research 882", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0b6b75ee-cb7b-414a-8c9a-2b7dba228215"), 547, "Research 546", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("0b6ffac6-6e9f-4e12-8ec9-8460146fd07b"), 348, "Research 347", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("0b9cd510-4340-4166-b0b6-4273b092b985"), 867, "Research 866", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0bd406dc-4f97-4321-8688-af7c1d090af2"), 698, "Research 697", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("0beb624a-9739-4131-adf4-63f37529bb80"), 832, "Research 831", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("0c4afc15-ab6b-4e52-9ccc-7372aaf0194a"), 537, "Research 536", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("0c8ba009-b0da-4e9b-af32-351c6cb7c9d7"), 826, "Research 825", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("0ca2efde-c1f8-4f14-8ee5-88d4c6e6a385"), 513, "Research 512", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0cb43c17-f402-4aa7-8ca1-9201e9e30e21"), 561, "Research 560", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("0cc43e8c-be4c-4c79-9ef5-b661e0ed8e48"), 324, "Research 323", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("0da5f802-ce12-470e-ae5c-e7041371dbff"), 586, "Research 585", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0db3bee8-0bed-4aeb-bd17-be34754bc001"), 411, "Research 410", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0e1da345-53ca-40e5-9b08-27ec20515ede"), 110, "Research 109", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0e433194-f881-4bd9-a950-05245a463ae8"), 900, "Research 899", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("0e858e8f-1021-4714-8b65-250beb36ef4f"), 775, "Research 774", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("0e9d02a5-0b4d-4ded-88a5-56297afb6293"), 820, "Research 819", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("0f569d9f-f59e-44d4-9602-b98f3a95f059"), 296, "Research 295", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("0fcc79b8-a689-4799-8325-7b51b1cff0b5"), 770, "Research 769", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("0fd47508-714f-48e2-9882-2966d46d557e"), 939, "Research 938", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("0fd5394a-ade4-4c5f-a2f8-b80653caa69b"), 961, "Research 960", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("10165cbc-b1bc-40b0-a3e4-1c6470261540"), 992, "Research 991", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("103011e5-6960-4d90-aa98-508cb1041ca2"), 835, "Research 834", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("1095f6f2-0f70-4636-8762-4b72a2daccdc"), 45, "Research 44", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("10a15713-8fbe-44d2-a039-c9aaa7efb31f"), 583, "Research 582", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("10b2aa66-dfb4-45ca-8c5e-0d20d0632efc"), 574, "Research 573", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("10cd6cc8-e7af-41ac-a4ec-1550a4464c11"), 397, "Research 396", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("10d740b9-99e4-4554-8e74-8a4fe8beade1"), 86, "Research 85", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("10efb10e-39f4-4134-8b7d-2f5746eff722"), 620, "Research 619", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("10ff5842-8db8-4c91-a753-bae93cfae5fd"), 759, "Research 758", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("110fd36c-9fd4-4931-86fa-239261573fc4"), 965, "Research 964", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("11241ace-aced-4d72-b11f-8049aae46539"), 998, "Research 997", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("114b1be8-dd17-4c13-abd8-7f52572e79e5"), 821, "Research 820", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("118428ac-bfb2-4a97-8301-a76721a88cfa"), 304, "Research 303", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("11ab2cad-d7b4-429e-b440-e78e71f0c5e4"), 549, "Research 548", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("1250258d-b3d7-44f9-afa2-19280ecc2816"), 846, "Research 845", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("12512a19-3c1e-40e4-b33d-061e512d4e18"), 234, "Research 233", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("12939f23-a0f1-4624-93fa-f39ad97b1d78"), 497, "Research 496", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("12c5d984-e384-4e2b-99b8-223990b29654"), 269, "Research 268", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("12ffcae8-635a-402b-a639-1e758edab073"), 492, "Research 491", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("14126f9a-a80b-4bba-9649-85d9745a96ae"), 467, "Research 466", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("146c2337-4b48-4972-968a-c281bfc9b359"), 157, "Research 156", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("14da446e-37f6-4dbe-8b2c-6784e225429d"), 97, "Research 96", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("14f4658c-4587-4c66-8f1a-20353e5b5e15"), 685, "Research 684", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("160dc4d0-0495-4001-9c2e-3564dc9a8b26"), 100, "Research 99", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("1634386e-addd-446c-9cd0-2f56a5abf581"), 175, "Research 174", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("16ea8995-3eae-4410-9c24-3e7dfe7c6199"), 929, "Research 928", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("16eba6ab-8d50-4796-b62e-9a69354dfe61"), 827, "Research 826", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("172c9fc9-1351-406d-b4d9-a8015b835135"), 52, "Research 51", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("173b2ef9-ea63-4356-af5c-ed8066a060db"), 105, "Research 104", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("1741e84e-1567-4999-a7fd-b5b0e8cc0941"), 553, "Research 552", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("1765eed0-28ca-45d0-84aa-ea9facc68ac1"), 7, "Research 6", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1789a81d-fb4f-41e5-96d2-a45a7bdff409"), 270, "Research 269", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("17a32f04-7399-47e6-b734-bfa4f656d9c5"), 890, "Research 889", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("17d25030-1ea4-4cf3-aafd-fb179dc0b052"), 407, "Research 406", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("18673d1a-4e12-47df-9615-6ad9809a48e5"), 852, "Research 851", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("186f1b8d-770e-4d4e-9ee8-acda143374ad"), 322, "Research 321", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("191a4fed-406f-4b30-98d3-b081588458dc"), 75, "Research 74", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("194f3fd9-17d6-4882-b149-591939883f70"), 662, "Research 661", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("19749370-9b9b-4dca-91c9-823cb6e9cf1c"), 768, "Research 767", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("1988ab68-0c31-4142-94e1-b78268c27794"), 302, "Research 301", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("19d7ce41-0cc3-414b-87c9-235ace7db5ee"), 575, "Research 574", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("19fae7bc-c956-494c-b7b3-09306f6ed800"), 206, "Research 205", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("1a322fea-5ece-45bf-b0ad-70f917aff2ee"), 300, "Research 299", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("1a421c2a-985e-4444-b017-b816c2e67fe3"), 323, "Research 322", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("1a7d21f0-0219-4901-aa54-d8ecb5a7cea6"), 131, "Research 130", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1ac221a6-f83f-4ca1-bcb5-2bbfffddfaf9"), 894, "Research 893", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1adcd0d0-9f77-4a1c-82d9-4309a49bcb35"), 144, "Research 143", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1b2d0aab-eaee-40e2-b543-1413500f7870"), 2, "Research 1", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("1b2f6ebc-c09b-4925-b548-20b21f0a2e04"), 426, "Research 425", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("1b6fe16a-5dc9-48e2-823b-4e39f551b307"), 828, "Research 827", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1c424d05-c984-46a8-8e41-c46ae417486c"), 942, "Research 941", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("1c984353-1076-4718-9d6b-60d902f419e5"), 359, "Research 358", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1cc3b587-3db3-44af-9345-307a6d4e42bc"), 317, "Research 316", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1cf0128d-b620-4fa3-8af2-0f65f7749633"), 966, "Research 965", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("1d732e5c-6be1-4fcb-9877-eb05f614095c"), 986, "Research 985", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("1d9ae0ec-f719-4cbc-b610-d800ab5e9ff5"), 729, "Research 728", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("1db04f0f-d6ae-42cf-a7c8-05dd381febf8"), 460, "Research 459", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1df0ad55-96a3-4800-8329-43edb6cff9c7"), 114, "Research 113", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("1e1566be-6277-4759-8605-835fa627b402"), 128, "Research 127", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("1e5eba67-bece-4fb3-bf0c-9ce86f8695cb"), 393, "Research 392", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("1e8bd8a8-c00b-4ae1-9a9d-07df93269c55"), 340, "Research 339", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("1e987de6-c929-423d-964f-9c1bf0dc3168"), 253, "Research 252", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("1ea89e60-932f-4368-a336-5908ccdb4944"), 169, "Research 168", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("1ee895ec-9c95-4195-bec8-7ed5be2f57c2"), 80, "Research 79", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("1eecc814-aba6-4fa9-8eb5-1895a0724b87"), 841, "Research 840", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("1ff4b266-f5fb-492a-950b-813fe7d26862"), 573, "Research 572", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("1fff884a-69e6-4d02-a678-c19d0934bfbb"), 48, "Research 47", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2009d787-a3f3-43b4-8006-b20efd57d1cc"), 25, "Research 24", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("203f7b55-35df-4a87-9da0-fab290aed6d7"), 633, "Research 632", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2093d848-66d8-44d9-b9b5-9b27436b5b45"), 451, "Research 450", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("20ca7071-2a04-473e-bdb0-1515a660e668"), 354, "Research 353", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("21631e43-4a28-42c1-92ce-74b2a65d3837"), 98, "Research 97", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("217f66b1-5693-4dde-be39-e5771a2b2781"), 560, "Research 559", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("226db51b-fc3e-441f-9d2e-b8e49b257a0d"), 125, "Research 124", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("22ce8fcb-6b23-4d05-97f9-ab3daae240eb"), 299, "Research 298", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("22e8bad1-d4e7-4219-a57d-4708c4371d78"), 130, "Research 129", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("238e554a-1f0d-4a60-a934-0e767f902be7"), 950, "Research 949", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2397f90f-2f8d-4bb5-8df9-685e3a60691c"), 364, "Research 363", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("23b2534b-c1fa-419f-bf94-86b54ec518ed"), 718, "Research 717", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("23b99494-0a74-46e6-b0e4-da6efca7102e"), 542, "Research 541", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("242cabe6-6b30-4682-b9a9-5ad399b0af2b"), 991, "Research 990", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("24717286-9787-4533-9b39-340b9e0f5e04"), 825, "Research 824", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("24b94006-b9ac-443a-9866-f6af296b2c18"), 140, "Research 139", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("25732048-4dc7-44d9-8ae5-ac6d26f42a50"), 983, "Research 982", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("259a98e2-c7ef-4361-a803-ca0687911bf6"), 192, "Research 191", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("25a0efa1-22fc-42eb-916b-dea85fc7ea9e"), 772, "Research 771", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("2623a73e-793c-4439-b3d0-7a7b260eb19f"), 34, "Research 33", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("264454d6-604d-4003-8362-1e4a38b631a8"), 499, "Research 498", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("268fb365-ec5b-43c8-b8f0-925d4ada082a"), 987, "Research 986", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("26cf75d3-7b15-4e49-a866-cc98a4d460b4"), 892, "Research 891", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("26d842d7-ff61-400a-983d-678511283bfd"), 787, "Research 786", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("26e63e26-cbe0-40d6-832a-7e01b273f7e2"), 8, "Research 7", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("272a4e45-4ea1-4992-b33b-a373a9243403"), 624, "Research 623", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("272b289f-580c-4963-9e89-e1a5d2b0f4a5"), 1000, "Research 999", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("272f211d-34d1-4aef-8084-fd0cf9ef328d"), 669, "Research 668", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("27336b4e-f7b7-4388-a5bb-57b0090a0bd8"), 36, "Research 35", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("27557741-c263-4e3d-9671-1d67d6dc4ebd"), 676, "Research 675", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2766b3ed-1149-4978-ac6c-8180ec735a76"), 792, "Research 791", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2793601d-c0e5-4efe-b5f0-d7deb59547d3"), 223, "Research 222", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("27ab166f-3758-48d0-9e85-511df732151c"), 316, "Research 315", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("27cf79f7-61b7-4f5a-8c56-4cebe99ca159"), 310, "Research 309", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("27d75130-8d37-4377-a3b9-1913d4ae8064"), 969, "Research 968", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("2811aaa3-c04d-4ac7-990b-57d2fdd812f0"), 501, "Research 500", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("28cd2d24-bede-41fd-9669-25d7d8f190b3"), 329, "Research 328", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("28e90c47-80b9-4c3d-8290-31017a941073"), 333, "Research 332", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("2927f3c9-6984-46a9-8314-f1d34f0af766"), 79, "Research 78", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2954caf1-bb2d-41a3-b7e2-4a34193f4066"), 567, "Research 566", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("29821a3e-ddbe-4209-921f-9997fec5c364"), 28, "Research 27", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("298f47f0-3c5d-439f-9a7e-7e456a614959"), 570, "Research 569", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("29e8d405-af02-4d48-866d-16960d3c8157"), 731, "Research 730", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2a0e2a61-6ae4-4bd1-aaf1-839a7f5a5958"), 173, "Research 172", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2a3fea99-b2d9-4e1b-8080-e90de3dbb707"), 906, "Research 905", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("2a450269-d921-464c-b034-4fe90a60a7a2"), 174, "Research 173", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2ac839bb-94a7-47e4-8194-e25ea510a95c"), 619, "Research 618", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("2aed63c6-b608-4954-a43e-054882e39920"), 728, "Research 727", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("2b30820d-819e-4a05-aa4c-9ff2f1a8c789"), 433, "Research 432", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2bbd2dc3-f181-4b43-9b0f-d1859d63276e"), 693, "Research 692", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2bc47ac7-f504-4892-9012-ab40d00c9a7a"), 491, "Research 490", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2c319346-d490-4d75-abef-fbd76deb80c1"), 555, "Research 554", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2c391346-0f62-45f9-85cb-1501a27779e1"), 263, "Research 262", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2c392cc8-1f1c-4cd7-b437-686308ae982a"), 625, "Research 624", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2c65f1d5-9655-4fae-86e6-c5eea71137c5"), 39, "Research 38", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2c8c0925-94b8-4e0d-96ef-ded2d2965148"), 168, "Research 167", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2d55ba20-6925-4312-b592-627f0b7a1f4f"), 337, "Research 336", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2d876b25-8c7b-4383-82f7-e8ebb1045663"), 292, "Research 291", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2e48ebaf-04f0-4d0c-9748-5cadb0ad0255"), 107, "Research 106", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("2e6db890-583a-4c96-a36c-3af84e8de720"), 585, "Research 584", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("2f7f1bff-8ce3-4dcc-af09-01fa1b7f5092"), 399, "Research 398", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("2f83f9ca-1888-45af-8915-e7e4b5b994d4"), 220, "Research 219", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("2fac1e68-4116-4924-9ae6-5832eed4cc63"), 87, "Research 86", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("300e2af0-e2be-4daf-b9a8-24b065e47973"), 485, "Research 484", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("30116ae6-60df-4a90-841b-feefedcae9ae"), 946, "Research 945", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("30490b15-27c4-4ebe-ae75-cf85821e00d5"), 615, "Research 614", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("309b3727-f814-475a-904f-d1189278a2d2"), 84, "Research 83", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("30a0f6d7-e852-4e57-99a7-7dbe201e50cb"), 778, "Research 777", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("30b2f735-dcd7-4942-a84f-beacd3092cbd"), 455, "Research 454", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("30b726ad-ad98-4e60-9aa7-e0befdd0651b"), 822, "Research 821", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("3125bf91-c49e-43f8-b0ff-3095773c3997"), 751, "Research 750", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("327a095c-6ebe-4eb8-9c0b-17201288e550"), 402, "Research 401", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("32cbf7fc-d10f-46d4-a699-1ab1afdf4b6a"), 371, "Research 370", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3341a4e5-2656-4df1-8c00-b8848688c8d5"), 667, "Research 666", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("335117f3-5af9-4cd6-8596-a8c36069dae7"), 515, "Research 514", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("3356c2de-db0d-4ba3-9c43-16614a67c82b"), 885, "Research 884", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("33640fae-f727-4495-9523-8adc68487233"), 785, "Research 784", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("33928ec7-255a-46e7-9965-977641f903e3"), 370, "Research 369", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("33dac479-173c-41e8-becd-52f0e6e68349"), 230, "Research 229", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("33e3e09a-6dac-4dc9-8fb9-95df56efd1df"), 236, "Research 235", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("3401b0f2-7a73-4246-bb63-7c42328d84f2"), 550, "Research 549", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("3404829a-03db-440b-977d-0453be1ae21d"), 598, "Research 597", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3459a3a9-8883-4314-bd63-ffa37e9e1764"), 434, "Research 433", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("348951fe-4251-47e3-8564-87a31d511a6e"), 990, "Research 989", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("348b6d4b-b46f-4dd4-a899-edd852b41ea8"), 934, "Research 933", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("34d2d7dc-ae49-40a3-b8cb-e2b75b709e12"), 330, "Research 329", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("35138d1a-e309-426f-baae-045ec3494a72"), 748, "Research 747", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("3513ea68-40b7-4905-8f86-aa583f6c7007"), 855, "Research 854", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("3515ca75-8dcb-49b0-9efb-431a3fc3f38e"), 744, "Research 743", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("351d99b5-fec3-4cdf-bb36-9daffac2475e"), 432, "Research 431", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("35306fe1-c8e3-4db2-ad48-d50788262441"), 943, "Research 942", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("356020fa-5e2b-41d6-b88f-f4ec043eeeb9"), 670, "Research 669", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("359fbc0a-bac9-488d-986a-a3f297b5a41a"), 85, "Research 84", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("35a082e5-1fac-495d-a0bd-718fb10e1117"), 848, "Research 847", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("35af78e7-c5c0-4ea3-a117-a07b8a8d21d5"), 163, "Research 162", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("3603c357-82d7-465b-a27d-f72f02c65328"), 367, "Research 366", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("362bba03-7470-46e9-be17-2571ac8c6aeb"), 255, "Research 254", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("3630d28b-28e7-468a-b9d6-eaafafe01266"), 472, "Research 471", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("364116b1-0ed9-4c2d-bea4-7728ef9136b8"), 989, "Research 988", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("36ba76ab-f3e3-4d9e-a98e-6d316aef5a98"), 582, "Research 581", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("36de3a9a-7d58-4e2f-a7ed-8c0d1d687c1e"), 146, "Research 145", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("37389889-361c-40bb-aa1c-a9e91b704b98"), 758, "Research 757", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("3782bc4e-c358-45cf-80ea-bb8c677a2958"), 66, "Research 65", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("378475ab-d4d4-4373-9e85-9ac9b2992877"), 823, "Research 822", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("37941f1c-5a1f-4541-b826-1fa84e890e9a"), 42, "Research 41", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("37b4e3f7-9753-41b3-89be-bf553615ddf6"), 945, "Research 944", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("37c05c02-7de7-472e-983d-6fc9b86e868c"), 673, "Research 672", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("37cbd62c-25bf-4776-9e88-43dcc8175603"), 984, "Research 983", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("37f6ff20-8fe3-4967-a72a-cbdf78147bd3"), 960, "Research 959", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("38ae600a-7bc4-447c-9a5b-6a3e6c40dd92"), 814, "Research 813", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("39097b64-7560-41c9-89a0-15481810e7a4"), 566, "Research 565", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("3916ccff-f41b-4244-94ef-4ce751aeb043"), 51, "Research 50", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("39668eb5-2c9b-472e-8d2b-c5c71768ae2d"), 629, "Research 628", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("3971b4d2-c3e4-4530-8182-a03e8105d154"), 893, "Research 892", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3a0a4c86-3eea-4a38-b80d-898f36960a8c"), 418, "Research 417", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("3a239173-e8ae-4984-b46b-bfdad5a1398e"), 948, "Research 947", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("3a31d759-b0a9-4009-8666-951bbcbcee6a"), 277, "Research 276", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3a79cb1c-c890-499c-bdcf-5afb25c1ea5b"), 449, "Research 448", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("3b05b625-a6b2-4c38-ac49-a825ce9b6cb4"), 508, "Research 507", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3b493a17-4b5d-48fd-bf20-4bc7d2220d2b"), 596, "Research 595", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3bbd9bb0-6f28-4696-bbb3-008b14c130b6"), 911, "Research 910", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3be8cfa3-54ae-4f2f-a55b-0ca3b6a1afbc"), 225, "Research 224", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("3c1ce660-dd27-4952-8c0b-db01b26401d6"), 801, "Research 800", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("3cd6277e-db57-4fa3-847e-cb28da3fe4d8"), 796, "Research 795", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("3d1f64f2-e516-4033-9908-73a01ea45775"), 721, "Research 720", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3d4b5e34-8db1-4421-aa8c-97df7f240c88"), 614, "Research 613", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("3dab49fd-9c45-4bc4-b823-f5a40aa80ceb"), 95, "Research 94", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("3e3ca6ac-e66a-424d-8850-b40b29725d91"), 470, "Research 469", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("3effb49b-d17e-44d5-9dbf-02f0e83b7d8a"), 11, "Research 10", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("3f1bf486-4a27-4b7a-961d-361238679cc8"), 951, "Research 950", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("3f1ff85e-7b4b-48eb-8e09-6bd7c9622cea"), 145, "Research 144", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("3f5ff422-74f2-4824-b6c3-5ee471e91eba"), 424, "Research 423", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("40959023-11dd-44c0-b609-139f9e487c15"), 534, "Research 533", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("40cd396e-bec2-4e3e-936c-6f44ba7a1e10"), 252, "Research 251", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("41525646-d60e-4532-857f-e5e358014500"), 749, "Research 748", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("4153f0ee-e234-4a9e-ad65-9deb3cda6a1c"), 445, "Research 444", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("415eafbd-249e-40a5-ace2-56966cd2784d"), 164, "Research 163", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("41be0597-7d30-43f4-9dbb-219d9d90b14d"), 468, "Research 467", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("41f89659-46a4-43aa-aa28-02a815fdaf21"), 725, "Research 724", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4225f3c0-a0cf-44f4-811c-970062b746c5"), 836, "Research 835", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("427c0804-fbef-45bc-9a50-aaf41c6cff0d"), 842, "Research 841", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("42a47842-d215-41f2-a1d8-5459a59533f6"), 213, "Research 212", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("42df35a9-29d3-4bc3-944b-efe311c843ab"), 313, "Research 312", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("42ea0678-5504-48d5-8c5a-086cadfc5c25"), 120, "Research 119", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("43307ed0-9a51-47c4-9fb5-a69bf294376c"), 923, "Research 922", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("43462862-be3f-4093-a03e-2b951b584929"), 57, "Research 56", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("43dd9465-200f-40b3-a9f3-3c96d120aca4"), 165, "Research 164", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("442db30d-fddd-403d-86a2-46531277e532"), 332, "Research 331", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("449da1a2-b1e0-4af4-93ad-09d89c43aab7"), 694, "Research 693", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("44b36d61-d7f6-4355-80ad-1444284d688e"), 111, "Research 110", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("44d0f0d9-4f15-49f4-a055-f2ac5645d1af"), 400, "Research 399", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("4523dae9-9d8e-490a-b50b-45d73b0532ae"), 655, "Research 654", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("45485b98-e89f-404e-8577-9d32c083978e"), 675, "Research 674", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("45d95ee5-4ed1-44d0-ac04-ee11b1d85bb7"), 781, "Research 780", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("45fe4e3b-6509-40cb-8478-f897579731b2"), 876, "Research 875", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("460e0adc-7e63-4be1-9e22-6e6e74c694c1"), 378, "Research 377", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("465c45fc-539d-40bd-896f-4b8c2a18d1ef"), 122, "Research 121", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4686a600-e41e-42c7-8e44-7462c2225897"), 311, "Research 310", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("46cca116-b877-4ea5-a90e-63a4fca6f10b"), 391, "Research 390", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("46f272ae-d970-416a-b07d-27d213c7b54f"), 419, "Research 418", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("4705ee5e-3243-4ade-bb71-ae90adf3730c"), 490, "Research 489", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("470bcc5c-1e53-4409-be9e-93cbcc7896c2"), 920, "Research 919", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("474d9435-7da2-498d-abf7-e2ead8aa26a5"), 734, "Research 733", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("47661839-02c7-4668-a6d2-305712391e61"), 102, "Research 101", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("4814afe4-6583-4025-a000-49e8ca895094"), 224, "Research 223", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("488d7c9f-e9f4-4cd7-b83d-2b750b90c8e2"), 884, "Research 883", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("489fc1c3-3c10-4b4e-b8e2-5c0c7f384aac"), 644, "Research 643", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("4959af6c-4e37-4fab-81a4-8bcd2862253d"), 349, "Research 348", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("4970a42a-814e-448e-b24e-b618d79481cf"), 30, "Research 29", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("4972eefe-b92b-4239-8ce8-744b7fe70d63"), 193, "Research 192", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("49be6b5f-c7a8-4c2b-9965-08d82b2c1a5a"), 577, "Research 576", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4a28f940-0103-4ba4-a744-3adb89d217d5"), 133, "Research 132", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4a4a049e-5d89-4e48-844a-4b2b579a8d5e"), 692, "Research 691", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("4a8a1b17-fccf-4993-be2c-7431a9f7156c"), 944, "Research 943", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4ab8d168-8424-4fd2-9caf-b2bc988d65d8"), 648, "Research 647", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4b07eacf-c459-499f-94a7-6af3a4432ff4"), 227, "Research 226", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4b104c09-1035-4482-bc51-a7988e2a386a"), 124, "Research 123", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4b4adcc6-83e8-473d-a316-93c4ecab373c"), 72, "Research 71", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4b6d0e77-df1f-446c-b339-941e57e4d11d"), 576, "Research 575", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4b99ea7c-551c-4522-a550-77615052a634"), 603, "Research 602", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("4c1be91b-8948-429e-874f-c78af75aa813"), 137, "Research 136", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4c50b5b3-f1cc-4905-a85b-102a64a0bce2"), 985, "Research 984", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4c7ff0d2-0dc0-4314-97b5-2caa61e2af6c"), 512, "Research 511", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("4cf77276-12e2-4f05-a4a3-fc8e2c3ea59d"), 136, "Research 135", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("4d4aa746-0828-413b-b99b-2b2e3ee13b14"), 642, "Research 641", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4d6cda4c-802d-4246-aaca-d7627558bf62"), 489, "Research 488", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4d7a82ba-a2d8-48de-bf52-c4e9223f6e8c"), 613, "Research 612", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4e27510e-5820-4ceb-9b2a-96296825164c"), 99, "Research 98", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("4ecb3e1a-39c9-44b7-8761-71f8bfe1a873"), 564, "Research 563", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("4ee0a462-1ff3-4412-a72f-aa88f2f44efd"), 83, "Research 82", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("4efa97a5-b525-4256-9b9d-6428e1ed52b5"), 529, "Research 528", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("4f5e18c6-c263-483b-b31e-90ba80bfa41c"), 159, "Research 158", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("50ad9b48-46a7-4c14-b675-a77c4d3734bf"), 358, "Research 357", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("50d0505f-b50f-4836-8b3c-df86b7a97467"), 183, "Research 182", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("50ffca86-36f2-481f-a6d4-6418537a0c38"), 350, "Research 349", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("513fbc8e-2e21-475c-8da0-818d96f9f85f"), 166, "Research 165", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("517222e0-7f68-4948-9c3e-a8fdc54fe164"), 864, "Research 863", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("51a88bc9-0643-4770-b0ac-54fef6845f21"), 854, "Research 853", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("51e23c23-9990-4e06-86f3-1ffbd609d8df"), 226, "Research 225", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("52073a0e-e932-4c7b-b529-224e41311051"), 572, "Research 571", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("5213ab21-4fbc-4f20-b1b0-07227651a626"), 5, "Research 4", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("53987497-9007-4348-9791-032e59e88758"), 242, "Research 241", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("53cb882f-7d2c-4b0b-a398-5ebb6afb4974"), 430, "Research 429", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("54d39aee-80f1-4136-a7a2-92c8c61597b4"), 719, "Research 718", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("54dff778-5f08-4f2c-a325-bdd9d3d7e69d"), 335, "Research 334", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("54fea39e-bb52-422c-9f35-1d587e0a4123"), 139, "Research 138", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("5510db68-c022-4307-bb73-6e8f2e26389c"), 290, "Research 289", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5518b63a-6756-442a-ba17-2f0ace5a44ae"), 203, "Research 202", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("551c6816-e5eb-4daa-9040-557ce84b8984"), 127, "Research 126", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("55478987-240a-4e4a-abb5-a6b28f194bc2"), 307, "Research 306", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("5547c1f8-1136-4449-9a0d-77b868035b9f"), 345, "Research 344", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5559e0c3-7531-4762-abf6-13ccb3ff6e46"), 180, "Research 179", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("558e8cef-b2a9-42f5-948f-b8c467459651"), 809, "Research 808", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("55a0dae3-16d6-483b-8c68-5b10949f193e"), 248, "Research 247", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("55b2dd07-6717-445d-a5de-54c0add1f9e0"), 342, "Research 341", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("55ff3c26-3544-4718-ac3c-56636d9880b5"), 172, "Research 171", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5611f323-fe58-4c15-954d-a562b6099b6e"), 889, "Research 888", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("56725353-4424-4014-9cc1-f949c4a51920"), 959, "Research 958", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("56a9e4f8-3197-409a-802e-0e0fe08175ae"), 638, "Research 637", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("56aa7264-28ec-4908-aa01-ad785ddd2baf"), 217, "Research 216", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("57132456-ef24-4803-8349-eff630e08978"), 705, "Research 704", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5724b7e7-a420-4fd7-83ce-440064894ce7"), 32, "Research 31", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5733a70a-51b7-4ee2-ac9d-a1ad176e42c8"), 711, "Research 710", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("5741228d-294d-47e5-b93d-15da6482c598"), 18, "Research 17", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("57c5173f-b245-42f2-869f-f48edf4dd932"), 415, "Research 414", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("57de89af-2d5d-410e-963e-4e3327528eaa"), 256, "Research 255", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("57e69a06-aab3-4980-aecf-5e3848d39394"), 977, "Research 976", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("57ffdd88-17ea-4ff7-94da-afa833530350"), 968, "Research 967", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("582a2fb1-216f-4576-9f2b-7cd440cc7cfc"), 699, "Research 698", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("586e2ec6-1c4f-4e41-bf1c-c36b2b93834e"), 816, "Research 815", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("592a3994-d18e-426d-a440-5a2c1628722d"), 361, "Research 360", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("59ea1f6d-eec2-41d1-8834-eb347d059e0c"), 331, "Research 330", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5a120b4c-b4e3-41e6-b686-ba3b0af6ebb5"), 558, "Research 557", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("5a4b3a7a-ac2b-42a5-be2b-4e86472767fa"), 464, "Research 463", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("5a9109c6-a11a-411f-9499-f1798f68db76"), 476, "Research 475", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("5a9826c1-439c-42ce-8448-7452a17679f9"), 628, "Research 627", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("5b29aa0b-1d27-4c6b-ad29-7ae1a1668637"), 607, "Research 606", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5b3bfde1-3de0-4ff6-8176-91833bc74e26"), 73, "Research 72", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("5b67697e-faeb-4f81-ac92-761d015cd9c2"), 616, "Research 615", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5bf80568-84f5-4292-b901-d550bdd41679"), 389, "Research 388", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5c056d88-9eea-4fe0-9b22-e39976cc00df"), 498, "Research 497", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5c16c9e3-11ae-4658-91bc-70ab886f6b15"), 979, "Research 978", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5c1d0a95-e4cc-4285-9e2f-fc48bd9fb876"), 279, "Research 278", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("5c26d08a-937e-49a6-9e8b-2c91bae78d07"), 474, "Research 473", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5c6238ce-f1c3-4b34-8b33-0699a3fdabe4"), 314, "Research 313", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5c7ce468-7995-4f3b-8c73-373600769014"), 379, "Research 378", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5c92f4b5-620e-4cb7-a858-049c7d301d8c"), 999, "Research 998", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("5ca46d7e-0fb0-4fb8-bf97-184dbaf89be5"), 559, "Research 558", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("5d2a2e6f-457e-4d79-900b-6497c4c4d23d"), 843, "Research 842", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("5dbb6541-39cb-4be0-9595-9f7aeab860ca"), 161, "Research 160", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("5deb4b9a-0aad-4840-89f3-3adf6fa960d5"), 588, "Research 587", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("5e31ba7b-1458-4194-835d-908c55e532b9"), 43, "Research 42", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("5e34c1a7-ba4b-40ab-a3dc-2ff2bd734099"), 496, "Research 495", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("5eff373a-071e-4094-bd23-548f6c9f99b8"), 791, "Research 790", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("5f3a4275-adc8-4283-8c07-80be68aca009"), 142, "Research 141", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("5fe2ad12-82a6-4602-83f9-79c96518a19f"), 58, "Research 57", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("601597bf-cce5-4d44-bab6-c01d6241dfa8"), 10, "Research 9", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("605bb494-a7fe-4d66-9844-ee99543b391f"), 551, "Research 550", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6066fc16-133f-4144-9ed8-303f58e5a567"), 318, "Research 317", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("606b6868-c837-4e1a-aa88-5a309f1177d0"), 995, "Research 994", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6106eafa-1ba4-4848-8d63-576a2d917e62"), 366, "Research 365", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("61649b15-6e01-49a2-852d-1a0544ee4d1f"), 761, "Research 760", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("61678bd6-2f3b-4f94-9ebc-1edf23f43d59"), 930, "Research 929", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("618b517f-3cf1-4025-b624-ebcb2ccd6c25"), 493, "Research 492", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6195ab9a-a04e-496c-ad48-c27391fb002c"), 109, "Research 108", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("61eb41c3-8982-4ed3-8e16-0393c7ecde1b"), 936, "Research 935", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("620ff750-b5aa-4c4c-be59-d7ff6b2ad79a"), 571, "Research 570", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("621edd29-37af-4af1-a6e8-2790a0d844c4"), 916, "Research 915", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("62b91573-2734-43bb-81b5-ff4e31c61212"), 859, "Research 858", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("62fcfb94-53f1-4245-9bba-9e4f1e82fa68"), 727, "Research 726", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6355a017-1685-4849-872d-b30187045e87"), 384, "Research 383", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("64135a85-6bca-411d-bfaa-afc32d93786f"), 247, "Research 246", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6422024a-6fd0-4f58-81c1-5b8820b830a3"), 76, "Research 75", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("645eabdd-cf1f-4915-b533-17704d56162f"), 4, "Research 3", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("650a117d-4ce6-4cb1-bef3-f3687dda8028"), 298, "Research 297", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6547c1dc-76cb-4bb3-89ba-914ed68d6166"), 241, "Research 240", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("656bb685-6896-4f53-a280-fe0a89e4f048"), 336, "Research 335", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("658d2067-dbe0-43f6-8afe-a043d3cf4459"), 486, "Research 485", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("66abf729-d40b-4b2d-b325-a494e028854e"), 663, "Research 662", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("6704200b-7fb3-4496-8bab-8eefeb1556e5"), 212, "Research 211", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("67926da3-2f94-42dd-a677-fdb6c4e05c4e"), 413, "Research 412", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("68e8689f-85a5-439c-a57e-cd0813703504"), 271, "Research 270", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("69527a4e-5147-4814-af6b-17cf4800449d"), 656, "Research 655", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("69b0da2f-6b5f-43fc-8aac-71e054001e00"), 622, "Research 621", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("69db1904-55be-4ff7-908d-147777eb672d"), 546, "Research 545", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6a0f2a13-7909-4760-bda8-f1c813d8e866"), 373, "Research 372", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6a46ee77-8df6-4305-82e3-7e22d175736b"), 438, "Research 437", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6ab22fc4-f3f7-4b9f-bc45-14a292855a3d"), 16, "Research 15", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6ab70a61-80b2-4c97-bc2d-4bc51aaf9ea8"), 545, "Research 544", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("6af5fd33-980f-4f99-ae06-264ff398edb9"), 27, "Research 26", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("6b1e0e92-c441-4612-8674-c6ff13430948"), 645, "Research 644", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6b2e6726-fb1f-4a2b-b34b-7b728c11c854"), 674, "Research 673", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6b6e3f85-14d1-4669-b3e2-9629fe83a2ae"), 1, "Research 0", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6b6eb72d-76da-4739-af3c-29f73ecf8fba"), 121, "Research 120", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6bab5668-ae2b-4c72-9d38-f4a509296712"), 478, "Research 477", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6be5af01-24cd-4af0-a73b-445a732fae86"), 753, "Research 752", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6c18b09f-7a17-4f69-96bd-e74ea70cf75c"), 232, "Research 231", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("6c688cc4-77ce-413c-8e91-a1846af14767"), 59, "Research 58", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6cbab267-369e-47f4-9dc1-5ef3e99132ab"), 608, "Research 607", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6cbe8ef6-a352-4fa8-9571-8f4e2e7d1d92"), 186, "Research 185", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6cefafa4-a643-4e3d-a795-ecd26857894e"), 580, "Research 579", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("6d8a262f-c3a5-4523-a145-47a8a419412d"), 341, "Research 340", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("6dae56a7-8903-4156-9259-83e69b639150"), 218, "Research 217", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6de90394-edb5-4451-91e3-4a14d68b60ec"), 808, "Research 807", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6dfd4e44-908b-4cf5-a3b9-66ac1f9ddf0f"), 118, "Research 117", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6e22455c-8592-4d5f-9724-1f24832874de"), 343, "Research 342", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("6e2a0a07-6f4d-4d4d-850f-1476e1702c7a"), 955, "Research 954", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6e423dda-5b46-4cb8-a666-65e904eedee8"), 858, "Research 857", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6e8f0f42-6a6c-4050-acfb-6589dfb393af"), 918, "Research 917", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("6ecfbe58-f1bb-437f-b989-2bfc793925b4"), 745, "Research 744", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6eed86aa-3bc6-455a-9a26-106bec008577"), 250, "Research 249", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("6ef3c39f-59c6-444d-a48a-333bf9500bf7"), 368, "Research 367", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("6f0d5f66-6be4-43f0-926a-dd93221a3c73"), 860, "Research 859", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6f388c7c-8384-4328-b9d3-43514347ec67"), 406, "Research 405", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("6f3b3315-c5be-4582-a6af-a72fb5e6090f"), 686, "Research 685", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6f428552-ca29-4624-832f-d8ba7ac207eb"), 681, "Research 680", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6f5243e6-d76e-41e7-a9e7-4a6bd1b79341"), 448, "Research 447", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("6f746245-1222-4837-b731-8c902e1e0138"), 50, "Research 49", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("6f809a70-b62f-4cb2-ba54-1b6cada54781"), 660, "Research 659", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("6fa478b6-41a2-4733-9552-ef583432900b"), 246, "Research 245", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("6faa5b5b-037f-4827-b3b2-b623ce30eeb3"), 147, "Research 146", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7057c1bd-d8e9-49be-aaeb-414e92953be7"), 357, "Research 356", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7079c204-ca62-403a-bc51-0b687b6c15fd"), 289, "Research 288", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("719cfb95-330c-47fa-a39d-b5e32a8d5253"), 461, "Research 460", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("723b580c-9c16-4667-ad40-b3a441139243"), 680, "Research 679", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("725f437b-41d4-43ab-9958-fe748568932f"), 453, "Research 452", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("726257bf-ed5b-4c05-ab07-67fb7c5ecc3d"), 31, "Research 30", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("72895ce6-7a1d-46ff-a7aa-f626d01522a2"), 536, "Research 535", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("72fc25db-6f5d-408b-b9cc-ca68035e6c02"), 640, "Research 639", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("7358028a-b2cf-4cb1-a64b-859b643b67ea"), 875, "Research 874", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("73b13039-a9a7-4b0a-b71d-e7bd840982ab"), 665, "Research 664", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("73b5e69f-23a1-4afb-875e-a824e3b404c5"), 427, "Research 426", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("73bc4920-4bfd-4c3a-87e1-c4d6d274be08"), 873, "Research 872", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("74191a03-0063-4560-b0b4-01d264136356"), 375, "Research 374", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("7435f2de-a65c-4787-bdd3-af4006136635"), 847, "Research 846", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("74efd951-df61-43a9-8fa5-fe142969e623"), 260, "Research 259", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("75706127-b54f-4dc1-91ad-d28ada09071a"), 112, "Research 111", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("75728867-a664-4d59-80d1-ca9f36f1d3de"), 967, "Research 966", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("76139537-bac0-4187-a9c5-850b2c903ce8"), 437, "Research 436", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7659a5bd-d35d-4e33-833b-20953792a2e7"), 903, "Research 902", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("76b59c00-cff7-42ab-bfa8-e1b1550b7c0a"), 677, "Research 676", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("76b5e8b4-25dc-488f-92ff-db3e46b6350e"), 866, "Research 865", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("77a0bc65-7688-4995-957b-d4d684b9400c"), 735, "Research 734", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("77b77f75-d6ca-414d-9c0a-8580a3d503d0"), 784, "Research 783", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("780969d8-e4dc-458b-a1fe-b2cfe34918b2"), 702, "Research 701", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("792b2d01-b83c-485b-b8a2-f49179fd38c5"), 6, "Research 5", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("794e3172-4605-45e9-bedb-9c69fc78df66"), 388, "Research 387", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("7967f83b-01b3-4962-8e9b-bd67ab76adb9"), 935, "Research 934", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("79f498f3-6f9f-4024-87fa-85e6dd952f4b"), 24, "Research 23", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7a2058a0-7ac3-4fad-a5ea-1e4d1d76722c"), 982, "Research 981", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7a3c402a-c814-4e30-9872-f8e7bb3438ee"), 19, "Research 18", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("7a40e9e4-04cd-47cb-a6e6-edc6696a4c26"), 77, "Research 76", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7a5d7939-b3fc-4750-b3c0-c7c9a50a406a"), 487, "Research 486", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("7a5e3f0f-6ee0-4ee4-9fc8-f3529e83c24b"), 862, "Research 861", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("7b0662e3-7ade-4072-b3c3-4d8b7bb4dfbe"), 538, "Research 537", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7b21cfad-c872-46d8-99f6-1bba9e272758"), 962, "Research 961", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7b2debba-c501-4574-94bc-71d7c7410ff4"), 9, "Research 8", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7b361e65-ea0a-472b-bf14-0273a5ef889e"), 190, "Research 189", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7b4694e8-03a4-42ce-a299-6f183a42e3f1"), 940, "Research 939", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("7c4b16ae-ceeb-460b-8bed-30b3a2f7cb63"), 274, "Research 273", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("7c77e031-e30b-4eec-8f58-7dcb35b347f5"), 38, "Research 37", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7c8ac1f0-949a-4c2c-8fd5-07adae2f79f9"), 475, "Research 474", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("7cbd0672-5092-4ffa-8262-6fa031eade0d"), 421, "Research 420", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7cc9303a-820c-4345-bd22-07f533cce45c"), 374, "Research 373", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("7cd63be4-63f4-42ab-80d6-fee36c4b7d9a"), 90, "Research 89", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("7d2edfe1-2cb2-4f94-adcd-3a998b784659"), 409, "Research 408", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("7d314313-653e-46e9-a54e-1c53f1e45951"), 993, "Research 992", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("7d70b345-612e-42f1-bdc2-c9804e41cc99"), 158, "Research 157", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7dbc7739-b01a-4dd2-9db7-087f72f2efce"), 294, "Research 293", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("7e4929d9-8488-4043-9203-47d579f5bc5a"), 273, "Research 272", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7e65a800-0cfa-4971-9201-347e8d474a2f"), 562, "Research 561", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("7ec2705d-2e86-4cc6-a001-8993236015d0"), 189, "Research 188", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("7efcb88c-9034-4cf3-836b-2c68873633a3"), 909, "Research 908", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("7f83b168-7f94-4053-ac67-dcfb2ab3328c"), 631, "Research 630", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("7fb0b23c-2b25-4371-88cc-5727efac268b"), 970, "Research 969", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("7fe44f6b-c595-427b-a957-f1da338ddcde"), 477, "Research 476", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("7fea92d7-5fab-4178-826a-a957d32a0e77"), 14, "Research 13", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("8014e3e0-7c01-44b2-b562-34c34d2453ce"), 579, "Research 578", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("8070e0c4-2aa5-4f6f-a9f6-86588b8f0481"), 682, "Research 681", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("80c12acb-e285-491d-a85d-fa4caf658848"), 443, "Research 442", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("80e3c7ad-52f3-4f44-9872-ca9e9dbe928d"), 927, "Research 926", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("810a95db-689f-4b1e-b036-8a710edabb8f"), 244, "Research 243", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("810e6c1f-1015-4b5d-b044-1dec708213e8"), 763, "Research 762", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("814bc284-fd02-400d-86c7-10d0ce207c3b"), 754, "Research 753", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("81a01db2-8114-4538-a948-4d48f7fbe9d8"), 817, "Research 816", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("821378b5-e1a3-4aef-a470-bbf36ab7955a"), 195, "Research 194", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("8302e35c-bda5-4bf1-91e4-cb6ea756a36b"), 672, "Research 671", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8326c602-0d32-449c-9522-9cde4019bf12"), 417, "Research 416", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("834103de-224d-4bcc-9fee-7fb1bd2d8272"), 22, "Research 21", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("839de534-2f7e-474a-a018-b5a63be0f346"), 617, "Research 616", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("8442cb5a-d6ea-4b01-8f88-4a744b8bb4c3"), 320, "Research 319", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("84adc791-51e8-42d5-85d0-fcf82860bda9"), 527, "Research 526", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("84cfdccb-c825-4ffb-b694-9195fca0ab70"), 235, "Research 234", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("85d4c80c-124a-4c01-b064-5b450ae1748d"), 454, "Research 453", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("85fd7480-416f-40a2-b12a-0d721a20f30a"), 595, "Research 594", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8623e933-94dc-4ff3-a3f5-05bac887a1ae"), 543, "Research 542", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("86d6f572-fdf6-4353-acbe-885bb545feb7"), 339, "Research 338", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("86df7d13-8ad4-4a50-ab90-0182d63ac2a2"), 800, "Research 799", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("876be11b-f597-4252-8ef5-4c3d1c778b28"), 259, "Research 258", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("88071d72-2d6f-4dff-993f-3c4f8c5be6e7"), 257, "Research 256", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("880b6bbf-418b-482b-8733-808216a127d1"), 762, "Research 761", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("8908f63a-43b5-4a72-9cd4-ae82e0158e93"), 516, "Research 515", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("89434245-6484-4db6-92dc-305f53235935"), 818, "Research 817", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("897a06d4-fa07-4960-b6f5-a33cfebdacfc"), 387, "Research 386", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("897b53e5-0b2f-4bbe-b618-cbb9ef385471"), 404, "Research 403", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("89c1e4b5-b58e-4455-ad73-3849f0bd7564"), 394, "Research 393", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("8a292f84-84b5-49f1-856d-28484a092dcd"), 482, "Research 481", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("8a489d8e-dd97-42c5-b531-7606b01c34ca"), 346, "Research 345", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("8ae72c7b-4763-4ff7-a5f0-cba9dab4663d"), 63, "Research 62", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("8b3005bd-2046-4348-b064-e016e8223975"), 315, "Research 314", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("8b48f1fa-8c4f-46ee-8311-12042ae4f3ec"), 958, "Research 957", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("8b547232-485d-494e-991a-246f2c9fa1f0"), 53, "Research 52", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8b702e6f-1b03-4752-a35d-5fe8ca01e14e"), 963, "Research 962", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("8c32e859-c06f-459a-a509-75d18ed01009"), 231, "Research 230", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8c37fe2e-13b0-4e0e-8d94-4cfd1546dcab"), 510, "Research 509", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("8c3c03d3-8c5f-43d1-9c2e-2afcc49ff993"), 886, "Research 885", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("8d7ae36a-29c3-4473-86e2-5b65937d0759"), 649, "Research 648", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8d85b450-469a-4cb3-9b42-74e362116fb1"), 198, "Research 197", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8d8f9a62-73a1-44c9-92c2-3684748050cf"), 591, "Research 590", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8d9f33b4-d3f1-4a14-a627-ac7579224fd7"), 285, "Research 284", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("8de3997a-4f9d-49d0-859c-9581e763206a"), 152, "Research 151", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("8de4313d-fbe4-460c-8552-caafd0e6bd4a"), 251, "Research 250", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("8ed53fa0-c74e-4416-a7bf-8183dbb567fc"), 888, "Research 887", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8f919bb3-2068-4125-9fd3-6a9d2fa87f8c"), 853, "Research 852", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8fb631dd-2469-47d5-ab7c-5f5dff8c2b80"), 21, "Research 20", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("8fb801ba-5c62-494e-9b4c-09575a4fc4e7"), 539, "Research 538", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("9037af64-15e6-47e0-8429-7452adf9e4e6"), 569, "Research 568", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("905935d7-c858-4736-9695-0e6d6858d3ce"), 446, "Research 445", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("907392e6-5d1e-4e00-b422-8ee48e45e08c"), 765, "Research 764", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("91113baa-d8aa-4d04-8334-8f8d7f0ae045"), 420, "Research 419", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("913dac12-3137-413a-8587-1b1e757e5954"), 221, "Research 220", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("91c25e49-bf44-4f5d-b99e-27977c7a60f8"), 773, "Research 772", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("92174e6f-edd5-46e8-8efe-10a7f0dfe32c"), 530, "Research 529", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("9268e507-1b7a-41f1-82c2-365b0b8df65f"), 931, "Research 930", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("92fc55d8-3f3f-4629-87b5-c0cf4812ea92"), 94, "Research 93", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("935c97ce-817f-4229-9451-356111d515ad"), 511, "Research 510", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("941584bb-c281-4ece-8e4b-b5b87dedee4b"), 507, "Research 506", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("94394d36-c995-4041-a5d4-6bb6363801f3"), 833, "Research 832", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("94695fba-16fd-4af1-8ec0-1ef0f53a8f26"), 736, "Research 735", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("9470d703-49b6-487e-b489-81a32568fe53"), 249, "Research 248", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("948c3537-fb26-49fe-9cf2-d6db5f1158da"), 882, "Research 881", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("95327695-d3a1-4253-9afe-24b7f2728e9b"), 55, "Research 54", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("957bb244-9bb4-4287-bd89-732e54430ddb"), 922, "Research 921", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("957e39e0-0713-469f-bf2f-8f2814e50b66"), 777, "Research 776", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("9598cb78-c8d1-4f48-acda-580e076df634"), 764, "Research 763", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("960199f5-6de7-4995-85ee-a7129bad47cf"), 849, "Research 848", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("960babc8-79a5-4ec1-bdf5-ec41529a0394"), 23, "Research 22", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("963e1847-2f09-460f-92c9-400db23bd3c8"), 81, "Research 80", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("9672c801-8ef6-4f0b-91cc-bcbf5c6772ef"), 494, "Research 493", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("96ad263e-fb4d-42c6-a527-896686ab96c9"), 964, "Research 963", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("96b23f6a-5aec-4d7a-9e21-001c135b1309"), 793, "Research 792", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("96fd39d5-ba8e-4b5b-818c-678dc847fad0"), 282, "Research 281", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("972109e5-e785-440d-8b27-3e74d292e717"), 178, "Research 177", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("978ca230-997b-4626-b6bb-c8cf853ab389"), 261, "Research 260", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("98c687b1-d7fb-43aa-a932-6bf3fa21afde"), 722, "Research 721", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("98ec7e6f-980d-4d66-82e3-b0bc7ff64989"), 149, "Research 148", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("9940f913-5ff6-4aa4-b097-9938fc49afeb"), 661, "Research 660", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("999049a5-006a-4a96-96f7-4109125690f0"), 696, "Research 695", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("99cfaeb3-75e2-4327-bcfe-7c0198d826e1"), 782, "Research 781", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("99e3ed60-29e7-4061-b98a-bf44b3705545"), 840, "Research 839", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("9b530ba3-e4a1-4835-92d8-40929361d48f"), 637, "Research 636", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("9ba821bc-aee7-4e26-b96c-8975fe13aea4"), 150, "Research 149", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("9baa1b1f-1692-4b16-946f-ee33487ca118"), 376, "Research 375", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("9bbae8cb-802f-464c-9fd0-2a42ffe7a245"), 851, "Research 850", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("9bbd60f3-a92a-43f1-959c-caa58bd6d5d7"), 450, "Research 449", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("9c406995-d8be-4d8f-ae4f-20ac0558e5f8"), 452, "Research 451", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("9c686c61-bd49-468e-b0d7-3f778e211e31"), 138, "Research 137", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("9ca68fb3-ea51-4517-a35a-559f40cfb872"), 465, "Research 464", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("9cac5f65-40ac-495d-91d4-929eca664478"), 521, "Research 520", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("9cc8520e-bd96-4095-a408-7d9616d2c69e"), 897, "Research 896", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("9d5720b5-f675-4428-b306-addf12a641a0"), 351, "Research 350", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("9d5de4a1-208e-4115-bdae-aeb988e11aa1"), 308, "Research 307", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("9d6d293d-02ad-4ea9-ac75-bf7374b24da7"), 500, "Research 499", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("9daac3f1-0110-4346-a945-08728e62ab55"), 650, "Research 649", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("9de651c8-0282-4106-9507-112c4cd29d34"), 794, "Research 793", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("9df1424f-0524-4183-acfd-964126b1bc69"), 618, "Research 617", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("9e1735bd-78fe-442e-9ab3-d8cea9ad5d26"), 743, "Research 742", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("9e77c5ef-e8f3-4e96-89d0-f5b80486e796"), 971, "Research 970", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("9e8b767f-e2c7-4a45-9ca5-4ae0cc8057f8"), 789, "Research 788", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("9ea0d53a-27f5-4686-b7a2-aa1e4bced9f9"), 473, "Research 472", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("9f3f186d-b557-4911-a23b-cd37c3b54733"), 671, "Research 670", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("9fa89d1b-c24a-4c2e-8d33-33202b4d074b"), 519, "Research 518", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a03f33bf-972e-4d9c-9477-d250182035ff"), 46, "Research 45", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a0861c3d-6db9-450c-883c-067443cfe3ed"), 258, "Research 257", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a0b94f16-2673-4355-abb5-c6b45c13ce6c"), 732, "Research 731", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a0c0553c-c86c-41e5-a08a-329112ca7237"), 767, "Research 766", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("a0d84a88-7255-4f5d-9c20-6463c87f1d19"), 932, "Research 931", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a105500c-2293-44e1-a68e-5e3dfcdeef64"), 769, "Research 768", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a1126da8-1410-40bc-b652-1c0d7c2a5d44"), 766, "Research 765", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a129b492-92fb-4543-ab39-2fac42809b15"), 243, "Research 242", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a140404e-ece7-4bb7-bc4b-37bb4afd941b"), 666, "Research 665", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a177265a-8736-4d75-925c-379792c9e740"), 520, "Research 519", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a1bfb789-1777-49ee-a2af-ce3d3d006512"), 301, "Research 300", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a1d2b001-dcc4-4255-a7c1-c6215a5ea39c"), 423, "Research 422", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a1eda045-150c-442b-bbbf-08e36c8ab148"), 802, "Research 801", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a29fd5ae-6501-4296-9731-6643eaf15bd6"), 398, "Research 397", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a36d091d-b709-4e5b-85dc-0ace4320c8e9"), 857, "Research 856", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a376633b-c458-4094-815b-619ff7936f61"), 709, "Research 708", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("a3b3dff4-3439-491a-b6ed-0a772ed43c20"), 312, "Research 311", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a3c4cf05-e70e-4a86-8e71-a2c69a901311"), 746, "Research 745", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("a3c873dc-05a2-464f-afd0-3193c61d0245"), 89, "Research 88", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a3cc5168-650f-4b27-bca3-8bcf18a7369a"), 123, "Research 122", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("a3ce2038-5418-4c59-8522-ac101384cd1a"), 214, "Research 213", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a4224836-2213-4659-bec2-1604056e7e57"), 810, "Research 809", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a47da957-3fe4-4a73-923d-b1f903558901"), 170, "Research 169", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a4b7237a-1e09-44a2-b1a0-b4592eb7ebab"), 786, "Research 785", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a5017f6d-45dd-4e12-bc6c-c7de97b58600"), 928, "Research 927", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("a5624f77-8be2-4e3a-a61e-3d57eb730d71"), 712, "Research 711", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("a56b7d24-f260-4225-bfa3-c57dd57f277e"), 653, "Research 652", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a58d3054-bd32-4042-b026-c037686cb7e5"), 915, "Research 914", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a5b46d74-8e41-471b-a69f-5e9fcc390d8b"), 267, "Research 266", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("a609789d-8fda-4310-b486-a87ee75bbd23"), 874, "Research 873", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a623b38b-841a-4b93-a2e7-480e674ada6e"), 447, "Research 446", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a6254ff9-e483-47cf-85eb-7676cea1935e"), 74, "Research 73", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a6361deb-27ed-458d-a3ed-499b0d7333c0"), 730, "Research 729", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a649692d-f2e7-4940-b788-910be4a04a67"), 933, "Research 932", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a724d488-59a5-4592-bf02-48bec0d0605c"), 871, "Research 870", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("a7cf116e-88e3-49e4-b089-33b61e8053ac"), 612, "Research 611", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a7da85dc-a6d6-4305-8063-d0377cc8fc8e"), 899, "Research 898", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a83d9eab-e92f-4c8f-8e83-c0588ddbca82"), 67, "Research 66", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("a889c564-3dde-4e9a-bc20-c6162bf174ef"), 199, "Research 198", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a8b6f054-f334-4adb-89e9-da2dbbe15072"), 834, "Research 833", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a90fbbab-9983-439b-89b5-7ac2bb6f8e78"), 658, "Research 657", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("a9318e85-1af0-45c2-88c3-b5afdc214fee"), 683, "Research 682", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("a96a43aa-a45d-43ed-a549-d1c55f4ee13e"), 733, "Research 732", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("a9decc87-f802-473a-a451-b11a2bf16a8f"), 444, "Research 443", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ab7fe38e-7756-414a-ad01-dd9583b7dafb"), 154, "Research 153", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ab85dd6d-0936-4bd3-af00-5b9076bed80d"), 91, "Research 90", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("abeed900-d2da-4003-a5ff-8fd9ab98d44d"), 592, "Research 591", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("abfc5ed5-cb36-4dc6-8c4f-59c235f6e4f8"), 352, "Research 351", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("ac2f890a-37ad-4c5f-a108-3639f283a9f5"), 334, "Research 333", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ac8856d1-e44f-4bfc-889f-ceaaca516ed3"), 839, "Research 838", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("acb7dd6f-48fb-49f2-8dd2-85f8322c1639"), 652, "Research 651", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ace0b143-2619-4680-94ef-71a3d7119513"), 590, "Research 589", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ad252edc-063f-420f-ae50-28f4413e0045"), 410, "Research 409", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ad47fa90-cc7f-4ec6-9119-e05c360387cf"), 517, "Research 516", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ad4b7db7-7329-41f5-bc06-aac8a08899f7"), 956, "Research 955", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("ad6f90bc-d875-4962-a3fc-a911f404996d"), 347, "Research 346", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("ad754fe3-9a28-40f7-8908-b9a9707a8de3"), 372, "Research 371", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("adee4a43-69e9-4fec-ab50-a76d26bd6172"), 403, "Research 402", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("ae76f670-ebb7-4910-ad24-68af1ffa91ed"), 47, "Research 46", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("af9e4f52-23b1-42b2-874c-b9164f15bad0"), 740, "Research 739", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("b049004a-c820-416b-bd7c-698f8a18e981"), 548, "Research 547", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("b0c86536-b427-42f2-9fdb-25df108f0b2b"), 540, "Research 539", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b12fb280-37f7-4af6-9e9a-e6e8c430896e"), 872, "Research 871", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("b13b6b7b-a5ef-4bfd-b38e-c63bff8d8fa0"), 606, "Research 605", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("b17132a6-4ba6-4703-b330-f07ed4c8b854"), 503, "Research 502", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b195e676-d287-4039-81f0-55c536cdc177"), 495, "Research 494", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b1f5fe37-e74c-4f69-b71c-64c23ba37999"), 533, "Research 532", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b22c4dfc-5b08-40af-86ed-a80dfb257d6e"), 117, "Research 116", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b27f4222-0cfa-43d6-a81a-d1671e92d04b"), 720, "Research 719", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("b28ab721-6a77-4037-aff2-fcf4d659bcfa"), 458, "Research 457", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b2d06695-27bb-436e-9f9c-d48d4f58f8df"), 356, "Research 355", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("b2d8b895-1bb3-4085-86d3-ef5ba6e8e838"), 64, "Research 63", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("b320aed9-2b54-4333-b633-ed7f9ddf4d28"), 177, "Research 176", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b3336d67-2158-44e2-a24d-e11328e86020"), 278, "Research 277", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b3a79f76-69af-452d-94db-a391e825c456"), 568, "Research 567", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b3d2724e-3de8-4c21-946b-7ac8a029453b"), 204, "Research 203", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b45aa2b4-d26b-4697-9396-4edbbf38c8b3"), 599, "Research 598", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b49b7f46-55f3-4426-9fc1-30fdec2af352"), 601, "Research 600", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b4cfaade-f856-45d0-ae0c-f96712bfe818"), 26, "Research 25", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b53097dc-6f46-4fbb-8493-ade00dbeeb4a"), 981, "Research 980", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b553249d-1991-4ae6-88f5-6c47d761e58c"), 647, "Research 646", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b553d017-3a59-4299-9efe-d8454275eabf"), 878, "Research 877", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b573ed2a-f36a-4a1d-a216-e8914ea5a3f2"), 362, "Research 361", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b5752fc2-590b-49df-b065-f2bda10b6ea1"), 908, "Research 907", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b5e1b8da-28c6-4007-adad-868d98a810a4"), 830, "Research 829", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b5e6f7eb-df14-4258-a85d-c87aa3f6a91d"), 291, "Research 290", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b5e7f86b-1c18-4ec3-9c8c-360dfd2a5929"), 514, "Research 513", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b60de26f-ff8a-4505-b46b-18de2101ad4f"), 56, "Research 55", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b61db953-6bf3-411e-826f-aeb342ea0494"), 440, "Research 439", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("b6b34094-e23f-499b-b659-0ad6de69ae9a"), 96, "Research 95", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b770dec2-a3c6-470c-ae0b-c4d6bae8e7cc"), 924, "Research 923", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b7a8ff46-deb5-4e99-b827-1bfb31c1fe9c"), 799, "Research 798", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b7b708bd-1898-4555-a007-778d90efc950"), 422, "Research 421", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b7b90593-7538-4a7f-be76-4d52b1f64a64"), 386, "Research 385", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b7e0b2e2-30a3-4732-a62b-de9e89ba3826"), 103, "Research 102", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b7eadcab-c007-472f-866d-e7c6e33d12c3"), 750, "Research 749", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b7ef8840-54d4-4e2f-91f0-30e6db96e8dc"), 774, "Research 773", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b8192031-d110-493c-bda2-ce42204937da"), 589, "Research 588", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("b8471760-e01d-42c0-aa0c-64d118efd46e"), 611, "Research 610", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b857d0ee-3df4-4043-8a63-b134573b0549"), 700, "Research 699", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("b8bc890f-0efa-4a49-869e-2317eccc1abb"), 229, "Research 228", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b8c51070-3c2e-4485-a11a-c9972720212f"), 913, "Research 912", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("b8ee12a4-a26f-40f5-8699-51d44879c071"), 812, "Research 811", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b8ff1578-0163-486d-bb1f-ed228b5d4a12"), 115, "Research 114", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("b92ca045-d9f0-4775-b3c8-ab8330bfe2d9"), 383, "Research 382", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b9b97de9-403f-4b48-bf3c-65f50ac8cf0a"), 829, "Research 828", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("b9c5d50f-e7e5-4c79-ac4c-249f000140bc"), 597, "Research 596", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("b9e5799b-093e-4e2d-829b-8a3c9f665020"), 684, "Research 683", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ba5bd022-e1dd-4bcd-b782-0e8520fb25f0"), 416, "Research 415", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("ba7aa65a-edf6-46e9-9f7d-4b1a4c1901aa"), 200, "Research 199", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ba8ed286-1ea3-458e-b355-6945bd47ddcb"), 636, "Research 635", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ba95ba97-b0b6-4bad-91ad-f3f5fc64fea7"), 824, "Research 823", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("baafcd3e-8ea1-440e-93b5-5205562c1c71"), 691, "Research 690", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("bb19a8e4-1d78-4b94-a88b-b6a024d5e7de"), 303, "Research 302", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("bb2a30cd-c12d-4253-a282-151e06729724"), 807, "Research 806", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("bb693d20-ae4c-4910-8f68-a29253d47402"), 106, "Research 105", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("bbc3a2c2-ff69-4a3e-af37-beeb89d528ac"), 605, "Research 604", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("bbff6457-22b8-41fe-bd34-1cc14395303a"), 182, "Research 181", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("bc0b79de-ed80-4840-a1e0-14abe4aaa88b"), 988, "Research 987", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("bc1fde71-5729-47a6-ab19-9afff4ba77fd"), 429, "Research 428", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("bc39ba91-8796-4836-8a44-e9072671e089"), 687, "Research 686", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("bc64cbad-2a33-4467-9c6b-2f7e2871404d"), 184, "Research 183", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("bc668285-c9b9-47ac-b52e-fba96f4d5d26"), 62, "Research 61", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("bc940acb-fd76-426b-9ce8-616fc7ee71e7"), 844, "Research 843", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("bcad4212-5a98-4deb-bd53-2265986bc461"), 365, "Research 364", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("bcaf182b-4160-4a81-a6b5-f689d839c298"), 896, "Research 895", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("bccfd895-c478-4251-9b60-ff9668c239d7"), 845, "Research 844", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("bcd09400-254d-4d62-ac4b-1dbe4939ae60"), 380, "Research 379", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("bd142bbf-7955-49ac-b04b-9ed89aaed42b"), 295, "Research 294", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("bd830097-535a-4d9f-9b30-4222b44eadb8"), 78, "Research 77", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("bd9c0b70-67c2-4469-97a5-e3117a369933"), 819, "Research 818", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("be501414-cff2-4a12-a1c2-24474b118a8d"), 297, "Research 296", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("be6cd960-5c25-4bdc-b714-e6ba3b977c4d"), 160, "Research 159", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("beab66b9-b770-45d6-b07c-f223fe424136"), 654, "Research 653", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("beb98772-afc2-40b4-9c02-0237cca0946e"), 327, "Research 326", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("bebda79b-303a-42c7-9216-1f605e071c51"), 35, "Research 34", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("bed0b9fa-0872-4ee4-916e-fbdc04ea318d"), 194, "Research 193", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("bef68fed-edc6-4582-916c-ecdb1dbfea1b"), 395, "Research 394", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("befae299-a453-4ff3-bb05-c09aa7288f1a"), 441, "Research 440", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("bf22b3b1-d0e5-46ff-8715-3e7ba00afc09"), 396, "Research 395", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("bf3667c3-60e4-4961-abbf-ddcf9e4402e0"), 88, "Research 87", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("bf5e7733-b4ce-4e91-bfb4-6ec6d4a43751"), 288, "Research 287", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("bfc580c9-32c1-4c41-b2df-788e0de364ae"), 479, "Research 478", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("bff171ce-eeaf-4dad-928f-4f7a3560b3c8"), 953, "Research 952", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("bffb5561-27a4-48ea-84e2-40b1088d85c3"), 910, "Research 909", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("bffc9a3d-e5b0-4d62-bf55-0715f1374f9a"), 838, "Research 837", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("c00a43df-1e52-424a-9faf-c5b5d0240570"), 528, "Research 527", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("c019e1e4-85f1-41ad-abb4-d0e87bfae3b6"), 563, "Research 562", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c0443165-1fcd-473f-9fc9-cd7a8854c18b"), 377, "Research 376", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c05fd604-b87d-4639-b93f-0c684bce7da0"), 143, "Research 142", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c086c6ac-d432-4720-9aac-12b477765837"), 44, "Research 43", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("c0fda060-68be-484c-9591-95c0159575a6"), 643, "Research 642", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("c12d6586-2dc6-4ead-81d8-223ae88daaf8"), 632, "Research 631", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("c1424517-ab57-44f8-9535-2c284d31f839"), 726, "Research 725", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c158c179-43f5-444c-ad0e-2b075e0799de"), 921, "Research 920", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("c178229e-6ace-4696-9fff-9fb126f742bf"), 813, "Research 812", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c1db624f-1575-4536-82e5-4d28188b6c37"), 938, "Research 937", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c2040483-535b-4392-8104-bf4b6d4d3587"), 790, "Research 789", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c228f75b-997b-4fe4-b6e9-4e9841100a3f"), 723, "Research 722", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c295d7cc-068e-46c5-a91e-1ab4a5f49225"), 518, "Research 517", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c299b6d3-a590-4aee-88a2-f7d1a3ef845e"), 49, "Research 48", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c29e8b47-059e-4cae-92c9-4c1f192e42a1"), 837, "Research 836", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c340fc4f-a0c4-4ac5-8f00-f35c22ed7f10"), 283, "Research 282", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c38a72b3-a6c7-419a-91c6-95571353153d"), 167, "Research 166", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c3a16ae4-6ef8-432a-ad70-1bc2db7e743c"), 436, "Research 435", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c3b6ebba-3487-460e-96b5-409f2f66cdb3"), 659, "Research 658", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c3c5e6e4-ec43-4177-bb35-fd0a8891a2f5"), 202, "Research 201", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c3d747bb-2787-45e9-894b-4954aa24bb5e"), 863, "Research 862", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c4d56284-f7fe-4b07-bd5d-78ef13de1133"), 690, "Research 689", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c52c992e-0768-4eb2-b54b-4c5ccdbf9382"), 737, "Research 736", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c52e19df-b3ff-45b2-ad7f-935b45d99411"), 326, "Research 325", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("c5fd998b-2da4-4349-825f-4beb5ba40e93"), 469, "Research 468", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c64931bf-7b5f-4130-b557-ed7a812acd68"), 811, "Research 810", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c6b16bba-192d-4a8e-ad80-4b455bfc5da1"), 459, "Research 458", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c70d09f1-3299-4e3a-8460-b236a271d3d9"), 135, "Research 134", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c72d7af1-173d-4221-9706-cb94cf6af1f1"), 233, "Research 232", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c7519944-86cf-4fc7-9c44-deac6821ff00"), 239, "Research 238", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("c754e799-e485-46db-aed6-91e6d7879d42"), 92, "Research 91", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c810a701-9f6f-4729-a7d7-7da069ebd6eb"), 783, "Research 782", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("c8383127-d37c-4240-8d3e-fc165e692b31"), 552, "Research 551", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("c85251f0-17ae-4e55-8bc6-1760ca2f04dc"), 155, "Research 154", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("c89ddbcb-29c0-4014-b839-03ce4f84891e"), 471, "Research 470", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c8b2ec35-0efc-458e-912b-8fa11308869e"), 757, "Research 756", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("c8ebe723-e38d-4e72-bee1-87d410c57093"), 708, "Research 707", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("c9033ca0-7306-44b2-92e1-e43cfbf872e8"), 831, "Research 830", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("c9a12d43-a5f1-45cc-8ead-419da36682a2"), 369, "Research 368", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("c9d43ed4-633c-4ee6-8180-e238969179d0"), 541, "Research 540", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c9d9ccae-8ccd-49ed-a90b-8a55329c92a6"), 554, "Research 553", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("c9ee870e-f660-45d4-baeb-66e842282ddd"), 414, "Research 413", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ca2807b8-f9f0-41ea-8a75-c42e7e3a9caf"), 442, "Research 441", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("ca4809ab-1c8d-41d9-a77b-5907b6a37577"), 544, "Research 543", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("cafdebbb-cc56-4890-a106-323fec47fc04"), 535, "Research 534", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("cb52bba2-5cf5-42db-bb7f-f973286376ee"), 344, "Research 343", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("cb797986-ec33-4826-9a1c-0df5e85266c8"), 15, "Research 14", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("cbf35408-cd98-4b42-9428-1e7ead443c59"), 237, "Research 236", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("cccd7ebd-e7c4-43c9-b06a-ec3417bdc775"), 741, "Research 740", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("cdb09539-1dd7-435b-8ca0-bee64d194fea"), 382, "Research 381", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("cdecaaaa-58cf-40dd-82ff-d9194d4d64b5"), 627, "Research 626", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ce01748b-91f1-4390-b77b-652f26040203"), 679, "Research 678", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ce01f38e-34e7-4081-9d80-5632201817c9"), 584, "Research 583", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("ce8d3fda-0111-4acd-9172-6ad104c6fbbf"), 360, "Research 359", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("cfc62433-0838-46d6-bbea-5f240f9f84c2"), 126, "Research 125", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("d027fa74-1809-412e-98b5-3a4eb3951d03"), 704, "Research 703", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("d02eeca1-7af0-4ac4-9e2c-97adc9581905"), 254, "Research 253", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("d07e51f1-c845-4ba6-864d-5e22e563d5ad"), 488, "Research 487", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("d0c575b1-c9cd-4d44-ab2a-969b78cd3d60"), 281, "Research 280", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d10ab258-d2f4-4199-8f26-7936a7835846"), 557, "Research 556", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("d1359cf1-ca83-4b0b-b024-104dfdba5d48"), 480, "Research 479", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("d13b81e8-388a-4382-9f2c-6d19a7a2edc4"), 188, "Research 187", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d1d3f8a6-6ae6-4e53-82ed-a4b86468c49d"), 456, "Research 455", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("d2fe47fa-cec2-4fbe-9aec-d7391eff8f23"), 265, "Research 264", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d37b6070-3813-4410-95d4-8965055cc04d"), 268, "Research 267", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("d388a628-0d4b-4f84-9cec-715fe11c4706"), 531, "Research 530", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("d3e75f97-71c9-47b8-a773-b45e1086a307"), 610, "Research 609", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d463b088-a90b-4b50-905b-87ea815998e3"), 738, "Research 737", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("d4c726cb-99be-46b1-b234-2bc402d51b41"), 776, "Research 775", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("d5149693-3c95-4457-ae28-1b48deede69a"), 688, "Research 687", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("d52e597e-7acf-4ccf-af14-664c053ecd94"), 724, "Research 723", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d562802c-5d28-4eb3-bdbc-4f5793fd61d4"), 104, "Research 103", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("d585185f-ad36-43bd-b615-28fc12b81308"), 65, "Research 64", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("d5e17de0-2f40-4f38-a516-5362a5f68f4c"), 219, "Research 218", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("d61bf84d-46f6-4cfe-9b85-897011e1227a"), 93, "Research 92", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("d61bf9df-7cc7-4fb3-88ee-98c85951d2a7"), 171, "Research 170", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("d65d7cf8-e89e-4fdd-b76b-b74e121a4398"), 678, "Research 677", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("d6c44a97-9335-410f-b95d-ef4d3fa71de5"), 891, "Research 890", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d6efab98-e4d6-4fa7-89c4-f8f7cd832e6b"), 355, "Research 354", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("d74e6fe1-2a71-432e-b794-71b8b010d79b"), 201, "Research 200", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("d77133db-8aa5-49f4-b01f-2d0d58d96b62"), 954, "Research 953", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("d860700d-9484-4000-a6c0-15a1d1c51f18"), 657, "Research 656", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("d919560c-227a-4039-9727-358945a94970"), 483, "Research 482", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d928328a-ae4e-44d4-bc00-c77cfb813af5"), 54, "Research 53", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("d93cd2b9-05d6-432e-a26d-d90ef5e03691"), 185, "Research 184", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("d9995130-3ffa-4dc6-8fa1-05659eee250f"), 276, "Research 275", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("d9cef5de-1dad-4cf1-b381-01c40c8e298e"), 401, "Research 400", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("d9f0c56e-e8c3-44c4-82e1-dce47f5e3b75"), 71, "Research 70", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("d9f8438e-dcd3-4097-9e9b-e28c8669dcef"), 639, "Research 638", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("da7a6831-38be-47c8-8160-1a649c8b1552"), 760, "Research 759", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("da7eb2f7-e346-4eb0-8833-2bf6fcc21619"), 905, "Research 904", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("da960770-c573-47a8-b444-c4d5bbe2c88c"), 668, "Research 667", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("da99f1fa-f361-4dd0-af40-87efdd657746"), 328, "Research 327", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("dad8f890-bc98-48f2-922a-6645a9a3d5f8"), 902, "Research 901", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("db725cc6-8cfd-4ea3-8ba8-8de58e33366f"), 877, "Research 876", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("db7e97f4-d6f8-49c0-9f21-b61797f93b82"), 439, "Research 438", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("db9c3f39-0bff-4b7b-ab62-5cdfaf33f4d2"), 788, "Research 787", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("dba400c2-8359-4d27-becf-9d9f3cf8f214"), 40, "Research 39", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("dc32e45f-7bf8-465c-853e-09b30a7bd5b4"), 3, "Research 2", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("dc3a0b1a-b111-4c94-80b7-5bb5d2e815e8"), 805, "Research 804", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("dc44bc49-ecfe-48e4-ad2b-f81b1e1a66b1"), 179, "Research 178", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("dcc0ee31-5997-43a8-a6bb-91161c584007"), 565, "Research 564", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("dd00f810-9ff9-4140-80f8-a2a37bb20464"), 151, "Research 150", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("dd1ebc27-9fb9-4765-a153-77183a07c058"), 264, "Research 263", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("dd237f4a-7f4d-4a4e-94c8-dd712580cd21"), 976, "Research 975", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("dd317045-cc08-463c-b976-2bcdf23161b2"), 286, "Research 285", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("dd55fd68-4659-498e-978f-8bb6b2901fcf"), 408, "Research 407", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("dd88c841-773a-46f2-935f-2e7a7e85fd68"), 101, "Research 100", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("ddae24d2-e369-4ec7-8e57-f5b565e2eea7"), 771, "Research 770", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ddc4f29e-b973-40dd-8604-f81bd0f4799a"), 353, "Research 352", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("de2acc18-6adb-44b1-a3b0-e74d37ba707f"), 385, "Research 384", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("dee2a6b7-4959-482b-9623-177a1f84fbf1"), 856, "Research 855", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("df00b8d6-b937-473a-b9ba-efaceb4f446f"), 887, "Research 886", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("dfc95883-4bf7-4c7a-893c-52047d799118"), 181, "Research 180", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("dfd4fa65-790a-464d-a425-82a8e41be80c"), 425, "Research 424", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e02e7735-ca1c-41ed-adec-4acf0c701274"), 41, "Research 40", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e04300ad-19d5-475d-9e68-331e65a19b34"), 815, "Research 814", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e05c79f9-6fe3-4423-9f5d-b8717c133567"), 412, "Research 411", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e0728fbf-0f07-4cdc-a908-36215ff94470"), 481, "Research 480", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e0d6c720-c7cf-4cb8-95a9-640115ec3d25"), 865, "Research 864", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e0f3da88-53ef-43f5-930c-88c839dfd3b6"), 82, "Research 81", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e122d315-833e-41b1-abbd-c3c813e02a7d"), 392, "Research 391", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e14a15d2-a533-4806-b46c-c984a551307d"), 148, "Research 147", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("e184412f-9e42-4a76-8c33-e141fd29e52e"), 912, "Research 911", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e1d5ae1e-7460-4ee9-86d6-4f8f3c465b32"), 898, "Research 897", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e23bcb74-8715-4bb4-8436-fbc8ab3efc92"), 309, "Research 308", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e264a6e8-6168-4529-89c4-8c3ae956638f"), 556, "Research 555", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e2bfeedf-c74b-4b81-bcff-2efa17c81173"), 739, "Research 738", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e32f2178-dbf0-4f0d-8360-8b85363dad9c"), 779, "Research 778", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e3461053-d789-47a7-9f36-cd0563d992c5"), 664, "Research 663", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e3c2340f-4c24-4677-9eab-bdf3e14da09c"), 978, "Research 977", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e3cc62bf-539e-4d8d-8a67-5234f089f34e"), 756, "Research 755", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e3d376bc-7cba-4881-90f3-eb8a3e794cba"), 581, "Research 580", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e3ec65d9-ce53-4763-a3aa-b7a64944b3db"), 69, "Research 68", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e4012bae-9e31-40cc-9561-e7aa22339484"), 707, "Research 706", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e424f8c1-f295-40a3-b5c0-aca42ede04ee"), 881, "Research 880", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e4787bd2-0ad1-4037-970b-b81664efc749"), 621, "Research 620", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e51201ad-67cb-42ce-a75c-c328dbda3632"), 266, "Research 265", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e59f91fa-d478-4c77-8b21-b592abec0725"), 70, "Research 69", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e5aadc50-9d3f-4bfa-91d0-c0e29373b1a0"), 880, "Research 879", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("e5f3ce18-38f6-4253-a3c6-76928ab651b3"), 20, "Research 19", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e612f7fc-86a2-4e64-aaf8-5eced129d67c"), 238, "Research 237", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e61ecfd5-94c6-46d1-8584-ace648a833de"), 689, "Research 688", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e622a9ec-6be8-4441-b7fd-73e6f2829ef3"), 780, "Research 779", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e64470fb-0961-4b29-a2b0-828d42d0bd59"), 431, "Research 430", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("e64762cf-99c6-45af-b40c-7932f3823936"), 321, "Research 320", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("e6571c62-ce7f-4c94-977a-671d38aad5ac"), 176, "Research 175", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e67828d4-4512-4b17-87cd-06d5e545d994"), 191, "Research 190", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e6aa5215-9c3d-43fb-b486-d11d4c7b8ae8"), 713, "Research 712", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e6f14e71-076d-4f00-9ab4-ebca124f92b2"), 716, "Research 715", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e733a975-33a3-4118-a304-da7a0846a6cb"), 405, "Research 404", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("e76486a2-cc0b-48fc-b309-3d77a08d7ef4"), 641, "Research 640", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e781ba6d-aafb-4962-b55c-279216a22dbf"), 275, "Research 274", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("e7a3a425-5521-4763-ae7c-bf6d80cd2949"), 381, "Research 380", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("e7c3f02a-0968-4da7-b486-d065a1b57ffb"), 113, "Research 112", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e80faa8e-f921-4c57-93a6-c346093f1d66"), 526, "Research 525", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e83106b4-4723-4980-ab1b-9a06bff624b9"), 714, "Research 713", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("e8501af3-d80f-4fe5-b2a2-886d90f097d4"), 210, "Research 209", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e85b522b-137c-4fd2-8f17-fbed81857519"), 980, "Research 979", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("e9473c7b-7e53-41c7-be3d-74e97b65f7f0"), 742, "Research 741", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("e9dca80c-918e-4452-a3e6-6296993f8f8c"), 228, "Research 227", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("ea4a0f85-41a2-401b-87c8-48530fa1b731"), 532, "Research 531", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("ea696271-82b6-4410-95c8-6f6bd74d86ee"), 806, "Research 805", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ea8f5090-d074-48bc-b862-1ffdb4764d38"), 153, "Research 152", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ea927ca4-8d7b-4c8f-a63f-87b415f2782b"), 208, "Research 207", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("eab911dc-3009-461b-9826-dc79c06ab1e6"), 747, "Research 746", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("eac33d4a-b8e7-4bee-841f-316b1ac5a6ea"), 12, "Research 11", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("eb07e76e-45f3-4350-bfbf-0a0df793a209"), 974, "Research 973", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("eb0c2b9d-8745-4ece-bc5a-1a6cdaa0a437"), 703, "Research 702", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("eb41dd7d-a83c-4c39-ac5a-a88c99541599"), 602, "Research 601", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("eb780ea2-40d5-4636-8072-ea383260b7df"), 522, "Research 521", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("eb9a4b88-eff2-422c-b91b-8cdfb83b8fd0"), 524, "Research 523", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("eba47534-e7f0-4761-b80f-11a7570042b0"), 600, "Research 599", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("ebbf2ce3-5c4d-4452-a93d-cf75385695c7"), 926, "Research 925", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("ebdd32d5-a8ba-49e1-8aee-1eb12a2711ad"), 803, "Research 802", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ec9da86b-99ab-4349-93d7-232c214f3202"), 506, "Research 505", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ece94fec-48ef-4cab-a605-1019457a6cc9"), 755, "Research 754", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("ed274bc9-3700-4c93-baf6-d14ffbc0e202"), 715, "Research 714", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ed6a0d81-80b6-4856-9cba-af6aaed3bcfc"), 435, "Research 434", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ed889094-12f1-4b7a-ad46-1fbb1ec2702b"), 997, "Research 996", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ed8f84a7-3af4-48b7-a788-989b5b202441"), 262, "Research 261", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ee5cd60f-7a55-43aa-b667-0bc836bfab30"), 502, "Research 501", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("ee6770b0-408b-4738-a5f2-dd43ba4d7679"), 293, "Research 292", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("ee8a2d2a-f8a8-456a-a55d-11cd3828b6f4"), 869, "Research 868", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("ef3e339a-d22d-4074-81ff-8b34e1e5445e"), 390, "Research 389", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("efa7cd02-183f-4d63-b050-c8a22e721e98"), 156, "Research 155", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("efc0366f-2e67-4fb3-87c8-edfb63ee3cec"), 245, "Research 244", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("efc333db-e1cf-4d3f-b0cc-16395e2a6604"), 216, "Research 215", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f032ea62-188c-4a1f-8c6c-2c8a0b9c61ce"), 13, "Research 12", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f0aa717b-580c-4001-a7c8-d4d632106bdf"), 795, "Research 794", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("f0b51bd4-ee5e-4676-aac9-e3c6b7250746"), 861, "Research 860", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f10a3a3c-efd3-4f95-b3fe-bdce8a863c35"), 338, "Research 337", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f1598b74-5314-447e-86b7-5a08053d1e7d"), 972, "Research 971", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f1d6e1c8-55ce-4ce2-bbce-5df2a452bf9e"), 205, "Research 204", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("f1f712f6-cd5e-4306-a32a-0ca6e265277a"), 752, "Research 751", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f205ac1f-3082-4dbf-8905-669846c6d440"), 363, "Research 362", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f29cec25-c45c-40e3-97d5-9a844cbf4acb"), 695, "Research 694", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f2be1bd8-6276-4ca9-ac05-e548ce311bad"), 196, "Research 195", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f2e27bb4-3bc8-41c3-a70c-ca8153cd069c"), 710, "Research 709", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f32a3537-beb5-45a8-914e-09584fe42202"), 626, "Research 625", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("f32d7bf0-7c9b-4dcf-b539-8db29ab3d81b"), 141, "Research 140", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f336f6f7-2d45-4528-83da-be55f854ba28"), 525, "Research 524", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f37ffaa2-3fae-43c6-946c-5ac5eccb4b65"), 462, "Research 461", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f3852b7d-88a3-4dd8-bd4d-06d8479a5420"), 870, "Research 869", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f3e34c0c-62b9-4644-9b7a-91e86515e3d6"), 509, "Research 508", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f40b2e3a-4436-43d3-81b4-f3bb28301e2c"), 646, "Research 645", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f412975a-d401-4963-94fd-77171737e711"), 593, "Research 592", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("f472440f-6dea-4c89-a383-837a85def69f"), 941, "Research 940", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f476090f-944b-4652-aed3-ffdad8e24a21"), 797, "Research 796", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f47ab0c9-4ba1-4461-929a-291767090424"), 850, "Research 849", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f545115c-4570-4e3e-9146-d30c77edbe23"), 957, "Research 956", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f5ad281e-556f-4261-974d-9227ca684db4"), 952, "Research 951", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f5c31d61-9289-40a0-a73a-2711e92f7261"), 868, "Research 867", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f5cdafde-6cd7-43c6-8e84-8e81eac38735"), 129, "Research 128", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f5d1d3b0-a36f-4187-906c-5e5cf95b98a2"), 630, "Research 629", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("f605530d-7e60-4d97-be15-7e799056b021"), 305, "Research 304", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f65d3070-0426-4818-8db0-0b0bf40475bb"), 319, "Research 318", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f65ef4c8-6157-4d93-9716-cd732d70ff4a"), 804, "Research 803", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f6949f9c-64cf-4f3f-ab49-1f815fa69a41"), 594, "Research 593", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f6adce32-696f-4dc6-8bac-572f7edc8dc9"), 651, "Research 650", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f782ed7d-22c8-4a03-97df-f029368651b5"), 132, "Research 131", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("f796f34d-e696-4154-af4d-ec4a5f5f4b13"), 108, "Research 107", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f79a9cac-60e5-4834-94a2-6642f5a4850b"), 609, "Research 608", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f7b9b0b8-0139-400b-91ce-112964f33fcf"), 37, "Research 36", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f7d4b52f-2bd6-4f27-b1dd-68cdfd292a4d"), 895, "Research 894", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f80b4f68-e90f-4694-a015-a01d37fb1045"), 505, "Research 504", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f93e841b-f642-4610-9768-2f9475dc2a7f"), 919, "Research 918", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f9453fa5-e76a-4544-93cd-8d872225fe36"), 901, "Research 900", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("f94f67e8-43d9-4a70-8bfb-5045c5815200"), 937, "Research 936", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("f981f426-7227-4067-b220-cf9e3dedf37a"), 280, "Research 279", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("f9d4d82e-d06c-4999-94a5-5ad897eb7237"), 578, "Research 577", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("f9f30390-f8d8-4a7c-ae7c-dbed9aa46da7"), 504, "Research 503", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("fa0e018d-353b-4b00-8361-d40b9d9b6b0d"), 949, "Research 948", new Guid("86943ccc-3c41-4cf8-8e64-c860d365e312"), new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("fa9a20be-054e-4e58-bd6c-9842ecef1af5"), 907, "Research 906", new Guid("a92dab1d-e5db-4190-9e9e-84f3c836a5bd"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("fadcab42-104a-41f9-afa1-b60f60448e2b"), 996, "Research 995", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("faf199d9-1ef7-4b01-85fb-bd7662bae177"), 463, "Research 462", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("fb8b4409-60b7-4c3d-b131-5021f97c69e2"), 994, "Research 993", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("fba5eec7-3181-4afd-8a31-7853b1d32b74"), 325, "Research 324", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("fbf2cef9-4d4f-46db-9d72-4fff29e59ca7"), 61, "Research 60", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("fbf3b192-eb4c-49bb-96e9-4082b87dfd54"), 947, "Research 946", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("fc1636d3-387b-4345-9629-dbd2806e5e74"), 207, "Research 206", new Guid("d8e8d4ef-8f56-4491-99e8-aef54460b500"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("fc8a8367-b73d-4fb1-9f4e-c702763b9bf7"), 717, "Research 716", new Guid("99f96fe8-9875-4fb3-a8cd-e082107a189f"), new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), true, new Guid("18958862-067b-447b-9467-0eb616ad7b61") },
                    { new Guid("fce1afed-f7b5-437c-843f-fd11934b985f"), 116, "Research 115", new Guid("704fcd20-ddb4-46b3-9afd-dec8dc6ed071"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("fd587efe-5898-42e7-ae08-2e24c4cf4e46"), 272, "Research 271", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") },
                    { new Guid("fd7e7cfc-4f6c-4b2f-8eba-a30a3af9db8a"), 134, "Research 133", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), true, new Guid("0d8cbbbb-7569-4ef4-80bc-27e2aba25074") },
                    { new Guid("fdb36b89-8d21-4b30-941b-eb554fd4f18a"), 428, "Research 427", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("2850692b-b609-4a19-9f42-c0acacda97b8"), true, new Guid("4a2be7c6-5fde-438d-a0b6-d0c34f9810d2") },
                    { new Guid("fdc6ae35-79cc-4a86-94bd-44df50c328ec"), 187, "Research 186", new Guid("5c292492-9466-4f35-a40e-0c61bb3341ac"), new Guid("0efcace7-9778-4660-9c1a-06ec3fdc5cd9"), true, new Guid("94bf234a-4099-465a-bfb4-3a5f5e1f69b0") },
                    { new Guid("fdceb141-a291-4465-829a-d56c62d3668b"), 914, "Research 913", new Guid("8b6d3a86-a3ef-4ec4-adee-e48f0e59de37"), new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), true, new Guid("f32c6167-dffc-4850-8f94-89af46a4fc90") }
                });

            migrationBuilder.InsertData(
                table: "SkillLink",
                columns: new[] { "SkillLinkId", "Level", "PersonId", "SkillId" },
                values: new object[] { new Guid("0ebb4fce-c7a1-49f0-a671-084e86c8f132"), 2, new Guid("71c580e3-2b95-4d13-8f77-4079f7643029"), new Guid("d4742c7d-8173-4677-a3bf-1cf633ed92a5") });

            migrationBuilder.InsertData(
                table: "SkillLink",
                columns: new[] { "SkillLinkId", "Level", "PersonId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("231317ed-2f0c-4297-94d0-54f7002e77e5"), 2, new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), new Guid("96e11654-f341-41a7-a4c7-8f89bf483c1f") },
                    { new Guid("27efb69f-a805-4ab1-9733-9ad30e6c119a"), 1, new Guid("7481fc1b-2d73-4a70-a653-703d64bb9abf"), new Guid("f2effd39-6298-4ab9-bbf4-80fc003c7c45") },
                    { new Guid("2957766d-677d-40a2-8feb-bcfd281202a9"), 1, new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), new Guid("c28823a4-3bf0-4907-9384-41c25850fadb") },
                    { new Guid("9914b1bd-308d-4d1a-bf33-e2155b2507e8"), 2, new Guid("5586d252-c9cc-4596-bf5b-50ddd9c6b2c3"), new Guid("8482a871-2f2a-42ab-93ce-c5c241b2531e") },
                    { new Guid("9e6e49af-e985-4a0d-939b-2831d7684a9a"), 6, new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), new Guid("2ec7b396-ea11-4279-8a50-581d76f0e62b") },
                    { new Guid("ae089680-4723-4107-b607-64e23ad58daf"), 3, new Guid("972122f7-1c87-43b0-85a6-e4fd450d276b"), new Guid("2065f878-48ef-464e-9c0a-75ef84a5fab7") },
                    { new Guid("deb3c3b0-e168-423b-b714-141483983c1c"), 3, new Guid("75ae692c-ceba-43ca-887d-5dec9be475ad"), new Guid("96e11654-f341-41a7-a4c7-8f89bf483c1f") }
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
