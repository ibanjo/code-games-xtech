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

        public string _connectionString = @"Server=20201067-AIT\MEMA;Database=App;Trusted_Connection=True;";

        private T GetRandomItem<T>(List<T> input, Random rng)
        {
            int randIndex = rng.Next(input.Count);
            return input[randIndex];
        }
        
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

            var levels = new List<Guid>();
            levels.Add(level1);
            levels.Add(level2);
            levels.Add(level3);
            levels.Add(level4);
            levels.Add(level5);
            levels.Add(level6);

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

            var seedArray = new Guid[1000];
            List<Guid> skillGuids = seedArray.Select(x => Guid.NewGuid()).ToList();
            var skillAreas = new List<string> {"Frontend", "Backend", "DevOps"};
            var skillEnvs = new List<string> {"Web", "Mobile"};
            var skillTree = new Dictionary<string, List<string>>
            {
                {"Frontend", new List<string>{"Angular", "Vue", "React", "Svelte"}},
                {"Backend", new List<string>{".NET", "Spring", "Laravel", "Django", "ExpressJS"}},
                {"DevOps", new List<string>{"Terraform", "Docker", "Kubernetes", "GitLab"}}
            };

            var rng = new Random();
            var skillArray = new List<Skill>();
            foreach (Guid skillGuid in skillGuids)
            {
                string? skillArea = GetRandomItem(skillAreas, rng);
                List<string> availableSkills = skillTree[skillArea];
                string skill = GetRandomItem(availableSkills, rng);
                string skillEnv = GetRandomItem(skillEnvs, rng);
                var theSkill = new Skill
                {
                    Code = rng.Next(1000),
                    SkillId = skillGuid,
                    FEBEDevops = skillArea,
                    WebMobile = skillEnv,
                    Technology = skill,
                    Description = $"{skillArea} - {skillEnv} - {skill}",
                    ProjectRef = ""
                };
                skillArray.Add(theSkill);
            }

            modelBuilder.Entity<Skill>().HasData(skillArray.ToArray());

            #endregion

            #region Person

            var seedPeople = new Guid[300];
            List<Guid> peopleGuids = seedPeople.Select(x => Guid.NewGuid()).ToList();
            var peopleName = new List<string> { "Nicoletta", "Mario", "Maurizio", "Giuseppe", "Giovanni", "Alessandro", "Alessandra", "Maria", "Giorgia", "Sara", "Monica", "Giuseppina", "Caterina" };
            var peopleSurname = new List<string> { "Morsia", "Ziliani", "Novembre", "Bianchi", "Rossi,", "Verdi", "Nero", "Cannone", "Deca", "Bianco", "Gialli", "Balsamo" };
            var positions = new List<string> { "Senior Developer", "Junior Developer", "Senior Architect", "Junior Architect", "Senior Manager", "Junior Manager", "Senior Consultant", "Junior Consultant", "Senior Tester", "Junior Tester", "Senior Designer", "Junior Designer" };
            
            var rng1 = new Random();
            var peopleArray = new List<Person>();
            foreach (Guid peopleGuid in peopleGuids)
            {
                string name = GetRandomItem(peopleName, rng1);
                string surname = GetRandomItem(peopleSurname, rng1);
                var thePerson = new Person
                {
                    PersonId = peopleGuid,
                    Name = name,
                    Surnamme = surname,
                    SiteId = GetRandomItem(sites, rng1),
                    YearsOfExperience = rng1.Next(1, 10),
                    Position = GetRandomItem(positions, rng1),
                    Remote = rng1.Next(0, 1) == 1,
                    IsRecruiter = rng1.Next(0, 1) == 1,
                };
                
                peopleArray.Add(thePerson);
            }

            modelBuilder.Entity<Person>().HasData(peopleArray.ToArray());
            #endregion

            #region SkillLink


            List<Entity.SkillLink> skills = new List<Entity.SkillLink>();
            for (int i = 0; i < 1000; i++)
            {
                skills.Add(new Entity.SkillLink()
                {
                    SkillLinkId = Guid.NewGuid(),
                    SkillId = skillArray[new Random().Next(skillArray.Count)].SkillId,
                    PersonId = peopleArray[new Random().Next(peopleArray.Count)].PersonId,
                    Level = new Random().Next(0, 7)
                });
            };

            modelBuilder.Entity<Entity.SkillLink>().HasData(skills.ToArray());

            #endregion

            #region LanguageLink

            List<LanguageLink> languagess = new List<LanguageLink>();
            for (int i = 0; i < 400; i++)
            {
                languagess.Add(new LanguageLink()
                {
                    LanguageLinkId = Guid.NewGuid(),
                    LanguageId = languages[new Random().Next(languages.Count)],
                    PersonId = peopleArray[new Random().Next(peopleArray.Count)].PersonId,
                    LanguageLevelId = levels[new Random().Next(levels.Count)],
                    Preferred = new Random().Next(0, 1) == 1
                });
            };

            modelBuilder.Entity<LanguageLink>().HasData(languagess.ToArray());

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
                    PersonId = peopleArray[new Random().Next(peopleArray.Count)].PersonId,
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
