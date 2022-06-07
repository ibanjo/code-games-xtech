using Microsoft.EntityFrameworkCore;
using Research.Domain.Entity;
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

        public string _connectionString = @"Server=20201067-AIT\MEMA;Database=App;Trusted_Connection=True;";

        public ResearchContext(DbContextOptions options) : base(options)
        {
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
    public static class MigrationUtility
    {
        public enum MigrationType
        {
            Up,
            Down
        }

        public static string ReadSql(Type migrationType, MigrationType migrationTypeEnum)
        {
            var assembly = migrationType.Assembly;
            string resourceName = $"{migrationType.Namespace}.scripts.{migrationType.Name}.{migrationTypeEnum.ToString()}.sql";
            using (System.IO.Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new FileNotFoundException("Unable to find the SQL file from an embedded resource", resourceName);
                }
                using (var reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();
                    return content;
                }
            }
        }
    }
}
