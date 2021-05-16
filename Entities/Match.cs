using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Entities
{
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MatchId { get; set; }
        [Required]
        [MaxLength(150)]
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

        
        public ICollection<Match> Matches { get; set; } = new List<Match>();

        public ICollection<MatchOdds> MatchOdds { get; set; } = new List<MatchOdds>();
    }
}
