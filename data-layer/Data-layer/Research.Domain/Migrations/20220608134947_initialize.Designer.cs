﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Research.Domain.Context;

#nullable disable

namespace Research.Domain.Migrations
{
    [DbContext(typeof(ResearchContext))]
    [Migration("20220608134947_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Research.Domain.Entity.Language", b =>
                {
                    b.Property<Guid>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            LanguageId = new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"),
                            Code = 1,
                            Description = "English"
                        },
                        new
                        {
                            LanguageId = new Guid("95ef9726-3a87-43cb-ac5d-95e629f3a5ef"),
                            Code = 2,
                            Description = "French"
                        },
                        new
                        {
                            LanguageId = new Guid("126412c8-d142-439a-8790-fa41806b7996"),
                            Code = 3,
                            Description = "German"
                        },
                        new
                        {
                            LanguageId = new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"),
                            Code = 4,
                            Description = "Spanish"
                        },
                        new
                        {
                            LanguageId = new Guid("461ef141-f99e-4358-a6a1-8711102d8422"),
                            Code = 5,
                            Description = "Italian"
                        },
                        new
                        {
                            LanguageId = new Guid("452979c6-bfaa-4aef-b521-43fb5ab6b5fd"),
                            Code = 6,
                            Description = "Portuguese"
                        },
                        new
                        {
                            LanguageId = new Guid("2cd6764a-4aa7-4076-a013-c460a1b06552"),
                            Code = 7,
                            Description = "Russian"
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.LanguageLevel", b =>
                {
                    b.Property<Guid>("LanguageLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageLevelId");

                    b.ToTable("LanguageLevel");

                    b.HasData(
                        new
                        {
                            LanguageLevelId = new Guid("bb79aa2d-68f2-49bd-a8d8-cd196b5c304b"),
                            Code = 1,
                            Description = "Beginner"
                        },
                        new
                        {
                            LanguageLevelId = new Guid("d05ec7a8-ee43-49f9-8806-773c8fabfe2d"),
                            Code = 2,
                            Description = "Elementary"
                        },
                        new
                        {
                            LanguageLevelId = new Guid("65f15268-b8e1-450e-b849-630c5fcdc7c4"),
                            Code = 3,
                            Description = "Pre-Intermediate"
                        },
                        new
                        {
                            LanguageLevelId = new Guid("9367ac9f-e73e-456b-94a6-8b74746821d9"),
                            Code = 4,
                            Description = "Intermediate"
                        },
                        new
                        {
                            LanguageLevelId = new Guid("d0846799-ae10-4423-b626-c2645b3ebd3c"),
                            Code = 5,
                            Description = "Upper-Intermediate"
                        },
                        new
                        {
                            LanguageLevelId = new Guid("6f7babe6-9373-41ff-b0c0-15cad4c86575"),
                            Code = 6,
                            Description = "Advanced"
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.LanguageLink", b =>
                {
                    b.Property<Guid>("LanguageLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LanguageLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Preferred")
                        .HasColumnType("bit");

                    b.HasKey("LanguageLinkId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("LanguageLevelId");

                    b.HasIndex("PersonId");

                    b.ToTable("LanguageLink");

                    b.HasData(
                        new
                        {
                            LanguageLinkId = new Guid("6bde5d37-22a6-4e01-b141-7b91f44baf98"),
                            LanguageId = new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"),
                            LanguageLevelId = new Guid("65f15268-b8e1-450e-b849-630c5fcdc7c4"),
                            PersonId = new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"),
                            Preferred = true
                        },
                        new
                        {
                            LanguageLinkId = new Guid("ca575305-0be3-4514-bc3c-81c33b3dea6c"),
                            LanguageId = new Guid("95ef9726-3a87-43cb-ac5d-95e629f3a5ef"),
                            LanguageLevelId = new Guid("6f7babe6-9373-41ff-b0c0-15cad4c86575"),
                            PersonId = new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"),
                            Preferred = false
                        },
                        new
                        {
                            LanguageLinkId = new Guid("653b4538-2394-4204-a2d0-a6fc469288d3"),
                            LanguageId = new Guid("126412c8-d142-439a-8790-fa41806b7996"),
                            LanguageLevelId = new Guid("bb79aa2d-68f2-49bd-a8d8-cd196b5c304b"),
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Preferred = true
                        },
                        new
                        {
                            LanguageLinkId = new Guid("e0d1e0cc-4a7a-4afc-b042-ac613be58fa3"),
                            LanguageId = new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"),
                            LanguageLevelId = new Guid("d05ec7a8-ee43-49f9-8806-773c8fabfe2d"),
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Preferred = false
                        },
                        new
                        {
                            LanguageLinkId = new Guid("0fa95d29-9a13-40a9-905d-0f779c12d601"),
                            LanguageId = new Guid("461ef141-f99e-4358-a6a1-8711102d8422"),
                            LanguageLevelId = new Guid("65f15268-b8e1-450e-b849-630c5fcdc7c4"),
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            Preferred = true
                        },
                        new
                        {
                            LanguageLinkId = new Guid("e5f07299-a711-4f15-bf6d-d1e1310504a9"),
                            LanguageId = new Guid("452979c6-bfaa-4aef-b521-43fb5ab6b5fd"),
                            LanguageLevelId = new Guid("9367ac9f-e73e-456b-94a6-8b74746821d9"),
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            Preferred = false
                        },
                        new
                        {
                            LanguageLinkId = new Guid("25279a4d-f266-4add-9d2b-21ed1f408168"),
                            LanguageId = new Guid("2cd6764a-4aa7-4076-a013-c460a1b06552"),
                            LanguageLevelId = new Guid("d0846799-ae10-4423-b626-c2645b3ebd3c"),
                            PersonId = new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"),
                            Preferred = true
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.Match", b =>
                {
                    b.Property<Guid>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("MatchAcceptedByEmployee")
                        .HasColumnType("bit");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ResearchId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MatchId");

                    b.HasIndex("PersonId");

                    b.HasIndex("ResearchId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("Research.Domain.Entity.Person", b =>
                {
                    b.Property<Guid>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<bool>("IsRecruiter")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Remote")
                        .HasColumnType("bit");

                    b.Property<Guid?>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surnamme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("SiteId");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            PersonId = new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"),
                            Code = 1,
                            IsRecruiter = false,
                            Name = "Nicoletta",
                            Position = "dev",
                            Remote = false,
                            SiteId = new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"),
                            Surnamme = "Morsia",
                            YearsOfExperience = 2
                        },
                        new
                        {
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Code = 2,
                            IsRecruiter = true,
                            Name = "Mario",
                            Position = "recuiter",
                            Remote = true,
                            SiteId = new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39"),
                            Surnamme = "Rossi",
                            YearsOfExperience = 2
                        },
                        new
                        {
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            Code = 3,
                            IsRecruiter = true,
                            Name = "Mario",
                            Position = "recruiter",
                            Remote = false,
                            SiteId = new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"),
                            Surnamme = "Rossi",
                            YearsOfExperience = 2
                        },
                        new
                        {
                            PersonId = new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"),
                            Code = 4,
                            IsRecruiter = false,
                            Name = "Mario",
                            Position = "dev",
                            Remote = true,
                            SiteId = new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"),
                            Surnamme = "Rossi",
                            YearsOfExperience = 2
                        },
                        new
                        {
                            PersonId = new Guid("c1a7eb76-651b-4c10-96a8-27328c722eec"),
                            Code = 5,
                            IsRecruiter = false,
                            Name = "Giovanni",
                            Position = "dev",
                            Remote = true,
                            SiteId = new Guid("3ff5b4a0-6950-431e-9036-4730ebe3668c"),
                            Surnamme = "Bianchi",
                            YearsOfExperience = 4
                        },
                        new
                        {
                            PersonId = new Guid("7b81a1d6-d343-47a8-ad87-d2bf94e73327"),
                            Code = 6,
                            IsRecruiter = false,
                            Name = "Alessandra",
                            Position = "dev",
                            Remote = true,
                            SiteId = new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39"),
                            Surnamme = "Verdi",
                            YearsOfExperience = 15
                        },
                        new
                        {
                            PersonId = new Guid("c567c61b-4d95-4f3b-b4b6-0aabf6dff459"),
                            Code = 7,
                            IsRecruiter = false,
                            Name = "Giovanni",
                            Position = "dev",
                            Remote = true,
                            SiteId = new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce"),
                            Surnamme = "Novembre",
                            YearsOfExperience = 1
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.Research", b =>
                {
                    b.Property<Guid>("ResearchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Remote")
                        .HasColumnType("bit");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ResearchId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PersonId");

                    b.HasIndex("SiteId");

                    b.ToTable("Research");

                    b.HasData(
                        new
                        {
                            ResearchId = new Guid("be14ee89-3158-4652-97ae-93cd7d491529"),
                            Code = 1,
                            Description = "Front end Angular",
                            LanguageId = new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"),
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Remote = true,
                            SiteId = new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a")
                        },
                        new
                        {
                            ResearchId = new Guid("7dcea56c-595f-43c9-b8f4-e109f6f8bfb5"),
                            Code = 2,
                            Description = "Back end .NET",
                            LanguageId = new Guid("95ef9726-3a87-43cb-ac5d-95e629f3a5ef"),
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Remote = true,
                            SiteId = new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39")
                        },
                        new
                        {
                            ResearchId = new Guid("da87d61e-c0b7-4d7f-b770-efbe7d7ea563"),
                            Code = 3,
                            Description = "Typescript",
                            LanguageId = new Guid("84aaa76c-efff-417d-b8cf-94ea6dfaf7c7"),
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Remote = true,
                            SiteId = new Guid("3ff5b4a0-6950-431e-9036-4730ebe3668c")
                        },
                        new
                        {
                            ResearchId = new Guid("bf73ad97-64e1-4dd5-8ac4-6cec81a18cdd"),
                            Code = 4,
                            Description = "Azure",
                            LanguageId = new Guid("126412c8-d142-439a-8790-fa41806b7996"),
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Remote = false,
                            SiteId = new Guid("960eba91-1c88-474a-90f6-0737e2abb8f5")
                        },
                        new
                        {
                            ResearchId = new Guid("8c394c3d-4b20-4982-aed4-c44900a0819d"),
                            Code = 5,
                            Description = "Smss",
                            LanguageId = new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"),
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            Remote = false,
                            SiteId = new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce")
                        },
                        new
                        {
                            ResearchId = new Guid("099c0f69-c4e4-4aac-ab1f-7322fb5882e0"),
                            Code = 6,
                            Description = "Back end .NET",
                            LanguageId = new Guid("461ef141-f99e-4358-a6a1-8711102d8422"),
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            Remote = true,
                            SiteId = new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39")
                        },
                        new
                        {
                            ResearchId = new Guid("b5c14745-c33e-4654-9fcd-4dac60d68724"),
                            Code = 7,
                            Description = "Azure",
                            LanguageId = new Guid("cf1b8b03-adcb-43ac-a8c9-c3ed49bd4c31"),
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            Remote = true,
                            SiteId = new Guid("960eba91-1c88-474a-90f6-0737e2abb8f5")
                        },
                        new
                        {
                            ResearchId = new Guid("1e87989c-bfc3-484c-97b6-9b9d568e8b59"),
                            Code = 8,
                            Description = "Flutter",
                            LanguageId = new Guid("452979c6-bfaa-4aef-b521-43fb5ab6b5fd"),
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            Remote = true,
                            SiteId = new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a")
                        },
                        new
                        {
                            ResearchId = new Guid("ba5233d9-f106-4933-9f2c-f6659f16110b"),
                            Code = 9,
                            Description = "Back end .NET",
                            LanguageId = new Guid("2cd6764a-4aa7-4076-a013-c460a1b06552"),
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            Remote = true,
                            SiteId = new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce")
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.Site", b =>
                {
                    b.Property<Guid>("SiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteId");

                    b.ToTable("Site");

                    b.HasData(
                        new
                        {
                            SiteId = new Guid("c684920d-691f-494b-9b4d-f9813b6f5c3a"),
                            Code = 1,
                            Description = "NEW YORK"
                        },
                        new
                        {
                            SiteId = new Guid("0b8bcc1e-2afa-4b48-a387-b552355a5b39"),
                            Code = 2,
                            Description = "CHICAGO"
                        },
                        new
                        {
                            SiteId = new Guid("3ff5b4a0-6950-431e-9036-4730ebe3668c"),
                            Code = 3,
                            Description = "WASHINGTON"
                        },
                        new
                        {
                            SiteId = new Guid("960eba91-1c88-474a-90f6-0737e2abb8f5"),
                            Code = 4,
                            Description = "LOS ANGELES"
                        },
                        new
                        {
                            SiteId = new Guid("2a2b657f-b1db-4da9-b1b6-f40cce0b46ce"),
                            Code = 5,
                            Description = "LONDON"
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.Skill", b =>
                {
                    b.Property<Guid>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FEBEDevops")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectRef")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skill");

                    b.HasData(
                        new
                        {
                            SkillId = new Guid("4a086652-b7a3-407f-ae75-98015d30a593"),
                            Code = 1,
                            Description = "Angular 9",
                            FEBEDevops = "",
                            ProjectRef = "",
                            Technology = "",
                            WebMobile = "angular"
                        },
                        new
                        {
                            SkillId = new Guid("38bacb15-edff-497b-8780-f3870de6a7ac"),
                            Code = 2,
                            Description = "TS",
                            FEBEDevops = "",
                            ProjectRef = "",
                            Technology = "",
                            WebMobile = "typescript"
                        },
                        new
                        {
                            SkillId = new Guid("ecff704d-e320-4b89-9f56-0d2622aeda9d"),
                            Code = 3,
                            Description = "Azure",
                            FEBEDevops = "Azure",
                            ProjectRef = "",
                            Technology = "",
                            WebMobile = ""
                        },
                        new
                        {
                            SkillId = new Guid("ffb6944c-af40-44a6-8b14-b25001c608eb"),
                            Code = 4,
                            Description = "Flutter",
                            FEBEDevops = "",
                            ProjectRef = "",
                            Technology = "",
                            WebMobile = "Flutter"
                        },
                        new
                        {
                            SkillId = new Guid("fdfdc6ae-9f49-4529-8fce-c22fb41e98de"),
                            Code = 5,
                            Description = "Iot",
                            FEBEDevops = "",
                            ProjectRef = "",
                            Technology = "Iot",
                            WebMobile = ""
                        },
                        new
                        {
                            SkillId = new Guid("f7572b8d-b6cc-46a0-8fa9-fd38b4b97f1e"),
                            Code = 6,
                            Description = ".NET",
                            FEBEDevops = ".NET",
                            ProjectRef = "",
                            Technology = "",
                            WebMobile = ""
                        },
                        new
                        {
                            SkillId = new Guid("cdc68fbd-e81c-417e-b67a-0e89365bd85d"),
                            Code = 7,
                            Description = "SMSS",
                            FEBEDevops = "",
                            ProjectRef = "",
                            Technology = "SSMS",
                            WebMobile = ""
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.SkillLink", b =>
                {
                    b.Property<Guid>("SkillLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SkillLinkId");

                    b.HasIndex("PersonId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillLink");

                    b.HasData(
                        new
                        {
                            SkillLinkId = new Guid("0b96ed92-8ee7-47c0-ae14-ddcc297e0bb7"),
                            Level = 1,
                            PersonId = new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"),
                            SkillId = new Guid("4a086652-b7a3-407f-ae75-98015d30a593")
                        },
                        new
                        {
                            SkillLinkId = new Guid("939c2e4d-7325-476f-a1fa-8de191136434"),
                            Level = 2,
                            PersonId = new Guid("b689d378-f7f1-4f9a-890b-ee967b6a014a"),
                            SkillId = new Guid("38bacb15-edff-497b-8780-f3870de6a7ac")
                        },
                        new
                        {
                            SkillLinkId = new Guid("525aaa26-ba54-4b30-aa5d-d5fb8ad559ff"),
                            Level = 3,
                            PersonId = new Guid("3dbdff94-e5b0-4503-9622-99a55359210f"),
                            SkillId = new Guid("ecff704d-e320-4b89-9f56-0d2622aeda9d")
                        },
                        new
                        {
                            SkillLinkId = new Guid("cb406ebd-5350-4fa9-9f93-911bf4c12675"),
                            Level = 1,
                            PersonId = new Guid("2139354f-d92e-4799-ba64-0f11d310e4e1"),
                            SkillId = new Guid("ffb6944c-af40-44a6-8b14-b25001c608eb")
                        },
                        new
                        {
                            SkillLinkId = new Guid("ea0fb5b1-3d73-4e74-a97b-a1f839c0e7b9"),
                            Level = 6,
                            PersonId = new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"),
                            SkillId = new Guid("fdfdc6ae-9f49-4529-8fce-c22fb41e98de")
                        },
                        new
                        {
                            SkillLinkId = new Guid("51bcbc4c-24a6-4c8e-8eaf-1b215ab39ac7"),
                            Level = 3,
                            PersonId = new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"),
                            SkillId = new Guid("f7572b8d-b6cc-46a0-8fa9-fd38b4b97f1e")
                        },
                        new
                        {
                            SkillLinkId = new Guid("116adc8e-fe03-4e3e-9f31-52adbcfd8a0e"),
                            Level = 2,
                            PersonId = new Guid("47897412-f70e-4f01-9a67-fd8474838ca8"),
                            SkillId = new Guid("ecff704d-e320-4b89-9f56-0d2622aeda9d")
                        },
                        new
                        {
                            SkillLinkId = new Guid("c3578201-9e89-43d5-a7a8-242604f4cc61"),
                            Level = 2,
                            PersonId = new Guid("c1a7eb76-651b-4c10-96a8-27328c722eec"),
                            SkillId = new Guid("cdc68fbd-e81c-417e-b67a-0e89365bd85d")
                        });
                });

            modelBuilder.Entity("Research.Domain.Entity.LanguageLink", b =>
                {
                    b.HasOne("Research.Domain.Entity.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Research.Domain.Entity.LanguageLevel", "LanguageLevel")
                        .WithMany()
                        .HasForeignKey("LanguageLevelId");

                    b.HasOne("Research.Domain.Entity.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("LanguageLevel");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Research.Domain.Entity.Match", b =>
                {
                    b.HasOne("Research.Domain.Entity.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Research.Domain.Entity.Research", "Research")
                        .WithMany()
                        .HasForeignKey("ResearchId");

                    b.Navigation("Person");

                    b.Navigation("Research");
                });

            modelBuilder.Entity("Research.Domain.Entity.Person", b =>
                {
                    b.HasOne("Research.Domain.Entity.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("Research.Domain.Entity.Research", b =>
                {
                    b.HasOne("Research.Domain.Entity.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Research.Domain.Entity.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Research.Domain.Entity.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Person");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("Research.Domain.Entity.SkillLink", b =>
                {
                    b.HasOne("Research.Domain.Entity.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Research.Domain.Entity.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Skill");
                });
#pragma warning restore 612, 618
        }
    }
}