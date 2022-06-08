using Microsoft.EntityFrameworkCore;
using Research.Domain.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;


namespace Research.Domain.Context
{
    public class ResearchContext : DbContext
    {
        public DbSet<Language> Language { get; set; }
        public DbSet<LanguageLevel> LanguageLevel { get; set; }
        public DbSet<LanguageLink> LanguageLink { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Entity.Research> Research { get; set; }
        public DbSet<Site> Site { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillLink> SkillLink { get; set; }
        public DbSet<Match> Match { get; set; }

        public string _connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=App;Trusted_Connection=True;";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Language
            var language1 = Guid.NewGuid();
            var language2 = Guid.NewGuid();
            var language3 = Guid.NewGuid();
            var language4 = Guid.NewGuid();
            var language5 = Guid.NewGuid();
            var language6 = Guid.NewGuid();
            var language7 = Guid.NewGuid();

            var languages = new List<Guid>();
            languages.Add(language1);
            languages.Add(language2);
            languages.Add(language3);
            languages.Add(language4);
            languages.Add(language5);
            languages.Add(language6);
            languages.Add(language7);

            modelBuilder.Entity<Language>().HasData(
                new Language { LanguageId = language1, Code = 1, Description = "English" },
                new Language { LanguageId = language2, Code = 2, Description = "French" },
                new Language { LanguageId = language3, Code = 3, Description = "German" },
                new Language { LanguageId = language4, Code = 4, Description = "Spanish" },
                new Language { LanguageId = language5, Code = 5, Description = "Italian" },
                new Language { LanguageId = language6, Code = 6, Description = "Portuguese" },
                new Language { LanguageId = language7, Code = 7, Description = "Russian" }
                );
            #endregion

            #region LanguageLevel

            /////
            var level1 = Guid.NewGuid();
            var level2 = Guid.NewGuid();
            var level3 = Guid.NewGuid();
            var level4 = Guid.NewGuid();
            var level5 = Guid.NewGuid();
            var level6 = Guid.NewGuid();

            modelBuilder.Entity<LanguageLevel>().HasData(
                new LanguageLevel { LanguageLevelId = level1, Code = 1, Description = "Beginner" },
                new LanguageLevel { LanguageLevelId = level2, Code = 2, Description = "Elementary" },
                new LanguageLevel { LanguageLevelId = level3, Code = 3, Description = "Pre-Intermediate" },
                new LanguageLevel { LanguageLevelId = level4, Code = 4, Description = "Intermediate" },
                new LanguageLevel { LanguageLevelId = level5, Code = 5, Description = "Upper-Intermediate" },
                new LanguageLevel { LanguageLevelId = level6, Code = 6, Description = "Advanced" }
                );

            #endregion

            #region Site
            ///
            
            var site1 = Guid.NewGuid();
            var site2 = Guid.NewGuid();
            var site3 = Guid.NewGuid();
            var site4 = Guid.NewGuid();
            var site5 = Guid.NewGuid();

            var sites = new List<Guid>();
            sites.Add(site1);
            sites.Add(site2);
            sites.Add(site3);
            sites.Add(site4);
            sites.Add(site5);

            modelBuilder.Entity<Site>().HasData(
                new Site { SiteId = site1, Code = 1, Description = "NEW YORK" },
                new Site { SiteId = site2, Code = 2, Description = "CHICAGO" },
                new Site { SiteId = site3, Code = 3, Description = "WASHINGTON" },
                new Site { SiteId = site4, Code = 4, Description = "LOS ANGELES" },
                new Site { SiteId = site5, Code = 5, Description = "LONDON" }
                );

            /////
            #endregion

            #region Skill

            var skill1 = Guid.NewGuid();
            var skill2 = Guid.NewGuid();
            var skill3 = Guid.NewGuid();
            var skill4 = Guid.NewGuid();
            var skill5 = Guid.NewGuid();
            var skill6 = Guid.NewGuid();
            var skill7 = Guid.NewGuid();

            var skillss = new List<Guid>();
            skillss.Add(skill1);
            skillss.Add(skill2);
            skillss.Add(skill3);
            skillss.Add(skill4);
            skillss.Add(skill5);
            skillss.Add(skill6);
            skillss.Add(skill7);

            modelBuilder.Entity<Skill>().HasData(
                new Skill { SkillId = skill1, Code = 1, FEBEDevops = "", WebMobile ="angular", Technology = "", ProjectRef = "", Description = "Angular 9" },
                new Skill { SkillId = skill2, Code = 2, FEBEDevops = "" , WebMobile = "typescript", Technology = "", ProjectRef = "", Description = "TS" },
                new Skill { SkillId = skill3, Code = 3, FEBEDevops = "Azure", WebMobile = "", Technology = "", ProjectRef = "", Description = "Azure" },
                new Skill { SkillId = skill4, Code = 4, FEBEDevops = "", WebMobile = "Flutter", Technology = "", ProjectRef = "", Description = "Flutter" },
                new Skill { SkillId = skill5, Code = 5, FEBEDevops = "", WebMobile = "", Technology = "Iot", ProjectRef = "", Description = "Iot" },
                new Skill { SkillId = skill6, Code = 6, FEBEDevops = ".NET", WebMobile = "", Technology = "", ProjectRef = "", Description = ".NET" },
                new Skill { SkillId = skill7, Code = 7, FEBEDevops = "", WebMobile = "", Technology = "SSMS", ProjectRef = "", Description = "SMSS" }
                );

            #endregion

            #region Person

            var person1 = Guid.NewGuid();
            var person2 = Guid.NewGuid();
            var person3 = Guid.NewGuid();
            var person4 = Guid.NewGuid();
            var person5 = Guid.NewGuid();
            var person6 = Guid.NewGuid();
            var person7 = Guid.NewGuid();

            var people = new List<Guid>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person7);

            modelBuilder.Entity<Person>().HasData(
                new Person { PersonId = person1, Code = 1, Name = "Nicoletta", Surnamme = "Morsia", SiteId = site1, YearsOfExperience = 2, Position = "dev", Remote = false, IsRecruiter = false },
                new Person { PersonId = person2, Code = 2, Name = "Mario", Surnamme = "Rossi", SiteId = site2, YearsOfExperience = 2, Position = "recuiter", Remote = true, IsRecruiter = true},
                new Person { PersonId = person3, Code = 3, Name = "Mario", Surnamme = "Rossi", SiteId = site1, YearsOfExperience = 2, Position = "recruiter", Remote = false, IsRecruiter = true },
                new Person { PersonId = person4, Code = 4, Name = "Mario", Surnamme = "Rossi", SiteId = site1, YearsOfExperience = 2, Position = "dev", Remote = true, IsRecruiter = false},
                new Person { PersonId = person5, Code = 5, Name = "Giovanni", Surnamme = "Bianchi", SiteId = site3, YearsOfExperience = 4, Position = "dev", Remote = true, IsRecruiter = false},
                new Person { PersonId = person6, Code = 6, Name = "Alessandra", Surnamme = "Verdi", SiteId = site2, YearsOfExperience = 15, Position = "dev", Remote = true, IsRecruiter = false},
                new Person { PersonId = person7, Code = 7, Name = "Giovanni", Surnamme = "Novembre", SiteId = site5, YearsOfExperience = 1, Position = "dev", Remote = true, IsRecruiter = false}
                );

            #endregion

            #region SkillLink

            modelBuilder.Entity<SkillLink>().HasData(
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person1, SkillId = skill1, Level = 1 },
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person1, SkillId = skill2, Level = 2 },
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person2, SkillId = skill3, Level = 3 },
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person3, SkillId = skill4, Level = 1 },
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person4, SkillId = skill5, Level = 6 },
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person4, SkillId = skill6, Level = 3 },
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person4, SkillId = skill3, Level = 2 },
                new SkillLink { SkillLinkId = Guid.NewGuid(), PersonId = person5, SkillId = skill7, Level = 2 }
                );

            List<Entity.SkillLink> skills = new List<Entity.SkillLink>();
            for (int i = 0; i < 1000; i++)
            {
                skills.Add(new Entity.SkillLink()
                {
                    SkillLinkId = Guid.NewGuid(),
                    SkillId = skillss[new Random().Next(skillss.Count)],
                    PersonId = people[new Random().Next(people.Count)],
                    Level = new Random().Next(0, 7)
                });
            };

            modelBuilder.Entity<Entity.SkillLink>().HasData(skills.ToArray());

            #endregion

            #region LanguageLink

            modelBuilder.Entity<LanguageLink>().HasData(
                new LanguageLink { LanguageLinkId = Guid.NewGuid(), LanguageId = language1, LanguageLevelId = level3, PersonId = person1, Preferred = true },
                new LanguageLink { LanguageLinkId = Guid.NewGuid(), LanguageId = language2, LanguageLevelId = level6, PersonId = person1, Preferred = false },
                new LanguageLink { LanguageLinkId = Guid.NewGuid(), LanguageId = language3, LanguageLevelId = level1, PersonId = person2, Preferred = true },
                new LanguageLink { LanguageLinkId = Guid.NewGuid(), LanguageId = language4, LanguageLevelId = level2, PersonId = person2, Preferred = false },
                new LanguageLink { LanguageLinkId = Guid.NewGuid(), LanguageId = language5, LanguageLevelId = level3, PersonId = person3, Preferred = true },
                new LanguageLink { LanguageLinkId = Guid.NewGuid(), LanguageId = language6, LanguageLevelId = level4, PersonId = person3, Preferred = false },
                new LanguageLink { LanguageLinkId = Guid.NewGuid(), LanguageId = language7, LanguageLevelId = level5, PersonId = person4, Preferred = true }
                );

            /////
            ///
            #endregion

            #region Research

            List<Entity.Research> researches = new List<Entity.Research>();
            for (int i = 0; i < 100; i++)
            {
                researches.Add(new Entity.Research()
                {
                    ResearchId = Guid.NewGuid(),
                    Code = i + 1,
                    Description = "Research " + i,
                    Remote = new Random().Next(0, 1) == 1,
                    SiteId = sites[new Random().Next(sites.Count)],
                    PersonId = people[new Random().Next(people.Count)],
                    LanguageId = languages[new Random().Next(languages.Count)]
                });
            };
            
            modelBuilder.Entity<Entity.Research>().HasData(researches.ToArray());
        
            #endregion

    }


        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
