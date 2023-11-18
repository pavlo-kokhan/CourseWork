namespace CourseWork
{
    partial class MainForm
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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.MainListView = new System.Windows.Forms.ListView();
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ACodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VCodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubtitlesAvaliabilityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainListView
            // 
            this.MainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainListView.BackColor = System.Drawing.Color.White;
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.LocationHeader,
            this.DurationHeader,
            this.ACodecHeader,
            this.VCodecHeader,
            this.SubtitlesAvaliabilityHeader,
            this.SizeHeader,
            this.PlayerHeader});
            this.MainListView.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "NameGroup";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "LocationGroup";
            this.MainListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(106, 30);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(806, 419);
            this.MainListView.TabIndex = 0;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 180;
            // 
            // DurationHeader
            // 
            this.DurationHeader.Text = "Duration";
            this.DurationHeader.Width = 100;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 120;
            // 
            // ACodecHeader
            // 
            this.ACodecHeader.Text = "A. Codec";
            this.ACodecHeader.Width = 80;
            // 
            // VCodecHeader
            // 
            this.VCodecHeader.Text = "V. Codec";
            this.VCodecHeader.Width = 80;
            // 
            // SubtitlesAvaliabilityHeader
            // 
            this.SubtitlesAvaliabilityHeader.Text = "Subtitles";
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "Size";
            this.SizeHeader.Width = 100;
            // 
            // PlayerHeader
            // 
            this.PlayerHeader.Text = "Player";
            this.PlayerHeader.Width = 79;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonsPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonsPanel.Controls.Add(this.button1);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 30);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(88, 419);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.HelpMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuStrip});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(40, 23);
            this.FileMenuStrip.Text = "File";
            // 
            // HelpMenuStrip
            // 
            this.HelpMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuStrip});
            this.HelpMenuStrip.Name = "HelpMenuStrip";
            this.HelpMenuStrip.Size = new System.Drawing.Size(44, 23);
            this.HelpMenuStrip.Text = "Help";
            // 
            // SaveMenuStrip
            // 
            this.SaveMenuStrip.Name = "SaveMenuStrip";
            this.SaveMenuStrip.Size = new System.Drawing.Size(180, 24);
            this.SaveMenuStrip.Text = "Save";
            // 
            // AboutMenuStrip
            // 
            this.AboutMenuStrip.Name = "AboutMenuStrip";
            this.AboutMenuStrip.Size = new System.Drawing.Size(180, 24);
            this.AboutMenuStrip.Text = "About";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(924, 461);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.MainListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(940, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseWork";
            this.ButtonsPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.ColumnHeader DurationHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader ACodecHeader;
        private System.Windows.Forms.ColumnHeader VCodecHeader;
        private System.Windows.Forms.ColumnHeader SubtitlesAvaliabilityHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader PlayerHeader;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuStrip;
        private System.Windows.Forms.Button button1;
    }
}

