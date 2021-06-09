using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.DataAcces
{
    public class FootballDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Football.db");
        }
    }
}