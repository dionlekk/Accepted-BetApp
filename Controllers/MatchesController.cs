using AutoMapper;
using BetApp.Context;
using BetApp.Entities;
using BetApp.Models;
using BetApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Controllers
{
    [ApiController]
    [Route("api/matches")]
    public class MatchesController : ControllerBase
    {
        private readonly IMatchInfoRepository _matchInfoRepository;

        public readonly IMapper _mapper;

        public MatchesController(IMatchInfoRepository matchInfoRepository,IMapper mapper )
        {
            _matchInfoRepository = matchInfoRepository ?? throw new ArgumentException(nameof(matchInfoRepository));
            _mapper = mapper ?? throw new ArgumentException(nameof(mapper));
        }




        [HttpGet]
        public IActionResult GetMatches()
        {

            var matchEntities = _matchInfoRepository.GetMatches();          

            return Ok(_mapper.Map<IEnumerable<MatchWithoutOddsDto>>(matchEntities));
        }




        [HttpGet("{id}")]
        public IActionResult GetMatches(int id, bool includeMatchOdds = false)
        {           

            var match = _matchInfoRepository.GetMatch(id, includeMatchOdds);

            if (match == null) 
            {
                return NotFound();
            }

            if (includeMatchOdds) 
            {
                return Ok(_mapper.Map<MatchDto>(match));
            }

            return Ok(_mapper.Map<MatchWithoutOddsDto>(match));
        }


        [HttpPost]
        public IActionResult CreateMatch([FromBody] MatchForCreationDto match)
        {
            var finalMatchOdd = _mapper.Map<Entities.Match>(match);
            _matchInfoRepository.AddMatch(finalMatchOdd);
            _matchInfoRepository.Save();

            var createdMatchToReturn = _mapper.Map<Models.MatchDto>(finalMatchOdd);

            return CreatedAtRoute(
            "GetMatch",
            new { id = createdMatchToReturn.MatchId },
            createdMatchToReturn);
        }

    }
}
