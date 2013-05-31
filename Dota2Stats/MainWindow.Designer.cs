namespace Dota2Stats
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_getStats = new System.Windows.Forms.Button();
            this.text_playername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Query = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox_GameModes = new System.Windows.Forms.CheckedListBox();
            this.button_FindAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_QueryAmount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.list_results = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn0 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.checkBox_Normal = new System.Windows.Forms.CheckBox();
            this.checkBox_Bot = new System.Windows.Forms.CheckBox();
            this.groupBox_Query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_results)).BeginInit();
            this.SuspendLayout();
            // 
            // button_getStats
            // 
            this.button_getStats.Location = new System.Drawing.Point(661, 73);
            this.button_getStats.Name = "button_getStats";
            this.button_getStats.Size = new System.Drawing.Size(75, 43);
            this.button_getStats.TabIndex = 0;
            this.button_getStats.Text = "Get Stats";
            this.button_getStats.UseVisualStyleBackColor = true;
            this.button_getStats.Click += new System.EventHandler(this.button_getStats_Click);
            // 
            // text_playername
            // 
            this.text_playername.Location = new System.Drawing.Point(6, 37);
            this.text_playername.Name = "text_playername";
            this.text_playername.Size = new System.Drawing.Size(190, 20);
            this.text_playername.TabIndex = 1;
            this.text_playername.Text = "76561197987123866";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account ID (64-bit)";
            // 
            // groupBox_Query
            // 
            this.groupBox_Query.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_Query.Controls.Add(this.label4);
            this.groupBox_Query.Controls.Add(this.checkBox_Bot);
            this.groupBox_Query.Controls.Add(this.checkBox_Normal);
            this.groupBox_Query.Controls.Add(this.checkedListBox_GameModes);
            this.groupBox_Query.Controls.Add(this.button_FindAccount);
            this.groupBox_Query.Controls.Add(this.label3);
            this.groupBox_Query.Controls.Add(this.comboBox_QueryAmount);
            this.groupBox_Query.Controls.Add(this.text_playername);
            this.groupBox_Query.Controls.Add(this.label1);
            this.groupBox_Query.Location = new System.Drawing.Point(227, 27);
            this.groupBox_Query.Name = "groupBox_Query";
            this.groupBox_Query.Size = new System.Drawing.Size(428, 145);
            this.groupBox_Query.TabIndex = 4;
            this.groupBox_Query.TabStop = false;
            this.groupBox_Query.Text = "Query";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Game Type";
            // 
            // checkedListBox_GameModes
            // 
            this.checkedListBox_GameModes.CheckOnClick = true;
            this.checkedListBox_GameModes.FormattingEnabled = true;
            this.checkedListBox_GameModes.Items.AddRange(new object[] {
            "Any",
            "All Pick",
            "Single Draft",
            "All Random",
            "Random Draft",
            "Captain\'s Draft",
            "Captain\'s Mode",
            "Death Mode",
            "Diretide",
            "Reverse Captain\'s Mode",
            "The Greeviling",
            "Tutorial",
            "Mid Only",
            "Least Played",
            "New Player Pool"});
            this.checkedListBox_GameModes.Location = new System.Drawing.Point(235, 60);
            this.checkedListBox_GameModes.Name = "checkedListBox_GameModes";
            this.checkedListBox_GameModes.Size = new System.Drawing.Size(187, 79);
            this.checkedListBox_GameModes.TabIndex = 6;
            this.checkedListBox_GameModes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_GameModes_ItemCheck);
            // 
            // button_FindAccount
            // 
            this.button_FindAccount.Location = new System.Drawing.Point(105, 12);
            this.button_FindAccount.Name = "button_FindAccount";
            this.button_FindAccount.Size = new System.Drawing.Size(91, 20);
            this.button_FindAccount.TabIndex = 3;
            this.button_FindAccount.Text = "Find Account ID";
            this.button_FindAccount.UseVisualStyleBackColor = true;
            this.button_FindAccount.Click += new System.EventHandler(this.button_FindAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "# of Games";
            // 
            // comboBox_QueryAmount
            // 
            this.comboBox_QueryAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_QueryAmount.FormattingEnabled = true;
            this.comboBox_QueryAmount.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "200"});
            this.comboBox_QueryAmount.Location = new System.Drawing.Point(6, 79);
            this.comboBox_QueryAmount.Name = "comboBox_QueryAmount";
            this.comboBox_QueryAmount.Size = new System.Drawing.Size(65, 21);
            this.comboBox_QueryAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Results";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 656);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(766, 22);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "Ready";
            // 
            // list_results
            // 
            this.list_results.AllColumns.Add(this.olvColumn8);
            this.list_results.AllColumns.Add(this.olvColumn0);
            this.list_results.AllColumns.Add(this.olvColumn1);
            this.list_results.AllColumns.Add(this.olvColumn2);
            this.list_results.AllColumns.Add(this.olvColumn3);
            this.list_results.AllColumns.Add(this.olvColumn4);
            this.list_results.AllColumns.Add(this.olvColumn5);
            this.list_results.AllColumns.Add(this.olvColumn6);
            this.list_results.AllColumns.Add(this.olvColumn7);
            this.list_results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn8,
            this.olvColumn0,
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7});
            this.list_results.FullRowSelect = true;
            this.list_results.GridLines = true;
            this.list_results.IsSimpleDragSource = true;
            this.list_results.Location = new System.Drawing.Point(15, 176);
            this.list_results.Name = "list_results";
            this.list_results.ShowGroups = false;
            this.list_results.Size = new System.Drawing.Size(739, 474);
            this.list_results.TabIndex = 8;
            this.list_results.UseCompatibleStateImageBehavior = false;
            this.list_results.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "MatchID";
            this.olvColumn8.CellPadding = null;
            this.olvColumn8.Text = "MatchID";
            // 
            // olvColumn0
            // 
            this.olvColumn0.AspectName = "GameType";
            this.olvColumn0.CellPadding = null;
            this.olvColumn0.Text = "Game Type";
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "GameResult";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "Result";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Hero";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Hero";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Kills";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.Text = "Kills";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Deaths";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.Text = "Deaths";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Assists";
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.Text = "Assists";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "GPM";
            this.olvColumn6.CellPadding = null;
            this.olvColumn6.Text = "GPM";
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "XPM";
            this.olvColumn7.CellPadding = null;
            this.olvColumn7.Text = "XPM";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // checkBox_Normal
            // 
            this.checkBox_Normal.AutoSize = true;
            this.checkBox_Normal.Location = new System.Drawing.Point(235, 37);
            this.checkBox_Normal.Name = "checkBox_Normal";
            this.checkBox_Normal.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Normal.TabIndex = 7;
            this.checkBox_Normal.Text = "Normal";
            this.checkBox_Normal.UseVisualStyleBackColor = true;
            this.checkBox_Normal.CheckedChanged += new System.EventHandler(this.checkBox_Normal_CheckedChanged);
            // 
            // checkBox_Bot
            // 
            this.checkBox_Bot.AutoSize = true;
            this.checkBox_Bot.Location = new System.Drawing.Point(295, 37);
            this.checkBox_Bot.Name = "checkBox_Bot";
            this.checkBox_Bot.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Bot.TabIndex = 8;
            this.checkBox_Bot.Text = "Co-op";
            this.checkBox_Bot.UseVisualStyleBackColor = true;
            this.checkBox_Bot.CheckedChanged += new System.EventHandler(this.checkBox_Normal_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 678);
            this.Controls.Add(this.list_results);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox_Query);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_getStats);
            this.MainMenuStrip = this.menuStrip1;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(418, 716);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dota 2 Stats Getter";
            this.groupBox_Query.ResumeLayout(false);
            this.groupBox_Query.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_getStats;
        private System.Windows.Forms.TextBox text_playername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_FindAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.MainMenu mainMenu1;
        private BrightIdeasSoftware.ObjectListView list_results;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn0;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_QueryAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox_GameModes;
        private System.Windows.Forms.CheckBox checkBox_Bot;
        private System.Windows.Forms.CheckBox checkBox_Normal;
    }
}

