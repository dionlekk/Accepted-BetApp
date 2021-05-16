using BetApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Context
{
    public class MatchInfoContext : DbContext
    {

        public DbSet<Match> Matches { get; set; }

        public DbSet<MatchOdds> MatchOdds { get; set; }

        public MatchInfoContext(DbContextOptions<MatchInfoContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Match>().HasData(
                new Match()
                {
                    MatchId = 1,
                    Description = "OSFP-PAO",
                    MatchDate = "19/03/2021",
                    MatchTime = "15:00",
                    TeamA = "OSFP",
                    TeamB = "PAO",
                    Sport = "1",
                },
                new Match()
                {
                    MatchId = 2,
                    Description = "AEK-PAOK",
                    MatchDate = "20/03/2021",
                    MatchTime = "17:00",
                    TeamA = "AEK",
                    TeamB = "PAOK",
                    Sport = "2",
                },
                new Match()
                {
                    MatchId = 3,
                    Description = "ARIS-PAOK",
                    MatchDate = "21/03/2021",
                    MatchTime = "21:00",
                    TeamA = "ARIS",
                    TeamB = "PAOK",
                    Sport = "1",
                });


            modelBuilder.Entity<MatchOdds>().HasData(
                new MatchOdds()
                {
                    MatchOddId = 1,
                    MatchId = 1,
                    Specifier = "X",
                    Odd = 2.00
                },
                new MatchOdds()
                {
                    MatchOddId = 2,
                    MatchId = 2,
                    Specifier = "1",
                    Odd = 2.00
                },
                new MatchOdds()
                {
                    MatchOddId = 3,
                    MatchId = 3,
                    Specifier = "X",
                    Odd = 2.00
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
