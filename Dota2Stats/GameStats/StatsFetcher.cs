using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dota2WebAPISDK.ApiObjects.MatchDetails;
using Dota2WebAPISDK.ApiObjects.MatchHistory;
using Dota2WebAPISDK.Engines;
using Dota2WebAPISDK.Enums;

namespace Dota2Stats.GameStats
{
    public class StatsFetcher
    {
        public event PlayerGameDiscoveredEventHandler PlayerGameDiscoveredEvent;
        public delegate void PlayerGameDiscoveredEventHandler(object sender, PlayerGameStats pgs);

        public event StatsCompleteEventHandler StatsCompleteEvent;
        public delegate void StatsCompleteEventHandler(object sender);

        public StatsFetcher() { }

        public void Fetch(WebAPISDKEngine engine, long account_id, List<LobbyType> types, int num_matches)
        {
            MatchHistory hist;
            int total_matches = 0;
            long last_match_id = 0;
            /* this value is used as a "timeout" if no more matches can be found */
            int num_tries = (num_matches)*4; 

            while ((total_matches < num_matches) && (num_tries > 0))
            {
                hist = engine.GetMatchHistory(account_id, last_match_id, (ushort)(total_matches - num_matches), 0);

                if (hist != null)
                {
                    foreach (Match m in hist.Matches)
                    {
                        MatchDetails currentMatch = engine.GetMatchDetails(m.MatchID);

                        MatchDetailsPlayer p = currentMatch.Players.Where(player => player.AccountID == account_id).FirstOrDefault();

                        if ((p != null) && (types.Contains(currentMatch.LobbyType)))
                        {
                            PlayerGameDiscoveredEvent(this, new PlayerGameStats(currentMatch, p));
                            total_matches++;
                            /* we found a match, there might be more.  Give us some more tries! */
                            num_tries = num_tries + 5;
                        }
                        else
                        {
                            /* match was not found.  Decrement number of tries */
                            num_tries--;
                        }
                    }
                    last_match_id = hist.Matches.OrderByDescending(match => match.MatchID).LastOrDefault().MatchID - 1;
                }

                if (last_match_id == 0)
                    break;
            }
          

            StatsCompleteEvent(this);
        }
    }
}
