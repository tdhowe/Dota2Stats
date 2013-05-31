using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dota2WebAPISDK.ApiObjects.MatchDetails;
using Dota2WebAPISDK.ApiObjects.MatchHistory;
using Dota2WebAPISDK.Engines;
using Dota2WebAPISDK.Enums;

namespace Dota2Stats.Classes
{
    public class StatsFetcher
    {
        public event PlayerGameDiscoveredEventHandler PlayerGameDiscoveredEvent;
        public delegate void PlayerGameDiscoveredEventHandler(object sender, PlayerGameStats pgs);

        public event StatsCompleteEventHandler StatsCompleteEvent;
        public delegate void StatsCompleteEventHandler(object sender);

        public StatsFetcher() { }

        public void Fetch(WebAPISDKEngine engine, long account_id, List<GameMode> modes, int num_matches)
        {
            MatchHistory hist;
            int total_matches = 0;
            long last_match_id = 0;

            foreach (GameMode mode in modes)
            {
                while (total_matches < num_matches)
                {
                    hist = engine.GetMatchHistory(account_id, 0, GameMode.AllPick);

                    if (hist != null)
                    {
                        foreach (Match m in hist.Matches)
                        {
                            MatchDetails currentMatch = engine.GetMatchDetails(m.MatchID);

                            MatchDetailsPlayer p = currentMatch.Players.Where(player => Utils.SteamUtils.SteamID32To64(player.AccountID) == account_id).First();

                            if (p != null)
                            {
                                PlayerGameDiscoveredEvent(this, new PlayerGameStats(currentMatch, p));
                            }
                        }
                        last_match_id = hist.Matches.OrderByDescending(match => match.MatchID).FirstOrDefault().MatchID;
                        total_matches += hist.NumberOfResults;
                    }

                    if (last_match_id == 0)
                        break;
                }
            }

            StatsCompleteEvent(this);
        }
    }
}
