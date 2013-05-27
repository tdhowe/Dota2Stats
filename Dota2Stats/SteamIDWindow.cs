using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Dota2Stats
{
    public partial class SteamIDWindow : Form
    {
        public string AccountID { get; private set; }

        private string profileURL = "http://steamcommunity.com/actions/Search?K={0}";
        private string imageSearchString = "avatarMedium";
        private string currentNameSearchString = "linkTitle";

        public SteamIDWindow()
        {
            InitializeComponent();
        }

        #region event handlers

        private void button_Find_Click(object sender, EventArgs e)
        {
            statusBar.Text = "Searching...";
            statusBar.Invalidate(); // force redraw
            this.Cursor = Cursors.WaitCursor;

            listView_Results.Clear();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format(profileURL, text_Input.Text));
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();

                /* get the lines with the image files and nicknames from the http result */
                List<String> imageLines = new List<string> ( responseString.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                                                               .Where(line => line.Contains(imageSearchString))
                                                             );
                List<String> nameLines = new List<string> ( responseString.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                                                .Where(line => line.Contains(currentNameSearchString))
                                                );

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(64, 64);
                imageList.ColorDepth = ColorDepth.Depth32Bit;

                if (imageLines.Count != nameLines.Count)
                {
                    MessageBox.Show("Image count differs from Name count", "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < imageLines.Count; i++)
                {
                    string imageLine = imageLines[i];

                    /* populate the listview with the lines */
                    Match accountidMatch = Regex.Match(imageLine, "http://steamcommunity.com/(\\S+)\"");
                    Match imageMatch = Regex.Match(imageLine, "img src=\"(\\S+)\"");

                    imageList.Images.Add(accountidMatch.Groups[1].Value, DownloadImage(imageMatch.Groups[1].Value));
                }

                listView_Results.LargeImageList = imageList;

                for (int i = 0; i < imageList.Images.Count; i++ )
                {
                    ListViewItem lvi = new ListViewItem();
                    string account = imageList.Images.Keys[i];
                    string displayname = Regex.Match(nameLines[i], "\">(\\S+)<").Groups[1].Value;

                    lvi.ImageKey = account;
                    lvi.Text = displayname;

                    listView_Results.Items.Add(lvi);
                }

                if (listView_Results.Items.Count == 0)
                {
                    MessageBox.Show("No Results Found", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                this.Cursor = Cursors.Default;
                statusBar.Text = "Ready";
            }
        }

        private void SteamIDWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button_Find_Click(sender, new EventArgs());
            }
        }

        private void listView_Results_KeyPress(object sender, KeyPressEventArgs e)
        {
            listView_Results_MouseDoubleClick(sender, null);
        }

        private void listView_Results_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = sender as ListView;
            this.AccountID = lv.SelectedItems[0].ImageKey;
            this.Close();
        }

        #endregion

        #region utils

        private Image DownloadImage(string url)
        {
            WebRequest req = WebRequest.Create(url.Replace("medium", "full"));
            WebResponse response = req.GetResponse();

            Stream stream = response.GetResponseStream();

            //Download in chuncks
            byte[] buffer = new byte[1024];

            //Get Total Size
            int dataLength = (int)response.ContentLength;

            Application.DoEvents();

            //Download to memory
            //Note: adjust the streams here to download directly to the hard drive
            MemoryStream memStream = new MemoryStream();
            while (true)
            {
                //Try to read the data
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    Application.DoEvents();
                    break;
                }
                else
                {
                    //Write the downloaded data
                    memStream.Write(buffer, 0, bytesRead);
                }
            }

            return Image.FromStream(memStream);
        }

        #endregion



    }
}
