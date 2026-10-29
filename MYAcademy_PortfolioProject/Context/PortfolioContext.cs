using Microsoft.EntityFrameworkCore;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Context
{
    public class PortfolioContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server=GTC\\SQLEXPRESS;database=PortfolioDb;integrated security=true; trust server certificate=true");
        }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<HeroTitle> HeroTitles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillItem> SkillItems  { get; set; }
    }
}