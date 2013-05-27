namespace Dota2Stats
{
    partial class SteamIDWindow
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
            this.button_Find = new System.Windows.Forms.Button();
            this.text_Input = new System.Windows.Forms.TextBox();
            this.listView_Results = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(270, 22);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(95, 23);
            this.button_Find.TabIndex = 1;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            this.button_Find.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SteamIDWindow_KeyPress);
            // 
            // text_Input
            // 
            this.text_Input.Location = new System.Drawing.Point(11, 25);
            this.text_Input.Name = "text_Input";
            this.text_Input.Size = new System.Drawing.Size(253, 20);
            this.text_Input.TabIndex = 0;
            this.text_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SteamIDWindow_KeyPress);
            // 
            // listView_Results
            // 
            this.listView_Results.Location = new System.Drawing.Point(11, 51);
            this.listView_Results.Name = "listView_Results";
            this.listView_Results.Size = new System.Drawing.Size(354, 383);
            this.listView_Results.TabIndex = 2;
            this.listView_Results.TileSize = new System.Drawing.Size(200, 30);
            this.listView_Results.UseCompatibleStateImageBehavior = false;
            this.listView_Results.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView_Results_KeyPress);
            this.listView_Results.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Results_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Steam Name";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 440);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(374, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "Ready";
            // 
            // SteamIDWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 462);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Results);
            this.Controls.Add(this.text_Input);
            this.Controls.Add(this.button_Find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SteamIDWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Steam Account ID";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SteamIDWindow_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.TextBox text_Input;
        private System.Windows.Forms.ListView listView_Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusBar statusBar;
    }
}