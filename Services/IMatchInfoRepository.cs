using BetApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetApp.Services
{
    public interface IMatchInfoRepository
    {
        IEnumerable<Match> GetMatches();

        Match GetMatch(int matchId, bool includeMatchOdds);

        IEnumerable<MatchOdds> GetMatchOddsForMatch(int matchId);

        MatchOdds GetMatchOddsForMatch(int matchId, int matchOddsId);

        bool MatchExists(int matchId);

        void AddMatchOddsForMatch(int matchId, MatchOdds matchOdds);

        void UpdateMatchOddsForMatch(int matchId, MatchOdds matchOdds);

        void DeleteMatchOdd(MatchOdds matchOdds);

        bool Save();

        //add match
        void AddMatch(Match match);

    }
}
