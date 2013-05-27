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


namespace Dota2Stats
{
    public partial class MainWindow : Form
    {
        private WebAPISDKEngine apiEngine;
        public MainWindow()
        {
            apiEngine = new WebAPISDKEngine();
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
            long account_id;

            if (long.TryParse(player, out account_id) )
            {
                hist = apiEngine.GetMatchHistory(account_id);
            }
            else
            {
                hist = apiEngine.GetMatchHistory(player);
            }

            foreach( Dota2WebAPISDK.ApiObjects.MatchHistory.Match m in hist.Matches )
            {
                Dota2WebAPISDK.ApiObjects.MatchDetails.Match currentMatch = apiEngine.GetMatchDetails(m.MatchID);


                foreach (Dota2WebAPISDK.ApiObjects.MatchDetails.Player p in currentMatch.Players)
                {
                    Dota2WebAPISDK.ApiObjects.PlayerSummary.PlayerSummary ps = apiEngine.GetPlayerSummary(p.AccountID + 76561197960265728);

                    if (ps == null)
                        continue;
                    foreach(Dota2WebAPISDK.ApiObjects.PlayerSummary.Player currentPlayer in ps.Players)
                    {
                        Console.WriteLine(currentPlayer.Name);
                    }
                }

                ListViewItem lvi = new ListViewItem(m.MatchID.ToString(), 0);
                lvi.SubItems.Add(m.LobbyType.ToString());
                lvi.SubItems.Add((currentMatch.RadiantWin ? "Radiant Victory" : "Dire Victory"));

                
                

                this.list_results.Items.Add(lvi);
            }

            this.list_results.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
        }
    }
}
