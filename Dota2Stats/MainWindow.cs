using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

using Newtonsoft;

using Dota2WebAPISDK;
using Dota2WebAPISDK.ApiObjects.MatchDetails;
using Dota2WebAPISDK.ApiObjects.MatchHistory;
using Dota2WebAPISDK.Configuration;
using Dota2WebAPISDK.ApiObjects.Teams;
using Dota2WebAPISDK.Engines;
using Dota2WebAPISDK.ApiObjects.PlayerSummary;
using Dota2WebAPISDK.ApiObjects.VanityURL;

using Dota2Stats.Utils;
using Dota2WebAPISDK.ApiObjects.Heroes;

namespace Dota2Stats
{
    public partial class MainWindow : Form
    {
        private WebAPISDKEngine apiEngine;
        private SteamIDWindow steamIDWindow;

        public MainWindow()
        {
            /* load the embedded dll files */
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();

            InitializeWindowVariables();
        }

        private void InitializeWindowVariables()
        {
            apiEngine = new WebAPISDKEngine();
            steamIDWindow = new SteamIDWindow();
        }

        private void button_getStats_Click(object sender, EventArgs e)
        {
            this.statusBar.Text = "Retrieving games...";
            this.statusBar.Invalidate();
            this.Cursor = Cursors.WaitCursor;

            list_results.ClearObjects();


            //TODO: Move this shit into its own function

            MatchHistory hist;
            List<PlayerGameStats> playerGames = new List<PlayerGameStats>();
            long account_id;

            if (long.TryParse(text_playername.Text, out account_id))
            {
                hist = apiEngine.GetMatchHistory(account_id);

                this.statusBar.Text = "Parsing stats";
                this.statusBar.Invalidate();

                foreach (Match m in hist.Matches)
                {
                    MatchDetails currentMatch = apiEngine.GetMatchDetails(m.MatchID);

                    MatchDetailsPlayer p = currentMatch.Players.Where(player => Utils.SteamUtils.SteamID32To64(player.AccountID) == account_id).First();

                    if (p == null)
                    {
                        MessageBox.Show("Parse Error.  No accound IDs were found for player " + account_id + " in match " + m.MatchID,
                                        "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        playerGames.Add(new PlayerGameStats(currentMatch, p));
                        this.statusBar.Text += ".";
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Steam Account ID.  Use the button above to determine your 64-bit Steam Account ID",
                                "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.list_results.AddObjects(playerGames);

            this.statusBar.Text = "Ready";
            this.statusBar.Invalidate();
            this.Cursor = Cursors.Default;
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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
