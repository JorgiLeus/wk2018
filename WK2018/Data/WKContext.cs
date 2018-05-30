using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WK2018.Models;

namespace WK2018.Data
{
    public class WKContext: DbContext
    {
        public WKContext(DbContextOptions<WKContext> options) : base(options) { }

        public DbSet<Toernooi> Toernooien { get; set; }
        public DbSet<Poule> Poules { get; set; }
        public DbSet<Knockout> KnockoutStages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Speler> Spelers { get; set; }
        public DbSet<Wedstrijd> Wedstrijden { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Toernooi>().ToTable("Toernooien");
            modelBuilder.Entity<Poule>().ToTable("Poules");
            modelBuilder.Entity<Knockout>().ToTable("KnockoutStages");
            modelBuilder.Entity<Team>().ToTable("Teams");
            modelBuilder.Entity<Speler>().ToTable("Spelers");
            modelBuilder.Entity<Wedstrijd>().ToTable("Wedstrijden");
            modelBuilder.Entity<Score>().HasKey(s => new { s.Thuis, s.Uit });
            modelBuilder.Entity<Score>().ToTable("Scores");
        }
    }
}
