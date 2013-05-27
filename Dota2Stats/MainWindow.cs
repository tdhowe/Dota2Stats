using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dota2WebAPISDK.ApiObjects.MatchDetails;
using Dota2WebAPISDK.ApiObjects.MatchHistory;
using Dota2WebAPISDK.Configuration;
using Dota2WebAPISDK.ApiObjects.Teams;
using Dota2WebAPISDK.Engines;
using Dota2WebAPISDK.ApiObjects.PlayerSummary;
using Dota2Stats.Utils;
using Dota2WebAPISDK.ApiObjects.VanityURL;


namespace Dota2Stats
{
    public partial class MainWindow : Form
    {
        private WebAPISDKEngine apiEngine;
        private SteamIDWindow steamIDWindow;

        public MainWindow()
        {
            apiEngine = new WebAPISDKEngine();
            steamIDWindow = new SteamIDWindow();

            InitializeComponent();

            configListView();

        }

        private void configListView()
        {
            this.list_results.Columns.Add("Match ID");
            this.list_results.Columns.Add("Game Type");
            this.list_results.Columns.Add("Result");
            this.list_results.Columns.Add("Kills");
            this.list_results.Columns.Add("Deaths");
            this.list_results.Columns.Add("Assists");
            this.list_results.Columns.Add("GPM");
            this.list_results.Columns.Add("XPM");
        }

        private void button_getStats_Click(object sender, EventArgs e)
        {
            list_results.Items.Clear();
            string player = text_playername.Text;

            MatchHistory hist;
            MatchDetailsPlayer requestedPlayer = null;
            long account_id = 0;

            if (long.TryParse(player, out account_id) )
            {
                hist = apiEngine.GetMatchHistory(account_id);
            }
            else
            {
                hist = apiEngine.GetMatchHistory(player);
            }

            foreach( Match m in hist.Matches )
            {
                MatchDetails currentMatch = apiEngine.GetMatchDetails(m.MatchID);

                long[] requestedplayers = new long[currentMatch.Players.Count];
                for (int i = 0; i < currentMatch.Players.Count; i++)
                {
                    requestedplayers[i] = SteamUtils.SteamID32To64(currentMatch.Players[i].AccountID);
                }

                PlayerSummary ps = apiEngine.GetPlayerSummaries(requestedplayers);

                if (ps == null)
                    continue;

                foreach (Player currentPlayer in ps.Players)
                {
                    /* find the requested player based on either accnt id or steam name */
                    if (((account_id != 0) && (currentPlayer.SteamID.Equals(account_id.ToString())))
                        || (player.Equals(currentPlayer.Name)))
                    {
                        /* we have found a match for the requested player in this game.  get stats about them */
                        //requestedPlayer = currentPlayer;
                    }
                }

                ListViewItem lvi = new ListViewItem(m.MatchID.ToString(), 0);
                lvi.SubItems.Add(m.LobbyType.ToString());
                lvi.SubItems.Add((currentMatch.RadiantWin ? "Radiant Victory" : "Dire Victory"));

                this.list_results.Items.Add(lvi);
            }

            this.list_results.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
        }

        private void button_FindAccount_Click(object sender, EventArgs e)
        {
            steamIDWindow.ShowDialog();
            if (steamIDWindow.AccountID.Length > 0)
            {
                text_playername.Text = parseSteamID(steamIDWindow.AccountID);
            }
        }

        private string parseSteamID(string id)
        {
            string steamid = "";

            if (id.Contains("id"))
            {
                /* this is a custom id url.  We are going to have to request the account id */
                VanityURLResult vur = apiEngine.ResolveVanityURL(id.Replace("id/", ""));
                steamid = vur.SteamID;
            }
            else
            {
                /* just strip out the "profiles/" part and we have the id */
                steamid = id.Replace("profiles/", "");
            }

            return steamid;
        }
    
        
    }

}
