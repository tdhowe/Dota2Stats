using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
}
