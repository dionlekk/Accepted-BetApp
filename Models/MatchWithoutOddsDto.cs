using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Models
{
    public class MatchWithoutOddsDto
    {

        public int MatchId { get; set; }

        public string Description { get; set; }

        public string MatchDate { get; set; }

        public string MatchTime { get; set; }

        public string TeamA { get; set; }

        public string TeamB { get; set; }

        public string Sport { get; set; }
    }
}
