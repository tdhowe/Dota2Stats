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
using BrightIdeasSoftware;

using Dota2WebAPISDK;
using Dota2WebAPISDK.ApiObjects.MatchDetails;
using Dota2WebAPISDK.ApiObjects.MatchHistory;
using Dota2WebAPISDK.Configuration;
using Dota2WebAPISDK.ApiObjects.Teams;
using Dota2WebAPISDK.Engines;
using Dota2WebAPISDK.ApiObjects.PlayerSummary;
using Dota2WebAPISDK.ApiObjects.VanityURL;
using Dota2WebAPISDK.ApiObjects.Heroes;

using Dota2Stats.Utils;
using Dota2Stats.Classes;
using Dota2WebAPISDK.Enums;


namespace Dota2Stats
{
    public partial class MainWindow : Form
    {
        private WebAPISDKEngine apiEngine;
        private SteamIDWindow steamIDWindow;
        private StatsFetcher statsFetcher;

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

            /* initialize the first item in each combobox*/
            foreach (var c in groupBox_Query.Controls)
            {
                if (c.GetType() == typeof(ComboBox))
                {
                    (c as ComboBox).SelectedIndex = 0;
                }
            }

            InitializeWindowVariables();
        }

        private void InitializeWindowVariables()
        {
            apiEngine = new WebAPISDKEngine();
            steamIDWindow = new SteamIDWindow();
            statsFetcher = new StatsFetcher();

            /* subscribe to statsFetcher events */
            statsFetcher.PlayerGameDiscoveredEvent += statsFetcher_PlayerGameDiscoveredEvent;
            statsFetcher.StatsCompleteEvent += statsFetcher_StatsCompleteEvent;
        }

        void statsFetcher_StatsCompleteEvent(object sender)
        {
            this.PeformOnUI(delegate()
            {
                this.statusBar.Text = "Ready";
                this.statusBar.Invalidate();
                this.Cursor = Cursors.Default;

                if(this.list_results.GetItemCount() == 0)
                {
                    MessageBox.Show("Parse Error.  No accound IDs were found for player " + this.text_playername.Text,
                                "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            });
        }

        private void statsFetcher_PlayerGameDiscoveredEvent(object sender, PlayerGameStats pgs)
        {
            this.list_results.AddObject(pgs);
            this.PeformOnUI(delegate()
            {
                this.statusBar.Text += ".";
            });
        }

        private void button_getStats_Click(object sender, EventArgs e)
        {
            list_results.ClearObjects();

            if (!backgroundWorker.IsBusy)
            {
                List<object> args = new List<object>();

                args.Add(int.Parse(comboBox_QueryAmount.Text));

                foreach( int i in checkedListBox_GameModes.CheckedIndices )
                {
                    args.Add((GameMode)i);
                }

                //TODO: Pass Values to background worker
                backgroundWorker.RunWorkerAsync(args);
            }
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

        /// <summary>
        ///  background thread cannot directly update the UI.  So call this function to do so
        /// </summary>
        /// <param name="m">delegate function to perform on UI</param>
        private void PeformOnUI(MethodInvoker m)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(m);
            }
            else
            {
                m();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            long account_id;
            int amount;
            List<GameMode> modes = new List<GameMode>();

            List<object> args = e.Argument as List<object>;

            amount = (int)args.ElementAt(0);
            for (int i = 1; i < args.Count; i++)
            {
                modes.Add((GameMode)args.ElementAt(i));
            }

            if (long.TryParse(text_playername.Text, out account_id))
            {
                PeformOnUI(delegate()
                {
                    this.statusBar.Text = "Retrieving stats";
                    this.statusBar.Invalidate();
                });

                statsFetcher.Fetch(apiEngine, account_id, modes, amount);
            }
            else
            {
                PeformOnUI(delegate()
                {
                    MessageBox.Show("Invalid Steam Account ID.  Use the button above to determine your 64-bit Steam Account ID",
                            "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                });
            }

        }

        private void checkBox_Normal_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;

            if (box.Equals(checkBox_Normal))
            {
                checkBox_Bot.Checked = !box.Checked;
            }
            else
            {
                checkBox_Normal.Checked = !box.Checked;
            }
        }

        private void checkedListBox_GameModes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    /* uncheck all the other checkboxes */
                    foreach (GameMode gm in Enum.GetValues(typeof(GameMode)))
                    {
                        checkedListBox_GameModes.SetItemChecked((int)gm, false);
                    }
                }
            }
            else
            {
                checkedListBox_GameModes.SetItemChecked(0, false);
            }
        }
    }

}
