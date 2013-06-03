using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2WebAPISDK.ApiObjects.Heroes;
using Dota2WebAPISDK.Engines;

namespace Dota2Stats.Utils
{
    public static class SteamUtils
    {


        private static long STEAM_ID_OFFSET = 76561197960265728;
        public static long SteamID32To64(long steamid)
        {
            return steamid + STEAM_ID_OFFSET;
        }

        public static long SteamID64To32(long steamid)
        {
            return steamid - STEAM_ID_OFFSET;
        }
    }

    public static class DotaUtils
    {
        private static Heroes _heroList;

        public static Heroes HeroList
        {
            get
            {
                /* get the hero list if haven't already */
                if (_heroList == null)
                {
                    _heroList = (new WebAPISDKEngine()).GetHeroes(Dota2WebAPISDK.Enums.Language.English);
                }

                return _heroList;
            }
        }
    }
}
