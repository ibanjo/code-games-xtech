using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Research.Domain.Migrations
{
    public partial class addedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("3a6f9d35-af6a-48bf-b115-53b93cf8eb90"), 7, "Russian" },
                    { new Guid("500aef74-4334-43b9-8225-e4d58f2d26fc"), 5, "Italian" },
                    { new Guid("811c9b2e-4b81-4dba-8b01-597f4b2b1d01"), 4, "Spanish" },
                    { new Guid("b966f909-0bed-4f0c-b7dd-89dd72cfbd13"), 3, "German" },
                    { new Guid("b9ce3cf4-365e-4dea-817c-8d04b5746aa0"), 1, "English" },
                    { new Guid("beadbad9-106d-4d69-bddf-86394bee456e"), 6, "Portuguese" },
                    { new Guid("c915c0d9-830e-447c-a722-bee0ebb4cb36"), 2, "French" }
                });

            migrationBuilder.InsertData(
                table: "LanguageLevel",
                columns: new[] { "LanguageLevelId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("0c0fe95c-4726-4a7e-a673-895f5049e087"), 6, "Advanced" },
                    { new Guid("49cd01f7-bc20-406c-98cf-c520687bd21b"), 5, "Upper-Intermediate" },
                    { new Guid("53dc146a-d301-406a-8e88-a06b310a90ce"), 3, "Pre-Intermediate" },
                    { new Guid("5e4ba351-fd4e-4abc-a437-b71225f5b3f3"), 4, "Intermediate" },
                    { new Guid("6cfb9163-c449-4036-abb8-e23bec855d28"), 1, "Beginner" },
                    { new Guid("78413890-f8d4-4d86-8adf-e8fc31d9f7ea"), 2, "Elementary" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "SiteId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("005fe637-637d-4239-94c3-1a2ce756c439"), 3, "WASHINGTON" },
                    { new Guid("09168b51-310d-4f50-9036-878e93203df6"), 2, "CHICAGO" },
                    { new Guid("0b9478ca-2e7e-4968-9ca8-7192455a3f76"), 5, "LONDON" },
                    { new Guid("57dfe520-ee12-4c61-b9a8-94a78353dfb4"), 1, "NEW YORK" },
                    { new Guid("78fee931-b61d-4732-b637-9cc58c1c02ed"), 4, "LOS ANGELES" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Code", "Description", "FEBEDevops", "ProjectRef", "Technology", "WebMobile" },
                values: new object[,]
                {
                    { new Guid("035bfc8a-c8dd-46ce-9c9f-39ecb0a2a8fe"), 7, "SMSS", "", "", "SSMS", "" },
                    { new Guid("2f4fbd0f-97bf-4c9e-bc30-61c18658f338"), 6, ".NET", ".NET", "", "", "" },
                    { new Guid("4cdc25b2-d989-4b08-a403-1d4d25bf38b7"), 5, "Iot", "", "", "Iot", "" },
                    { new Guid("76cfa6ae-48bc-457c-bda4-001dc66b80a7"), 3, "Azure", "Azure", "", "", "" },
                    { new Guid("79cd2fdd-1158-4442-a916-5ea969cb21ac"), 1, "Angular 9", "", "", "", "angular" },
                    { new Guid("7f9b6ec1-ae0e-417c-80c8-4c80e6270274"), 2, "TS", "", "", "", "typescript" },
                    { new Guid("aa55f60e-d599-4672-b3c7-788b87a763c0"), 4, "Flutter", "", "", "", "Flutter" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Code", "IsRecruiter", "Name", "Position", "Remote", "SiteId", "Surnamme", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("238ee722-430f-4936-80c1-017723073961"), 1, false, "Nicoletta", "dev", false, new Guid("57dfe520-ee12-4c61-b9a8-94a78353dfb4"), "Morsia", 2 },
                    { new Guid("5e770d60-4689-4b80-b600-64eed4205a6a"), 7, false, "Giovanni", "dev", true, new Guid("0b9478ca-2e7e-4968-9ca8-7192455a3f76"), "Novembre", 1 },
                    { new Guid("702907dd-3a80-4b4e-98c6-9adaa82d6aab"), 5, false, "Giovanni", "dev", true, new Guid("005fe637-637d-4239-94c3-1a2ce756c439"), "Bianchi", 4 },
                    { new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), 3, true, "Mario", "recruiter", false, new Guid("57dfe520-ee12-4c61-b9a8-94a78353dfb4"), "Rossi", 2 },
                    { new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), 2, true, "Mario", "recuiter", true, new Guid("09168b51-310d-4f50-9036-878e93203df6"), "Rossi", 2 },
                    { new Guid("cd52721a-8579-4cdb-899a-50694e35cd49"), 6, false, "Alessandra", "dev", true, new Guid("09168b51-310d-4f50-9036-878e93203df6"), "Verdi", 15 },
                    { new Guid("f96d5032-cdbc-46e4-adba-f63046c49e8b"), 4, false, "Mario", "dev", true, new Guid("57dfe520-ee12-4c61-b9a8-94a78353dfb4"), "Rossi", 2 }
                });

            migrationBuilder.InsertData(
                table: "LanguageLink",
                columns: new[] { "LanguageLinkId", "LanguageId", "LanguageLevelId", "PersonId", "Preferred" },
                values: new object[,]
                {
                    { new Guid("0cbb2375-fee8-4a41-a5a5-905b738e2400"), new Guid("b9ce3cf4-365e-4dea-817c-8d04b5746aa0"), new Guid("53dc146a-d301-406a-8e88-a06b310a90ce"), new Guid("238ee722-430f-4936-80c1-017723073961"), true },
                    { new Guid("29021107-ca2e-45fc-87ea-57f558c95734"), new Guid("811c9b2e-4b81-4dba-8b01-597f4b2b1d01"), new Guid("78413890-f8d4-4d86-8adf-e8fc31d9f7ea"), new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), false },
                    { new Guid("4217c122-216d-43b2-a7f4-d2fba97bd42a"), new Guid("b966f909-0bed-4f0c-b7dd-89dd72cfbd13"), new Guid("6cfb9163-c449-4036-abb8-e23bec855d28"), new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), true },
                    { new Guid("6eeed4ed-78c2-4819-99e4-e0d43164f3da"), new Guid("500aef74-4334-43b9-8225-e4d58f2d26fc"), new Guid("53dc146a-d301-406a-8e88-a06b310a90ce"), new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), true },
                    { new Guid("711605f9-dbbc-40d6-a05b-9f06b61d8d1e"), new Guid("3a6f9d35-af6a-48bf-b115-53b93cf8eb90"), new Guid("49cd01f7-bc20-406c-98cf-c520687bd21b"), new Guid("f96d5032-cdbc-46e4-adba-f63046c49e8b"), true },
                    { new Guid("80d3fcf7-fd16-442b-a453-d4dac2a7b24a"), new Guid("c915c0d9-830e-447c-a722-bee0ebb4cb36"), new Guid("0c0fe95c-4726-4a7e-a673-895f5049e087"), new Guid("238ee722-430f-4936-80c1-017723073961"), false },
                    { new Guid("bff76a59-db06-4390-9660-6ef2f89c1fc7"), new Guid("beadbad9-106d-4d69-bddf-86394bee456e"), new Guid("5e4ba351-fd4e-4abc-a437-b71225f5b3f3"), new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), false }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("1e3d0b39-fe87-425a-8697-ef8b5d53f4eb"), 8, "Flutter", new Guid("beadbad9-106d-4d69-bddf-86394bee456e"), new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), true, new Guid("57dfe520-ee12-4c61-b9a8-94a78353dfb4") },
                    { new Guid("3dcd8502-0902-4816-a151-f6c6c2a0b7cc"), 3, "Typescript", new Guid("b9ce3cf4-365e-4dea-817c-8d04b5746aa0"), new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), true, new Guid("005fe637-637d-4239-94c3-1a2ce756c439") },
                    { new Guid("4f8b05ff-33dc-412e-ad45-a62c01443db0"), 6, "Back end .NET", new Guid("500aef74-4334-43b9-8225-e4d58f2d26fc"), new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), true, new Guid("09168b51-310d-4f50-9036-878e93203df6") },
                    { new Guid("bfb5446d-f1df-4ae2-88df-74a3698c4944"), 4, "Azure", new Guid("b966f909-0bed-4f0c-b7dd-89dd72cfbd13"), new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), false, new Guid("78fee931-b61d-4732-b637-9cc58c1c02ed") },
                    { new Guid("c18ff02c-1aa4-4eb1-a773-fe04c0cc215c"), 7, "Azure", new Guid("811c9b2e-4b81-4dba-8b01-597f4b2b1d01"), new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), true, new Guid("78fee931-b61d-4732-b637-9cc58c1c02ed") },
                    { new Guid("cb8784dd-332b-40c1-bff5-5b784a908648"), 9, "Back end .NET", new Guid("3a6f9d35-af6a-48bf-b115-53b93cf8eb90"), new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), true, new Guid("0b9478ca-2e7e-4968-9ca8-7192455a3f76") },
                    { new Guid("ebfe0954-80db-487d-b6fb-66b422b5c687"), 1, "Front end Angular", new Guid("b9ce3cf4-365e-4dea-817c-8d04b5746aa0"), new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), true, new Guid("57dfe520-ee12-4c61-b9a8-94a78353dfb4") },
                    { new Guid("f021f51f-33b3-4668-a55e-b7e541b4b110"), 5, "Smss", new Guid("811c9b2e-4b81-4dba-8b01-597f4b2b1d01"), new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), false, new Guid("0b9478ca-2e7e-4968-9ca8-7192455a3f76") },
                    { new Guid("f362086e-758a-474f-b2ef-57af4fe90f31"), 2, "Back end .NET", new Guid("c915c0d9-830e-447c-a722-bee0ebb4cb36"), new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), true, new Guid("09168b51-310d-4f50-9036-878e93203df6") }
                });

            migrationBuilder.InsertData(
                table: "SkillLink",
                columns: new[] { "SkillLinkId", "Level", "PersonId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("01012ed8-e893-4fbd-a98f-3f02ebc18a4f"), 6, new Guid("f96d5032-cdbc-46e4-adba-f63046c49e8b"), new Guid("4cdc25b2-d989-4b08-a403-1d4d25bf38b7") },
                    { new Guid("213a5dea-8325-4a90-9429-f070d5b51c55"), 1, new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"), new Guid("aa55f60e-d599-4672-b3c7-788b87a763c0") },
                    { new Guid("27ee3007-d32f-4147-b6fa-3b19ca68aa06"), 2, new Guid("238ee722-430f-4936-80c1-017723073961"), new Guid("7f9b6ec1-ae0e-417c-80c8-4c80e6270274") },
                    { new Guid("8a45bf46-4cf0-44b8-bebe-e00a49d99496"), 1, new Guid("238ee722-430f-4936-80c1-017723073961"), new Guid("79cd2fdd-1158-4442-a916-5ea969cb21ac") },
                    { new Guid("b848a613-7dbc-4b99-a4c6-5afe2e50843e"), 3, new Guid("f96d5032-cdbc-46e4-adba-f63046c49e8b"), new Guid("2f4fbd0f-97bf-4c9e-bc30-61c18658f338") },
                    { new Guid("f568c356-cfdf-4d9c-99c7-a090f081ba71"), 3, new Guid("c78a80d8-d13c-44f9-a511-21674f628826"), new Guid("76cfa6ae-48bc-457c-bda4-001dc66b80a7") },
                    { new Guid("f7f145e2-b5f1-4990-afaf-3bc0ec879569"), 2, new Guid("f96d5032-cdbc-46e4-adba-f63046c49e8b"), new Guid("76cfa6ae-48bc-457c-bda4-001dc66b80a7") },
                    { new Guid("fa1274a5-0ed0-4299-9afb-0f43e8fb5789"), 2, new Guid("702907dd-3a80-4b4e-98c6-9adaa82d6aab"), new Guid("035bfc8a-c8dd-46ce-9c9f-39ecb0a2a8fe") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("0cbb2375-fee8-4a41-a5a5-905b738e2400"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("29021107-ca2e-45fc-87ea-57f558c95734"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("4217c122-216d-43b2-a7f4-d2fba97bd42a"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("6eeed4ed-78c2-4819-99e4-e0d43164f3da"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("711605f9-dbbc-40d6-a05b-9f06b61d8d1e"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("80d3fcf7-fd16-442b-a453-d4dac2a7b24a"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("bff76a59-db06-4390-9660-6ef2f89c1fc7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("5e770d60-4689-4b80-b600-64eed4205a6a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("cd52721a-8579-4cdb-899a-50694e35cd49"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("1e3d0b39-fe87-425a-8697-ef8b5d53f4eb"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("3dcd8502-0902-4816-a151-f6c6c2a0b7cc"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("4f8b05ff-33dc-412e-ad45-a62c01443db0"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("bfb5446d-f1df-4ae2-88df-74a3698c4944"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("c18ff02c-1aa4-4eb1-a773-fe04c0cc215c"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("cb8784dd-332b-40c1-bff5-5b784a908648"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("ebfe0954-80db-487d-b6fb-66b422b5c687"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("f021f51f-33b3-4668-a55e-b7e541b4b110"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("f362086e-758a-474f-b2ef-57af4fe90f31"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("01012ed8-e893-4fbd-a98f-3f02ebc18a4f"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("213a5dea-8325-4a90-9429-f070d5b51c55"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("27ee3007-d32f-4147-b6fa-3b19ca68aa06"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("8a45bf46-4cf0-44b8-bebe-e00a49d99496"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("b848a613-7dbc-4b99-a4c6-5afe2e50843e"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("f568c356-cfdf-4d9c-99c7-a090f081ba71"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("f7f145e2-b5f1-4990-afaf-3bc0ec879569"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("fa1274a5-0ed0-4299-9afb-0f43e8fb5789"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("3a6f9d35-af6a-48bf-b115-53b93cf8eb90"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("500aef74-4334-43b9-8225-e4d58f2d26fc"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("811c9b2e-4b81-4dba-8b01-597f4b2b1d01"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("b966f909-0bed-4f0c-b7dd-89dd72cfbd13"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("b9ce3cf4-365e-4dea-817c-8d04b5746aa0"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("beadbad9-106d-4d69-bddf-86394bee456e"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("c915c0d9-830e-447c-a722-bee0ebb4cb36"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("0c0fe95c-4726-4a7e-a673-895f5049e087"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("49cd01f7-bc20-406c-98cf-c520687bd21b"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("53dc146a-d301-406a-8e88-a06b310a90ce"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("5e4ba351-fd4e-4abc-a437-b71225f5b3f3"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("6cfb9163-c449-4036-abb8-e23bec855d28"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("78413890-f8d4-4d86-8adf-e8fc31d9f7ea"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("238ee722-430f-4936-80c1-017723073961"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("702907dd-3a80-4b4e-98c6-9adaa82d6aab"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("7790e89c-5ed3-470b-9a61-052c2881cba5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("c78a80d8-d13c-44f9-a511-21674f628826"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("f96d5032-cdbc-46e4-adba-f63046c49e8b"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("0b9478ca-2e7e-4968-9ca8-7192455a3f76"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("78fee931-b61d-4732-b637-9cc58c1c02ed"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("035bfc8a-c8dd-46ce-9c9f-39ecb0a2a8fe"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("2f4fbd0f-97bf-4c9e-bc30-61c18658f338"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("4cdc25b2-d989-4b08-a403-1d4d25bf38b7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("76cfa6ae-48bc-457c-bda4-001dc66b80a7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("79cd2fdd-1158-4442-a916-5ea969cb21ac"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("7f9b6ec1-ae0e-417c-80c8-4c80e6270274"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("aa55f60e-d599-4672-b3c7-788b87a763c0"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("005fe637-637d-4239-94c3-1a2ce756c439"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("09168b51-310d-4f50-9036-878e93203df6"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("57dfe520-ee12-4c61-b9a8-94a78353dfb4"));
        }
    }
}
