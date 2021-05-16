using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Entities
{
    public class MatchOdds
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MatchOddId { get; set; }
        [Required]
        [MaxLength(1)]
        public string Specifier { get; set; }
        public double Odd { get; set; }

        [ForeignKey("MatchId")]
        public Match Match { get; set; }
        public int MatchId { get; set; }

    }
}
