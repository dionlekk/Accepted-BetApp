using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Models
{
    public class MatchDto
    {
        public int MatchId { get; set; }

        public string Description { get; set; }

        public string MatchDate { get; set; }

        public string MatchTime { get; set; }

        public string TeamA { get; set; }

        public string TeamB { get; set; }

        //public enum Sport
        //{
        //    Football = 1,
        //    Basketball = 2
        //}

        public string Sport { get; set; }

        public int NumberOfMatchOdds 
        {
            get 
            {
                return MatchOdds.Count;
            }
        }

        public ICollection<MatchOddsDto> MatchOdds { get; set; } = new List<MatchOddsDto>();
    }
}
