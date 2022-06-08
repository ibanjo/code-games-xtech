using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Research.Domain.Migrations
{
    public partial class addedMatchTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("17deac7b-0f01-4c4c-9f92-e06d923c661f"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("446225b9-b9fe-41e3-a844-d5878ad53811"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("6300eaf6-529e-4395-bbdc-7e54d591c769"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("94ff32b3-473e-4698-b560-4982b629fa71"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("a54e8920-c88b-416a-bc22-c8e6139164dd"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("acaf7326-23e8-45b2-b060-41ab7567b1ed"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("d43a68e1-72a8-440b-a314-af5bf1300292"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("806c66c9-5e1c-44e7-8955-250d495423af"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("f76cf32c-13d9-455e-a131-3d09cef5a96b"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("06b9af06-213a-4b72-b478-c08be6acaba8"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("24f6fb32-7f85-40ff-9d86-87504192f1b2"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("30fbd7fe-ce33-45a4-9a14-de522ca2a6bb"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("4e885b47-2c84-4955-bb4f-5eb77074bdf1"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("4f9b2724-576d-43c7-b413-89518134dfd5"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("72f1a13f-3a39-4668-b1bc-61ac6f2eb47f"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("d6ba76a1-914e-438b-961c-093654ba69d3"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("dd24036e-3bfd-49a7-81bd-9caed7352341"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("e09f20d4-6404-47c9-b70c-20e91409b7fc"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("18287d82-6007-49a7-8bf7-de537ba8d475"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("3555149a-ae06-4436-8d1d-815d4faa9eaa"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("3e4999f7-eded-4bc8-be1a-6c18f9087d8e"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("8ef412ed-b8d8-4d22-81c2-4968c4649aac"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("b4636a71-48a4-4b00-8501-9ceb4882d6b1"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("be5bd0a7-7f99-42ee-9ae2-4e2ce822d6b9"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("d52965bb-0aee-4875-83ee-a19d64f1a810"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("fb953e6a-4eb0-416a-868f-0accad9f4594"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("1463eb74-27f6-461c-af24-2ca80de38b0b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("1e9efb3e-9ffd-4355-9384-c55a72c68a5e"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("3da89920-aedd-4294-9221-c10962480cbf"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("40cd2ed1-157c-433a-8d5e-b61435b9832d"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("77b7dc8b-83fc-4657-b5c0-41395abcf147"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("a8d112e3-557e-4c61-a630-d713d4862ab6"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("b8c6605e-b1ce-4976-8cb4-8bc04e4bad78"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("04341876-adcb-4b79-9f84-cc8e06db424b"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("044f27db-681f-4257-b0c8-75071101db34"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("0d0b8502-a65b-4d10-aa90-63e22395b2fb"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("8011174b-e603-4eb9-aff0-b6a3a899e9e1"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("861923f9-4be1-44cd-bf00-4dfbe17a54f2"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("c234120b-3ef5-4ce5-a62a-526ab42e961c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("12659b26-34ff-4c11-8dc2-f6c61cce6a56"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("59cc2c9c-f8dc-4f41-ac99-8db57084ac3b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("fc632d76-4654-4a77-ae65-afc9db13d052"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("28fbf520-a19e-4553-8826-7a60a10708f5"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("f4cb59af-33ac-443d-aed1-6c591945426b"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("266bff84-1da2-4119-9743-c7a10472914c"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("6daa2766-c7b5-48cb-aae7-3dbd8b9dccad"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("8c026223-a821-4082-ae32-4e911a897e81"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("8f44eba1-a1d2-41fa-871b-fe8801e1ae48"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("e5892717-05b0-4a3d-97cd-d1bad1c4a752"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("e97c4ff8-7d4c-4c98-8bc1-cab467796209"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("ff73dc3c-da66-4180-bd12-418218fc78c9"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("1d914145-a5fe-4520-ad42-3717675a71b2"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("49af6298-9c9c-4b04-8cb0-ba937ddd3de1"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("7341dba2-4d08-4541-9883-e81426163b2f"));

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("0bd1d2c8-7c52-471f-bb03-1148aa7be952"), 5, "Italian" },
                    { new Guid("1e2efdac-2e17-4a6d-8929-de39b9db5d54"), 1, "English" },
                    { new Guid("47ed2fcf-5310-484b-b2ab-4686e78d8225"), 3, "German" },
                    { new Guid("b002104e-1ad5-417a-8fe5-8587a87dc9df"), 2, "French" },
                    { new Guid("c07d3a0b-b93c-4d6d-b6b5-646f91ca8aa8"), 4, "Spanish" },
                    { new Guid("c3ccfdc4-807b-4769-b4c6-2b7081ec60b2"), 7, "Russian" },
                    { new Guid("ffda6091-71b5-4b22-8d8d-0a3882aa5524"), 6, "Portuguese" }
                });

            migrationBuilder.InsertData(
                table: "LanguageLevel",
                columns: new[] { "LanguageLevelId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("6b7b2537-ecc6-48d6-8135-fce805efb951"), 6, "Advanced" },
                    { new Guid("6bc54b48-f5a7-4b17-a3b9-a59a8d4ed990"), 1, "Beginner" },
                    { new Guid("837f6f53-731c-4ee4-8121-5f4baf9a5471"), 3, "Pre-Intermediate" },
                    { new Guid("8c20c694-be30-4294-890e-aacd0d1f5cf7"), 4, "Intermediate" },
                    { new Guid("ca1c7e34-9d3b-4baf-9c7d-5bc4dfb03360"), 2, "Elementary" },
                    { new Guid("fa028f12-c30a-497c-8e4a-072eb567483f"), 5, "Upper-Intermediate" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "SiteId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("4e145946-4c21-4f2e-a8ba-ed4ee29929f9"), 2, "CHICAGO" },
                    { new Guid("55c0aaa0-6c28-48c9-935c-a7535c79fb77"), 5, "LONDON" },
                    { new Guid("73ba69e6-a7ad-483d-84b9-4cda53e34fe1"), 1, "NEW YORK" },
                    { new Guid("876e1396-13f7-40e3-8b12-b03cd709b762"), 4, "LOS ANGELES" },
                    { new Guid("b0bd4bf1-d769-4fef-a2c9-ee8596841566"), 3, "WASHINGTON" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Code", "Description", "FEBEDevops", "ProjectRef", "Technology", "WebMobile" },
                values: new object[,]
                {
                    { new Guid("389a1adc-08cd-48a8-8997-c0ec04a05b5f"), 3, "Azure", "Azure", "", "", "" },
                    { new Guid("3d955909-eba7-4e66-8240-6333ba2cbf02"), 1, "Angular 9", "", "", "", "angular" },
                    { new Guid("773db846-42a3-4e36-8b2d-70d3404fad4e"), 7, "SMSS", "", "", "SSMS", "" },
                    { new Guid("c394cfbc-a4e0-4a9e-9f15-8d4ce3870c98"), 4, "Flutter", "", "", "", "Flutter" },
                    { new Guid("ca36c889-16c3-4d59-a702-f648993e5344"), 2, "TS", "", "", "", "typescript" },
                    { new Guid("cb655180-1a9d-4627-8bf3-35fade999f03"), 5, "Iot", "", "", "Iot", "" },
                    { new Guid("d436a51e-5040-4c40-9c8c-1ad749fc6c4b"), 6, ".NET", ".NET", "", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Code", "IsRecruiter", "Name", "Position", "Remote", "SiteId", "Surnamme", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("2775d42e-c6f6-417b-8860-7e21419c5718"), 6, false, "Alessandra", "dev", true, new Guid("4e145946-4c21-4f2e-a8ba-ed4ee29929f9"), "Verdi", 15 },
                    { new Guid("6297cf87-08b5-49b6-9ca6-0dc0af6a3d21"), 7, false, "Giovanni", "dev", true, new Guid("55c0aaa0-6c28-48c9-935c-a7535c79fb77"), "Novembre", 1 },
                    { new Guid("92a8316e-08d8-4939-b974-90e6e36e6db8"), 5, false, "Giovanni", "dev", true, new Guid("b0bd4bf1-d769-4fef-a2c9-ee8596841566"), "Bianchi", 4 },
                    { new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), 3, true, "Mario", "recruiter", false, new Guid("73ba69e6-a7ad-483d-84b9-4cda53e34fe1"), "Rossi", 2 },
                    { new Guid("9c1d3dfa-de29-4ea8-bb6b-1443d4a3160b"), 1, false, "Nicoletta", "dev", false, new Guid("73ba69e6-a7ad-483d-84b9-4cda53e34fe1"), "Morsia", 2 },
                    { new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), 2, true, "Mario", "recuiter", true, new Guid("4e145946-4c21-4f2e-a8ba-ed4ee29929f9"), "Rossi", 2 },
                    { new Guid("f888e8c4-9401-44e0-9ec6-65867b249889"), 4, false, "Mario", "dev", true, new Guid("73ba69e6-a7ad-483d-84b9-4cda53e34fe1"), "Rossi", 2 }
                });

            migrationBuilder.InsertData(
                table: "LanguageLink",
                columns: new[] { "LanguageLinkId", "LanguageId", "LanguageLevelId", "PersonId", "Preferred" },
                values: new object[,]
                {
                    { new Guid("4dd2e64c-9a8a-462f-ac5e-d0430ff8b22f"), new Guid("c3ccfdc4-807b-4769-b4c6-2b7081ec60b2"), new Guid("fa028f12-c30a-497c-8e4a-072eb567483f"), new Guid("f888e8c4-9401-44e0-9ec6-65867b249889"), true },
                    { new Guid("65e7172e-da9d-4124-b78c-65f7c14eb9ba"), new Guid("ffda6091-71b5-4b22-8d8d-0a3882aa5524"), new Guid("8c20c694-be30-4294-890e-aacd0d1f5cf7"), new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), false },
                    { new Guid("6a820aec-c77a-47d9-a54f-0c85abb2d0f6"), new Guid("47ed2fcf-5310-484b-b2ab-4686e78d8225"), new Guid("6bc54b48-f5a7-4b17-a3b9-a59a8d4ed990"), new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), true },
                    { new Guid("8c7e3f2a-5e37-4592-8f65-28cd9dc4eae2"), new Guid("0bd1d2c8-7c52-471f-bb03-1148aa7be952"), new Guid("837f6f53-731c-4ee4-8121-5f4baf9a5471"), new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), true },
                    { new Guid("a6f745e4-7ecd-48c5-b418-22fab250a256"), new Guid("b002104e-1ad5-417a-8fe5-8587a87dc9df"), new Guid("6b7b2537-ecc6-48d6-8135-fce805efb951"), new Guid("9c1d3dfa-de29-4ea8-bb6b-1443d4a3160b"), false },
                    { new Guid("d2239273-d1e3-4dcc-8e7f-c46781b37c8e"), new Guid("1e2efdac-2e17-4a6d-8929-de39b9db5d54"), new Guid("837f6f53-731c-4ee4-8121-5f4baf9a5471"), new Guid("9c1d3dfa-de29-4ea8-bb6b-1443d4a3160b"), true },
                    { new Guid("f583c77b-6749-45bc-a052-0b8b6f85e0ac"), new Guid("c07d3a0b-b93c-4d6d-b6b5-646f91ca8aa8"), new Guid("ca1c7e34-9d3b-4baf-9c7d-5bc4dfb03360"), new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), false }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("1924e1c8-d73f-4d5c-85d2-ae4f584869f6"), 4, "Azure", new Guid("47ed2fcf-5310-484b-b2ab-4686e78d8225"), new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), false, new Guid("876e1396-13f7-40e3-8b12-b03cd709b762") },
                    { new Guid("77959fdd-8bd0-47ed-a8c6-6a73ebfaa6b4"), 5, "Smss", new Guid("c07d3a0b-b93c-4d6d-b6b5-646f91ca8aa8"), new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), false, new Guid("55c0aaa0-6c28-48c9-935c-a7535c79fb77") },
                    { new Guid("807982ab-bd68-4fde-aa7d-64ad6bbc53d1"), 1, "Front end Angular", new Guid("1e2efdac-2e17-4a6d-8929-de39b9db5d54"), new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), true, new Guid("73ba69e6-a7ad-483d-84b9-4cda53e34fe1") },
                    { new Guid("82cc01c6-065a-429c-9d0e-fa28751d318b"), 2, "Back end .NET", new Guid("b002104e-1ad5-417a-8fe5-8587a87dc9df"), new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), true, new Guid("4e145946-4c21-4f2e-a8ba-ed4ee29929f9") },
                    { new Guid("a1c20840-6b3e-44d6-8f66-6e04b8253f20"), 8, "Flutter", new Guid("ffda6091-71b5-4b22-8d8d-0a3882aa5524"), new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), true, new Guid("73ba69e6-a7ad-483d-84b9-4cda53e34fe1") },
                    { new Guid("ae21848a-7f01-4e8c-93af-970dfa4fa004"), 7, "Azure", new Guid("c07d3a0b-b93c-4d6d-b6b5-646f91ca8aa8"), new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), true, new Guid("876e1396-13f7-40e3-8b12-b03cd709b762") },
                    { new Guid("d6525414-1c05-4e85-a79e-7d5239f60cd9"), 6, "Back end .NET", new Guid("0bd1d2c8-7c52-471f-bb03-1148aa7be952"), new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), true, new Guid("4e145946-4c21-4f2e-a8ba-ed4ee29929f9") },
                    { new Guid("de9d58a6-955e-47be-88e2-0d4ce751cfc5"), 3, "Typescript", new Guid("1e2efdac-2e17-4a6d-8929-de39b9db5d54"), new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), true, new Guid("b0bd4bf1-d769-4fef-a2c9-ee8596841566") },
                    { new Guid("e7dcd6c2-e80a-438e-ad7a-a85027029a62"), 9, "Back end .NET", new Guid("c3ccfdc4-807b-4769-b4c6-2b7081ec60b2"), new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), true, new Guid("55c0aaa0-6c28-48c9-935c-a7535c79fb77") }
                });

            migrationBuilder.InsertData(
                table: "SkillLink",
                columns: new[] { "SkillLinkId", "Level", "PersonId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("0b20f2af-c902-43bb-b985-a6f57be93230"), 3, new Guid("f888e8c4-9401-44e0-9ec6-65867b249889"), new Guid("d436a51e-5040-4c40-9c8c-1ad749fc6c4b") },
                    { new Guid("2372bce7-fbb1-48d3-9acc-35c73691d6fa"), 2, new Guid("9c1d3dfa-de29-4ea8-bb6b-1443d4a3160b"), new Guid("ca36c889-16c3-4d59-a702-f648993e5344") },
                    { new Guid("2de3cd15-f0ba-4d9b-a78e-38d04fc1d609"), 1, new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"), new Guid("c394cfbc-a4e0-4a9e-9f15-8d4ce3870c98") },
                    { new Guid("8fbee0c9-7bc1-42bf-8810-beba19ef8f8c"), 2, new Guid("f888e8c4-9401-44e0-9ec6-65867b249889"), new Guid("389a1adc-08cd-48a8-8997-c0ec04a05b5f") },
                    { new Guid("c70e9d79-60f5-4e93-b2d2-21cfccd0b9b4"), 1, new Guid("9c1d3dfa-de29-4ea8-bb6b-1443d4a3160b"), new Guid("3d955909-eba7-4e66-8240-6333ba2cbf02") },
                    { new Guid("d276e241-a4f5-40de-89a1-690735c0ec00"), 6, new Guid("f888e8c4-9401-44e0-9ec6-65867b249889"), new Guid("cb655180-1a9d-4627-8bf3-35fade999f03") },
                    { new Guid("d32b47ca-334f-40b6-a552-bec9aedeefc4"), 3, new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"), new Guid("389a1adc-08cd-48a8-8997-c0ec04a05b5f") },
                    { new Guid("d844f4fd-39c2-465b-a4f5-f8230b35490d"), 2, new Guid("92a8316e-08d8-4939-b974-90e6e36e6db8"), new Guid("773db846-42a3-4e36-8b2d-70d3404fad4e") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("4dd2e64c-9a8a-462f-ac5e-d0430ff8b22f"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("65e7172e-da9d-4124-b78c-65f7c14eb9ba"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("6a820aec-c77a-47d9-a54f-0c85abb2d0f6"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("8c7e3f2a-5e37-4592-8f65-28cd9dc4eae2"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("a6f745e4-7ecd-48c5-b418-22fab250a256"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("d2239273-d1e3-4dcc-8e7f-c46781b37c8e"));

            migrationBuilder.DeleteData(
                table: "LanguageLink",
                keyColumn: "LanguageLinkId",
                keyValue: new Guid("f583c77b-6749-45bc-a052-0b8b6f85e0ac"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("2775d42e-c6f6-417b-8860-7e21419c5718"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("6297cf87-08b5-49b6-9ca6-0dc0af6a3d21"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("1924e1c8-d73f-4d5c-85d2-ae4f584869f6"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("77959fdd-8bd0-47ed-a8c6-6a73ebfaa6b4"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("807982ab-bd68-4fde-aa7d-64ad6bbc53d1"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("82cc01c6-065a-429c-9d0e-fa28751d318b"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("a1c20840-6b3e-44d6-8f66-6e04b8253f20"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("ae21848a-7f01-4e8c-93af-970dfa4fa004"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("d6525414-1c05-4e85-a79e-7d5239f60cd9"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("de9d58a6-955e-47be-88e2-0d4ce751cfc5"));

            migrationBuilder.DeleteData(
                table: "Research",
                keyColumn: "ResearchId",
                keyValue: new Guid("e7dcd6c2-e80a-438e-ad7a-a85027029a62"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("0b20f2af-c902-43bb-b985-a6f57be93230"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("2372bce7-fbb1-48d3-9acc-35c73691d6fa"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("2de3cd15-f0ba-4d9b-a78e-38d04fc1d609"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("8fbee0c9-7bc1-42bf-8810-beba19ef8f8c"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("c70e9d79-60f5-4e93-b2d2-21cfccd0b9b4"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("d276e241-a4f5-40de-89a1-690735c0ec00"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("d32b47ca-334f-40b6-a552-bec9aedeefc4"));

            migrationBuilder.DeleteData(
                table: "SkillLink",
                keyColumn: "SkillLinkId",
                keyValue: new Guid("d844f4fd-39c2-465b-a4f5-f8230b35490d"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("0bd1d2c8-7c52-471f-bb03-1148aa7be952"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("1e2efdac-2e17-4a6d-8929-de39b9db5d54"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("47ed2fcf-5310-484b-b2ab-4686e78d8225"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("b002104e-1ad5-417a-8fe5-8587a87dc9df"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("c07d3a0b-b93c-4d6d-b6b5-646f91ca8aa8"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("c3ccfdc4-807b-4769-b4c6-2b7081ec60b2"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: new Guid("ffda6091-71b5-4b22-8d8d-0a3882aa5524"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("6b7b2537-ecc6-48d6-8135-fce805efb951"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("6bc54b48-f5a7-4b17-a3b9-a59a8d4ed990"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("837f6f53-731c-4ee4-8121-5f4baf9a5471"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("8c20c694-be30-4294-890e-aacd0d1f5cf7"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("ca1c7e34-9d3b-4baf-9c7d-5bc4dfb03360"));

            migrationBuilder.DeleteData(
                table: "LanguageLevel",
                keyColumn: "LanguageLevelId",
                keyValue: new Guid("fa028f12-c30a-497c-8e4a-072eb567483f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("92a8316e-08d8-4939-b974-90e6e36e6db8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("98851f86-9dc5-4a96-9258-8a80c35abbcd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("9c1d3dfa-de29-4ea8-bb6b-1443d4a3160b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("ebfce3c9-342c-4c36-b585-7028647653e1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("f888e8c4-9401-44e0-9ec6-65867b249889"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("55c0aaa0-6c28-48c9-935c-a7535c79fb77"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("876e1396-13f7-40e3-8b12-b03cd709b762"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("389a1adc-08cd-48a8-8997-c0ec04a05b5f"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("3d955909-eba7-4e66-8240-6333ba2cbf02"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("773db846-42a3-4e36-8b2d-70d3404fad4e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("c394cfbc-a4e0-4a9e-9f15-8d4ce3870c98"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("ca36c889-16c3-4d59-a702-f648993e5344"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("cb655180-1a9d-4627-8bf3-35fade999f03"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: new Guid("d436a51e-5040-4c40-9c8c-1ad749fc6c4b"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("4e145946-4c21-4f2e-a8ba-ed4ee29929f9"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("73ba69e6-a7ad-483d-84b9-4cda53e34fe1"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "SiteId",
                keyValue: new Guid("b0bd4bf1-d769-4fef-a2c9-ee8596841566"));

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("1463eb74-27f6-461c-af24-2ca80de38b0b"), 4, "Spanish" },
                    { new Guid("1e9efb3e-9ffd-4355-9384-c55a72c68a5e"), 5, "Italian" },
                    { new Guid("3da89920-aedd-4294-9221-c10962480cbf"), 3, "German" },
                    { new Guid("40cd2ed1-157c-433a-8d5e-b61435b9832d"), 7, "Russian" },
                    { new Guid("77b7dc8b-83fc-4657-b5c0-41395abcf147"), 2, "French" },
                    { new Guid("a8d112e3-557e-4c61-a630-d713d4862ab6"), 1, "English" },
                    { new Guid("b8c6605e-b1ce-4976-8cb4-8bc04e4bad78"), 6, "Portuguese" }
                });

            migrationBuilder.InsertData(
                table: "LanguageLevel",
                columns: new[] { "LanguageLevelId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("04341876-adcb-4b79-9f84-cc8e06db424b"), 6, "Advanced" },
                    { new Guid("044f27db-681f-4257-b0c8-75071101db34"), 2, "Elementary" },
                    { new Guid("0d0b8502-a65b-4d10-aa90-63e22395b2fb"), 1, "Beginner" },
                    { new Guid("8011174b-e603-4eb9-aff0-b6a3a899e9e1"), 4, "Intermediate" },
                    { new Guid("861923f9-4be1-44cd-bf00-4dfbe17a54f2"), 3, "Pre-Intermediate" },
                    { new Guid("c234120b-3ef5-4ce5-a62a-526ab42e961c"), 5, "Upper-Intermediate" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "SiteId", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("1d914145-a5fe-4520-ad42-3717675a71b2"), 3, "WASHINGTON" },
                    { new Guid("28fbf520-a19e-4553-8826-7a60a10708f5"), 4, "LOS ANGELES" },
                    { new Guid("49af6298-9c9c-4b04-8cb0-ba937ddd3de1"), 2, "CHICAGO" },
                    { new Guid("7341dba2-4d08-4541-9883-e81426163b2f"), 1, "NEW YORK" },
                    { new Guid("f4cb59af-33ac-443d-aed1-6c591945426b"), 5, "LONDON" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Code", "Description", "FEBEDevops", "ProjectRef", "Technology", "WebMobile" },
                values: new object[,]
                {
                    { new Guid("266bff84-1da2-4119-9743-c7a10472914c"), 6, ".NET", ".NET", "", "", "" },
                    { new Guid("6daa2766-c7b5-48cb-aae7-3dbd8b9dccad"), 7, "SMSS", "", "", "SSMS", "" },
                    { new Guid("8c026223-a821-4082-ae32-4e911a897e81"), 2, "TS", "", "", "", "typescript" },
                    { new Guid("8f44eba1-a1d2-41fa-871b-fe8801e1ae48"), 4, "Flutter", "", "", "", "Flutter" },
                    { new Guid("e5892717-05b0-4a3d-97cd-d1bad1c4a752"), 3, "Azure", "Azure", "", "", "" },
                    { new Guid("e97c4ff8-7d4c-4c98-8bc1-cab467796209"), 1, "Angular 9", "", "", "", "angular" },
                    { new Guid("ff73dc3c-da66-4180-bd12-418218fc78c9"), 5, "Iot", "", "", "Iot", "" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Code", "IsRecruiter", "Name", "Position", "Remote", "SiteId", "Surnamme", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("12659b26-34ff-4c11-8dc2-f6c61cce6a56"), 4, false, "Mario", "dev", true, new Guid("7341dba2-4d08-4541-9883-e81426163b2f"), "Rossi", 2 },
                    { new Guid("59cc2c9c-f8dc-4f41-ac99-8db57084ac3b"), 5, false, "Giovanni", "dev", true, new Guid("1d914145-a5fe-4520-ad42-3717675a71b2"), "Bianchi", 4 },
                    { new Guid("806c66c9-5e1c-44e7-8955-250d495423af"), 7, false, "Giovanni", "dev", true, new Guid("f4cb59af-33ac-443d-aed1-6c591945426b"), "Novembre", 1 },
                    { new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), 2, true, "Mario", "recuiter", true, new Guid("49af6298-9c9c-4b04-8cb0-ba937ddd3de1"), "Rossi", 2 },
                    { new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), 3, true, "Mario", "recruiter", false, new Guid("7341dba2-4d08-4541-9883-e81426163b2f"), "Rossi", 2 },
                    { new Guid("f76cf32c-13d9-455e-a131-3d09cef5a96b"), 6, false, "Alessandra", "dev", true, new Guid("49af6298-9c9c-4b04-8cb0-ba937ddd3de1"), "Verdi", 15 },
                    { new Guid("fc632d76-4654-4a77-ae65-afc9db13d052"), 1, false, "Nicoletta", "dev", false, new Guid("7341dba2-4d08-4541-9883-e81426163b2f"), "Morsia", 2 }
                });

            migrationBuilder.InsertData(
                table: "LanguageLink",
                columns: new[] { "LanguageLinkId", "LanguageId", "LanguageLevelId", "PersonId", "Preferred" },
                values: new object[,]
                {
                    { new Guid("17deac7b-0f01-4c4c-9f92-e06d923c661f"), new Guid("b8c6605e-b1ce-4976-8cb4-8bc04e4bad78"), new Guid("8011174b-e603-4eb9-aff0-b6a3a899e9e1"), new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), false },
                    { new Guid("446225b9-b9fe-41e3-a844-d5878ad53811"), new Guid("a8d112e3-557e-4c61-a630-d713d4862ab6"), new Guid("861923f9-4be1-44cd-bf00-4dfbe17a54f2"), new Guid("fc632d76-4654-4a77-ae65-afc9db13d052"), true },
                    { new Guid("6300eaf6-529e-4395-bbdc-7e54d591c769"), new Guid("1e9efb3e-9ffd-4355-9384-c55a72c68a5e"), new Guid("861923f9-4be1-44cd-bf00-4dfbe17a54f2"), new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), true },
                    { new Guid("94ff32b3-473e-4698-b560-4982b629fa71"), new Guid("3da89920-aedd-4294-9221-c10962480cbf"), new Guid("0d0b8502-a65b-4d10-aa90-63e22395b2fb"), new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), true },
                    { new Guid("a54e8920-c88b-416a-bc22-c8e6139164dd"), new Guid("40cd2ed1-157c-433a-8d5e-b61435b9832d"), new Guid("c234120b-3ef5-4ce5-a62a-526ab42e961c"), new Guid("12659b26-34ff-4c11-8dc2-f6c61cce6a56"), true },
                    { new Guid("acaf7326-23e8-45b2-b060-41ab7567b1ed"), new Guid("1463eb74-27f6-461c-af24-2ca80de38b0b"), new Guid("044f27db-681f-4257-b0c8-75071101db34"), new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), false },
                    { new Guid("d43a68e1-72a8-440b-a314-af5bf1300292"), new Guid("77b7dc8b-83fc-4657-b5c0-41395abcf147"), new Guid("04341876-adcb-4b79-9f84-cc8e06db424b"), new Guid("fc632d76-4654-4a77-ae65-afc9db13d052"), false }
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "ResearchId", "Code", "Description", "LanguageId", "PersonId", "Remote", "SiteId" },
                values: new object[,]
                {
                    { new Guid("06b9af06-213a-4b72-b478-c08be6acaba8"), 2, "Back end .NET", new Guid("77b7dc8b-83fc-4657-b5c0-41395abcf147"), new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), true, new Guid("49af6298-9c9c-4b04-8cb0-ba937ddd3de1") },
                    { new Guid("24f6fb32-7f85-40ff-9d86-87504192f1b2"), 5, "Smss", new Guid("1463eb74-27f6-461c-af24-2ca80de38b0b"), new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), false, new Guid("f4cb59af-33ac-443d-aed1-6c591945426b") },
                    { new Guid("30fbd7fe-ce33-45a4-9a14-de522ca2a6bb"), 7, "Azure", new Guid("1463eb74-27f6-461c-af24-2ca80de38b0b"), new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), true, new Guid("28fbf520-a19e-4553-8826-7a60a10708f5") },
                    { new Guid("4e885b47-2c84-4955-bb4f-5eb77074bdf1"), 6, "Back end .NET", new Guid("1e9efb3e-9ffd-4355-9384-c55a72c68a5e"), new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), true, new Guid("49af6298-9c9c-4b04-8cb0-ba937ddd3de1") },
                    { new Guid("4f9b2724-576d-43c7-b413-89518134dfd5"), 8, "Flutter", new Guid("b8c6605e-b1ce-4976-8cb4-8bc04e4bad78"), new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), true, new Guid("7341dba2-4d08-4541-9883-e81426163b2f") },
                    { new Guid("72f1a13f-3a39-4668-b1bc-61ac6f2eb47f"), 3, "Typescript", new Guid("a8d112e3-557e-4c61-a630-d713d4862ab6"), new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), true, new Guid("1d914145-a5fe-4520-ad42-3717675a71b2") },
                    { new Guid("d6ba76a1-914e-438b-961c-093654ba69d3"), 4, "Azure", new Guid("3da89920-aedd-4294-9221-c10962480cbf"), new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), false, new Guid("28fbf520-a19e-4553-8826-7a60a10708f5") },
                    { new Guid("dd24036e-3bfd-49a7-81bd-9caed7352341"), 9, "Back end .NET", new Guid("40cd2ed1-157c-433a-8d5e-b61435b9832d"), new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), true, new Guid("f4cb59af-33ac-443d-aed1-6c591945426b") },
                    { new Guid("e09f20d4-6404-47c9-b70c-20e91409b7fc"), 1, "Front end Angular", new Guid("a8d112e3-557e-4c61-a630-d713d4862ab6"), new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), true, new Guid("7341dba2-4d08-4541-9883-e81426163b2f") }
                });

            migrationBuilder.InsertData(
                table: "SkillLink",
                columns: new[] { "SkillLinkId", "Level", "PersonId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("18287d82-6007-49a7-8bf7-de537ba8d475"), 2, new Guid("fc632d76-4654-4a77-ae65-afc9db13d052"), new Guid("8c026223-a821-4082-ae32-4e911a897e81") },
                    { new Guid("3555149a-ae06-4436-8d1d-815d4faa9eaa"), 2, new Guid("59cc2c9c-f8dc-4f41-ac99-8db57084ac3b"), new Guid("6daa2766-c7b5-48cb-aae7-3dbd8b9dccad") },
                    { new Guid("3e4999f7-eded-4bc8-be1a-6c18f9087d8e"), 1, new Guid("fc632d76-4654-4a77-ae65-afc9db13d052"), new Guid("e97c4ff8-7d4c-4c98-8bc1-cab467796209") },
                    { new Guid("8ef412ed-b8d8-4d22-81c2-4968c4649aac"), 1, new Guid("d49f1356-cc49-4584-9ee7-7fb1a98309d5"), new Guid("8f44eba1-a1d2-41fa-871b-fe8801e1ae48") },
                    { new Guid("b4636a71-48a4-4b00-8501-9ceb4882d6b1"), 2, new Guid("12659b26-34ff-4c11-8dc2-f6c61cce6a56"), new Guid("e5892717-05b0-4a3d-97cd-d1bad1c4a752") },
                    { new Guid("be5bd0a7-7f99-42ee-9ae2-4e2ce822d6b9"), 6, new Guid("12659b26-34ff-4c11-8dc2-f6c61cce6a56"), new Guid("ff73dc3c-da66-4180-bd12-418218fc78c9") },
                    { new Guid("d52965bb-0aee-4875-83ee-a19d64f1a810"), 3, new Guid("12659b26-34ff-4c11-8dc2-f6c61cce6a56"), new Guid("266bff84-1da2-4119-9743-c7a10472914c") },
                    { new Guid("fb953e6a-4eb0-416a-868f-0accad9f4594"), 3, new Guid("98d175b8-2c9b-437a-827b-63481e4bf9e9"), new Guid("e5892717-05b0-4a3d-97cd-d1bad1c4a752") }
                });
        }
    }
}
