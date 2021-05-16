using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BetApp.Models
{
    public class MatchOddsUpdateDto
    {

        [Required(ErrorMessage = "You should enter a specifier for the match.")]
        [MaxLength(1)]
        public string Specifier { get; set; }
        public double Odd { get; set; }
    }
}
