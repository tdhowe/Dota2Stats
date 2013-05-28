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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_FindAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.list_results = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn0 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_results)).BeginInit();
            this.SuspendLayout();
            // 
            // button_getStats
            // 
            this.button_getStats.Location = new System.Drawing.Point(206, 113);
            this.button_getStats.Name = "button_getStats";
            this.button_getStats.Size = new System.Drawing.Size(75, 23);
            this.button_getStats.TabIndex = 0;
            this.button_getStats.Text = "Get Stats";
            this.button_getStats.UseVisualStyleBackColor = true;
            this.button_getStats.Click += new System.EventHandler(this.button_getStats_Click);
            // 
            // text_playername
            // 
            this.text_playername.Location = new System.Drawing.Point(10, 113);
            this.text_playername.Name = "text_playername";
            this.text_playername.Size = new System.Drawing.Size(190, 20);
            this.text_playername.TabIndex = 1;
            this.text_playername.Text = "76561197987123866";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account ID (64-bit)";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button_FindAccount);
            this.groupBox1.Controls.Add(this.button_getStats);
            this.groupBox1.Controls.Add(this.text_playername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(139, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // button_FindAccount
            // 
            this.button_FindAccount.Location = new System.Drawing.Point(70, 31);
            this.button_FindAccount.Name = "button_FindAccount";
            this.button_FindAccount.Size = new System.Drawing.Size(130, 40);
            this.button_FindAccount.TabIndex = 3;
            this.button_FindAccount.Text = "Find Account ID";
            this.button_FindAccount.UseVisualStyleBackColor = true;
            this.button_FindAccount.Click += new System.EventHandler(this.button_FindAccount_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
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
            this.statusBar.Location = new System.Drawing.Point(0, 655);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(570, 22);
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
            this.list_results.Location = new System.Drawing.Point(15, 175);
            this.list_results.Name = "list_results";
            this.list_results.ShowGroups = false;
            this.list_results.Size = new System.Drawing.Size(543, 474);
            this.list_results.TabIndex = 8;
            this.list_results.UseCompatibleStateImageBehavior = false;
            this.list_results.View = System.Windows.Forms.View.Details;
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
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "MatchID";
            this.olvColumn8.CellPadding = null;
            this.olvColumn8.Text = "MatchID";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 677);
            this.Controls.Add(this.list_results);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(418, 412);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dota 2 Stats Getter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_getStats;
        private System.Windows.Forms.TextBox text_playername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

