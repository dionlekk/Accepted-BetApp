using BetApp.Context;
using BetApp.Entities;
using BetApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Services
{
    public class MatchInfoRepository : IMatchInfoRepository
    {
        private readonly MatchInfoContext _context;

        public MatchInfoRepository(MatchInfoContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }


        public IEnumerable<Match> GetMatches()
        {
            return _context.Matches.OrderBy(c => c.MatchId).ToList();
        }


        public Match GetMatch(int matchId, bool includeMatchOdds)
        {
            if (includeMatchOdds)
            {
                return _context.Matches.Include(c => c.MatchOdds).Where(c => c.MatchId == matchId).FirstOrDefault();
            }

            return _context.Matches.Where(c => c.MatchId == matchId).FirstOrDefault();
        }
       

        public MatchOdds GetMatchOddsForMatch(int matchId, int matchOddsId)
        {
            return _context.MatchOdds.Include(p => p.MatchId == matchId && p.MatchOddId == matchOddsId).FirstOrDefault();
        }


        public IEnumerable<MatchOdds> GetMatchOddsForMatch(int matchId)
        {
            return _context.MatchOdds.Where(p => p.MatchId == matchId).ToList();
        }


        public bool MatchExists(int matchId)
        {
            return _context.Matches.Any(c => c.MatchId == matchId);
        }


        public void AddMatchOddsForMatch(int matchId, MatchOdds matchOdds)
        {
            var match = GetMatch(matchId, false);
            match.MatchOdds.Add(matchOdds);

        }

        public void UpdateMatchOddsForMatch(int matchId, MatchOdds matchOdds)
        { 
           
        }

        public void DeleteMatchOdd(MatchOdds matchOdds)
        {
            _context.MatchOdds.Remove(matchOdds);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        //add new match
        public void AddMatch(Match match)
        {
            match.Matches.Add(match);

        }

    }
}
