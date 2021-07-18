using BroadageSportWeb.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadageSportsWeb.Data
{
    public class BroadageSportsContext:DbContext
    {
        public BroadageSportsContext(DbContextOptions<BroadageSportsContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Match> Matches { get; set; }
        public DbSet<AwayTeam> AwayTeams { get; set; }
        public DbSet<HomeTeam> HomeTeams { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
