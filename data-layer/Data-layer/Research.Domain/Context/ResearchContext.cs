using Microsoft.EntityFrameworkCore;
using Research.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.Context
{
    internal class ResearchContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<LanguageLevel> LanguageLevel { get; set; }
        public DbSet<LanguageLink> LanguageLink { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Entity.Research> Research { get; set; }
        public DbSet<Site> Site{ get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillLevel> SkillLevel { get; set; }
        public DbSet<SkillLink> SkillLink { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Research;Trusted_Connection=True;");
        }
    }
}
