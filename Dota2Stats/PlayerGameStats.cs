using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2WebAPISDK.ApiObjects.MatchDetails;

namespace Dota2Stats.Classes
{
    public class PlayerGameStats
    {

    #region public properties

        public long MatchID {get; set;}
        public string GameType {get; set;}

        public bool Victory {get; set;}

        public string GameResult 
        { 
            get 
            { 
                return (this.Victory ? "Win" : "Loss"); 
            } 
        }

        public string Hero {get; set;}
        public int Kills {get; set;}
        public int Deaths {get; set;}
        public int Assists {get; set;}
        public int GPM {get; set;}
        public int XPM {get; set;}

    #endregion

    #region constructors

        public PlayerGameStats(MatchDetails m, MatchDetailsPlayer p)
        {
            this.MatchID = m.MatchID;
            this.GameType = m.GameMode.ToString();

            /* Victory if player is on radiant and radiant won or dire and radiant lost */
            this.Victory = !(((p.PlayerSlot & (0X80)) == 0) ^ m.RadiantWin);

            /* fetch the hero list and match the hero id */
            this.Hero = Utils.SteamUtils.HeroList.HeroesList.Where(hero => hero.ID == p.HeroID).First().LocalizedName;

            this.Kills = p.Kills;
            this.Deaths = p.Deaths;
            this.Assists = p.Assists;
            this.GPM = p.GoldPerMinute;
            this.XPM = p.XPPerMinute;
        }

    #endregion

    }
}
