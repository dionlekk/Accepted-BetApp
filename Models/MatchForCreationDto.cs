using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Models
{
    public class MatchForCreationDto
    {

        
        public int MatchId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        public string MatchDate { get; set; }

        public string MatchTime { get; set; }

        public string TeamA { get; set; }

        public string TeamB { get; set; }

        public string Sport { get; set; }       
    }
}
