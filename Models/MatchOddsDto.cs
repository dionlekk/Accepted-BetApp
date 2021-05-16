using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Models
{
    public class MatchOddsDto
    {
        
        public int MatchOddId { get; set; }
        public string Specifier { get; set; }
        public double Odd { get; set; }

        //public MatchDto match { get; set; }
        //public int MatchId { get; set; }
    }
}
