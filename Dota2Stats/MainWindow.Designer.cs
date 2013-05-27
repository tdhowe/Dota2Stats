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
            this.button_getStats = new System.Windows.Forms.Button();
            this.text_playername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_results = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_getStats
            // 
            this.button_getStats.Location = new System.Drawing.Point(205, 40);
            this.button_getStats.Name = "button_getStats";
            this.button_getStats.Size = new System.Drawing.Size(75, 23);
            this.button_getStats.TabIndex = 0;
            this.button_getStats.Text = "Get Stats";
            this.button_getStats.UseVisualStyleBackColor = true;
            this.button_getStats.Click += new System.EventHandler(this.button_getStats_Click);
            // 
            // text_playername
            // 
            this.text_playername.Location = new System.Drawing.Point(9, 40);
            this.text_playername.Name = "text_playername";
            this.text_playername.Size = new System.Drawing.Size(190, 20);
            this.text_playername.TabIndex = 1;
            this.text_playername.Text = "76561197987123866";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name";
            // 
            // list_results
            // 
            this.list_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_results.Location = new System.Drawing.Point(14, 116);
            this.list_results.Name = "list_results";
            this.list_results.Size = new System.Drawing.Size(612, 308);
            this.list_results.TabIndex = 3;
            this.list_results.UseCompatibleStateImageBehavior = false;
            this.list_results.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_getStats);
            this.groupBox1.Controls.Add(this.text_playername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(148, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Results";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.list_results);
            this.Name = "MainWindow";
            this.Text = "Dota 2 Stats Getter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_getStats;
        private System.Windows.Forms.TextBox text_playername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_results;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

