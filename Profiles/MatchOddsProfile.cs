using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Profiles
{
    public class MatchOddsProfile : Profile
    {

        public MatchOddsProfile()
        {
            CreateMap<Entities.MatchOdds, Models.MatchOddsDto>();
            CreateMap<Models.MatchOddsForCreationDto, Entities.MatchOdds>();
            CreateMap<Models.MatchOddsUpdateDto, Entities.MatchOdds>();
        }
    }
}
