using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2WebAPISDK.ApiObjects.MatchDetails;

namespace Dota2Stats.GameStats
{
    public class TeamGameStats : GameStats
    {
        public override long MatchID { get; protected set; }
        public override string GameType { get; protected set; }
        public override string GameLength { get; protected set; }

        public TeamGameStats(MatchDetails m, MatchDetailsPlayer p)
            : base(m, p)
        {

        }
    }
}
