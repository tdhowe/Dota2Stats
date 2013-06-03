using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2WebAPISDK.ApiObjects.MatchDetails;

namespace Dota2Stats.GameStats
{
    public abstract class GameStats
    {
        protected MatchDetails matchDetails;
        protected MatchDetailsPlayer matchDetailsPlayer;

        #region public properties

        public abstract long MatchID { get; protected set; }
        public abstract string GameType { get; protected set; }
        public abstract string GameLength { get; protected set; }

        #endregion

        #region constructors

        public GameStats(MatchDetails m, MatchDetailsPlayer p)
        {
            this.matchDetails = m;
            this.matchDetailsPlayer = p;

            this.MatchID = m.MatchID;
            this.GameType = m.GameMode.ToString();
            this.GameLength = String.Format("{0:d2}:{1:d2}", (m.Duration / 60), (m.Duration % 60));
        }

        #endregion
    }
}
