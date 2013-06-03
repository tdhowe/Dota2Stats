using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2WebAPISDK.ApiObjects.MatchDetails;

namespace Dota2Stats.GameStats
{
    public class PlayerGameStats : GameStats
    {
        private bool onRadiant;

    #region public properties

        /* put the properties in the order that they will appear in the table.
         * Table is automatically populated with all public properties from this class */

        public override long MatchID { get; protected set; }
        public override string GameType { get; protected set; }
        public override string GameLength { get; protected set; }


        public string GameResult 
        { 
            get
            { 
                return (!(this.onRadiant ^ matchDetails.RadiantWin) ? "Win" : "Loss"); 
            } 
        }

        public string Hero { get; private set; }
        public int Kills { get; private set; }
        public int Deaths { get; private set; }
        public int Assists { get; private set; }
        public int GPM { get; private set; }
        public int XPM { get; private set; }

        public int Rating
        {
            get
            {
                return getRating();
            }
        }

    #endregion

    #region constructors

        public PlayerGameStats(MatchDetails m, MatchDetailsPlayer p)
            : base(m, p)
        {
            this.matchDetails = m;
            this.matchDetailsPlayer = p;

            /* decode player slot */
            this.onRadiant = ((p.PlayerSlot & (0X80)) == 0);

            /* fetch the hero list and match the hero id */
            this.Hero = Utils.DotaUtils.HeroList.HeroesList.Where(hero => hero.ID == p.HeroID).First().LocalizedName;

            this.Kills = p.Kills;
            this.Deaths = p.Deaths;
            this.Assists = p.Assists;
            this.GPM = p.GoldPerMinute;
            this.XPM = p.XPPerMinute;
        }

    #endregion

        /* rating for this particular game.
         * Based on the following formula:
         * */
        private int getRating()
        {
            return 100;
        }
    }
}
