using BetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp
{
    public class MatchDataStore
    {
        public static MatchDataStore Current { get; } = new MatchDataStore();

        public List<MatchDto> Matches { get; set; }

        public MatchDataStore()
        {
            Matches = new List<MatchDto>()
            {
              new MatchDto()
              { MatchId =1,
                Description = "",
                MatchDate = "",
                MatchTime = "",
                TeamA = "",
                TeamB = "",
                Sport = "",
                MatchOdds = new List<MatchOddsDto>()
                { 
                  new MatchOddsDto(){
                    MatchOddId = 1,
                    Specifier = "X",
                    Odd = 2.00
                  }
                }
              },
              new MatchDto()
              { MatchId =2,
                Description = "",
                MatchDate = "",
                MatchTime = "",
                TeamA = "",
                TeamB = "",
                Sport = "",
                MatchOdds = new List<MatchOddsDto>()
                {
                  new MatchOddsDto(){
                    MatchOddId = 1,
                    Specifier = "1",
                    Odd = 1.40
                  }
                }
              },
              new MatchDto()
              { MatchId =3,
                Description = "",
                MatchDate = "",
                MatchTime = "",
                TeamA = "",
                TeamB = "",
                Sport = "",
                MatchOdds = new List<MatchOddsDto>()
                {
                  new MatchOddsDto(){
                    MatchOddId = 1,
                    Specifier = "2",
                    Odd = 3.40
                  }
                }
              }
            };
        }
    }
}
