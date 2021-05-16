using AutoMapper;
using BetApp.Models;
using BetApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Controllers
{
    [ApiController]
    [Route("api/{matches}/{matchId}/matchodds")]
    public class MatchOddsController : ControllerBase
    {
        private readonly ILogger<MatchOddsController> _logger;
        private readonly IMatchInfoRepository _matchInfoRepository;
        private readonly IMapper _mapper;

        public MatchOddsController(ILogger<MatchOddsController> logger, IMatchInfoRepository matchInfoRepository, IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentException(nameof(logger));
            _matchInfoRepository = matchInfoRepository ?? throw new ArgumentException(nameof(matchInfoRepository));
            _mapper = mapper ?? throw new ArgumentException(nameof(mapper));
        }





        [HttpGet]
        public IActionResult GetMatchOdds(int matchId)
        {
            try
            {             

                if (!_matchInfoRepository.MatchExists(matchId))
                {
                    _logger.LogInformation($"Match with {matchId} wasn't found");
                    return NotFound();
                }

                var matchOddsForMatch = _matchInfoRepository.GetMatchOddsForMatch(matchId);

                return Ok(_mapper.Map<IEnumerable<MatchOddsDto>>(matchOddsForMatch));

            }
            catch (Exception ex) 
            {
                _logger.LogCritical("Exception happened!",ex);
                return StatusCode(500, "A problem happened while handling your request.");
            }
        }





        [HttpGet("{id}", Name = "GetMatchOdds")]
        public IActionResult GetMatchOdds(int matchId, int id)
        {

            if (!_matchInfoRepository.MatchExists(matchId))
            {
                return NotFound();
            }

            var matchOdd = _matchInfoRepository.GetMatchOddsForMatch(matchId,id);

            if (matchOdd == null) 
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MatchOddsDto>(matchOdd));

        }





        [HttpPost]
        public IActionResult CreateMatchOdds(int matchId, [FromBody] MatchOddsForCreationDto matchOdds)
        {

            if (!_matchInfoRepository.MatchExists(matchId))
            {
                return NotFound();
            }
           

            var finalMatchOdd = _mapper.Map<Entities.MatchOdds>(matchOdds);


            _matchInfoRepository.AddMatchOddsForMatch(matchId, finalMatchOdd);
            _matchInfoRepository.Save();

            var createdMatchOddsToReturn = _mapper.Map < Models.MatchOddsDto>(finalMatchOdd);

            return CreatedAtRoute(
                "GetMatchOdds",
                new { matchId, id = createdMatchOddsToReturn.MatchOddId },
                createdMatchOddsToReturn);
        }



        [HttpPut("{id}")]
        public IActionResult UpdateMatchOdd(int matchId, int id, [FromBody] MatchOddsUpdateDto matchOdds) 
        {
      

            if (!_matchInfoRepository.MatchExists(matchId))
            {
                return NotFound();
            }


            var matchOddsEntity = _matchInfoRepository.GetMatchOddsForMatch(matchId, id);
            if (matchOddsEntity == null) 
            {
                return NotFound();
            }
          

            _mapper.Map(matchOdds,matchOddsEntity);
            _matchInfoRepository.UpdateMatchOddsForMatch(matchId,matchOddsEntity);
            _matchInfoRepository.Save();
           
            return NoContent();

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteMatchOdds(int matchId, int id) 
        {           

            if (!_matchInfoRepository.MatchExists(matchId))
            {
                return NotFound();
            }

            var matchOddsEntity = _matchInfoRepository.GetMatchOddsForMatch(matchId, id);
            if (matchOddsEntity == null)
            {
                return NotFound();
            }


            _matchInfoRepository.DeleteMatchOdd(matchOddsEntity);
            _matchInfoRepository.Save();

            //match.MatchOdds.Remove(matchOddsFromStore);

            return NoContent();

        }
       
    }
}
