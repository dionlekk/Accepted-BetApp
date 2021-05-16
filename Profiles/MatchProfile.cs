using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Profiles
{
    public class MatchProfile : Profile
    {

        public MatchProfile()
        {
            CreateMap<Entities.Match, Models.MatchWithoutOddsDto>();
            CreateMap<Entities.Match, Models.MatchOddsDto>();
            CreateMap<Models.MatchForCreationDto, Entities.Match>();
        }
    }
}
