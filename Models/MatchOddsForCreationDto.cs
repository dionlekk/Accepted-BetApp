using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Models
{
    public class MatchOddsForCreationDto
    {
        [Required(ErrorMessage = "You should enter a specifier for the match.")]
        [MaxLength(1)]
        public string Specifier { get; set; }
        public double Odd { get; set; }

    }
}
